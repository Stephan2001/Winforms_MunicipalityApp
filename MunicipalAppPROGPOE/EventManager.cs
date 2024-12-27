using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MunicipalAppPROGPOE
{
    public class EventManager
    {
        public string filePath;
        public SortedDictionary<string, List<Event>> eventsByDate;
        public HashSet<string> uniqueTags;

        public EventManager()
        {
            filePath = GetFilePath("event_data_combined.csv");
            eventsByDate = new SortedDictionary<string, List<Event>>();
            uniqueTags = new HashSet<string>();
        }

        public string GetFilePath(string fileName)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory; // Application's base directory
            return Path.Combine(basePath, fileName);
        }

        // add event to SortedDictionary
        public void AddEvent(Event newEvent)
        {
            // Add to the sorted dictionary
            if (!eventsByDate.ContainsKey(newEvent.Date))
            {
                eventsByDate[newEvent.Date] = new List<Event>();
            }
            eventsByDate[newEvent.Date].Add(newEvent);

            // Add unique tags
            foreach (var tag in newEvent.Tags)
            {
                uniqueTags.Add(tag);
            }
        }

        // search event by date -> includes events from approximite next 30 days 
        public List<Event> SearchByDate(string date)
        {
            // find specified date
            if (eventsByDate.TryGetValue(date, out List<Event> events))
            {
                return events;
            }

            // No exact matches found, search closeby events by date
            List<Event> closeEvents = new List<Event>();
            DateTime searchDate;

            // Parse input date to DateTime
            if (DateTime.TryParse(date, out searchDate))
            {
                foreach (var evnt in eventsByDate)
                {
                    DateTime eventDate;

                    // Parse date to DateTime
                    if (DateTime.TryParse(evnt.Key, out eventDate))
                    {
                        // Check if the event is in the future and within 30 days
                        if (eventDate > searchDate && eventDate <= searchDate.AddDays(30))
                        {
                            closeEvents.AddRange(evnt.Value);
                        }
                    }
                }
            }

            return closeEvents;
        }

        // search event by tag
        public List<Event> SearchByTag(string tag)
        {
            List<Event> foundEvents = new List<Event>();
            foreach (var eventList in eventsByDate.Values)
            {
                foundEvents.AddRange(eventList.FindAll(e => e.Tags.Contains(tag)));
            }
            return foundEvents;
        }

        // search event by name
        public List<Event> SearchByName(HashSet<string> NameSet)
        {
            List<Event> foundEvents = new List<Event>();
            foreach (var eventList in eventsByDate.Values)
            {
                foreach (var evnt in eventList)
                {
                    HashSet<string> eventName = new HashSet<string>();
                    string[] splitKeywords = Regex.Split(evnt.Name, @"\s+");
                    foreach (string splitKeyword in splitKeywords)
                    {
                        eventName.Add(splitKeyword);
                    }

                    if (NameSet.Overlaps(eventName))
                    {
                        foundEvents.Add(evnt);
                    }
                }
            }
            return foundEvents;
        }

        // read events from CSV file
        public void ReadEventsFromCSV()
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] columns = line.Split(',');

                        if (columns.Length >= 3)
                        {
                            string date = columns[0];
                            string eventName = columns[1];

                            HashSet<string> tags = new HashSet<string>(columns[2..]);

                            Event evt = new Event(eventName, date, tags);
                            AddEvent(evt);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error reading CSV file: " + e.Message);
            }
        }
    }
}
