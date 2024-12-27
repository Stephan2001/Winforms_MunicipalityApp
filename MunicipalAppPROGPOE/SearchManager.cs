using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MunicipalAppPROGPOE
{
    public class SearchManager
    {
        public EventManager _eventManager;
        public Stack<Event> recommendedStack;
        public Stack<Event> eventQueue;
        public Stack<Event> eventStack;
        public HashSet<string> recentSearchHistoryKeywords; // prioritised recomendations for recent searches
        public HashSet<string> searchHistoryKeywords; // this is for saving history of keywords -> recomendations

        // set of ignmored keywords
        HashSet<string> ignoredWords = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "and", "or", "of", "the", "is", "in", "on", "to", "a", "an", "can", "how", "this", "that", "i"
        };

        public SearchManager()
        {
            _eventManager = new EventManager();
            eventQueue = new Stack<Event>();
            recommendedStack = new Stack<Event>();
            eventStack = new Stack<Event>();
            searchHistoryKeywords = new HashSet<string>();
            _eventManager.ReadEventsFromCSV();
        }

        public void ManageSearch(string userinput)
        {
            // clear existing stacks
            eventQueue.Clear();
            eventStack.Clear();
            recommendedStack.Clear();
            // tolower
            userinput = userinput.ToLower();

            var datePattern = @"\d{1,2}[/-]\d{1,2}[/-]\d{4}|\d{1,2}\s+[A-Za-z]+\s+\d{4}";
            var keywordPattern = @"\w+";

            // finding any possible dates in the user query
            var dateSet = Regex.Matches(userinput, datePattern)
                                .Cast<Match>()
                                .Select(m => m.Value)
                                .ToHashSet();
            // need to convert my dateSet to match dd-mm-yyyy to use them for search
            dateSet = StanderdiseDates(dateSet);

            // finding all possible keywords in the user query
            var keywordsSet = Regex.Matches(userinput, keywordPattern)
                                   .Cast<Match>()
                                   .Select(m => m.Value)
                                   .ToHashSet();
            // remove ignored keywords
            keywordsSet = RemoveIgnoredKeywords(keywordsSet);

            // populating search history
            foreach (var tag in keywordsSet)
            {
                searchHistoryKeywords.Add(tag);
            }

            // populating recent search history (creates new hashet each query)
            recentSearchHistoryKeywords = new HashSet<string>(keywordsSet);

            Dictionary<Event, int> eventScores = ScoreEvents(keywordsSet, dateSet);
            // Sort events by scores (higher score comes first)
            var sortedEvents = eventScores.OrderBy(kvp => kvp.Value)
                                          .Select(kvp => kvp.Key)
                                          .ToList();

            // Queue the sorted events
            Debug.WriteLine("");
            foreach (var evnt in sortedEvents)
            {
                //Debug.WriteLine("Final main events: " + evnt.Name);
                eventQueue.Push(evnt);
            }

            Dictionary<Event, int> eventRecomendationsScores = ScoreRecomendedEvents(keywordsSet, dateSet);

            // Sort events by scores (higher score comes first)
            var sortedRecomendationsEvents = eventRecomendationsScores.OrderBy(kvp => kvp.Value)
                                          .Select(kvp => kvp.Key)
                                          .ToList();

            // Queue the recomended events
            Debug.WriteLine("");
            foreach (var evnt in sortedRecomendationsEvents)
            {
                //Debug.WriteLine("Final Recomended events: " + evnt.Name);
                recommendedStack.Push(evnt);
            }
        }

        // used to rank events by relevancy
        public Dictionary<Event, int> ScoreEvents(HashSet<string> keywordsSet, HashSet<string> dateSet)
        {
            Dictionary<Event, int> eventScores = new Dictionary<Event, int>();
            // Prioritize by Name Matches
            var relevantNames = SearchByName(keywordsSet);
            foreach (var relevant in relevantNames)
            {
                if (!eventScores.ContainsKey(relevant))
                {
                    eventScores[relevant] = 0;
                }
                eventScores[relevant] += 10;
            }

            // Prioritize by Date Matches
            foreach (var date in dateSet)
            {
                var relevantEvents = SearchByDate(date);
                foreach (var relevant in relevantEvents)
                {
                    if (!eventScores.ContainsKey(relevant))
                    {
                        eventScores[relevant] = 0;
                    }
                    eventScores[relevant] += 5;
                }
            }

            // Prioritize by Tag Matches
            foreach (var keyword in keywordsSet)
            {
                var relevantEvents = SearchByTag(keyword);
                foreach (var relevant in relevantEvents)
                {
                    if (!eventScores.ContainsKey(relevant))
                    {
                        eventScores[relevant] = 0;
                    }
                    eventScores[relevant] += 3;
                }
            }
            return eventScores;
        }

        // used to rank recommended events by relevancy
        public Dictionary<Event, int> ScoreRecomendedEvents(HashSet<string> keywordsSet, HashSet<string> dateSet)
        {
            Dictionary<Event, int> eventScores = new Dictionary<Event, int>();
            // Prioritize by Name Matches
            var relevantNames = SearchByName(keywordsSet);
            foreach (var relevant in relevantNames)
            {
                if (!eventScores.ContainsKey(relevant))
                {
                    eventScores[relevant] = 0;
                }
                eventScores[relevant] += 5;
            }

            // Prioritize by Date Matches
            foreach (var date in dateSet)
            {
                var relevantEvents = SearchByDate(date);
                foreach (var relevant in relevantEvents)
                {
                    if (!eventScores.ContainsKey(relevant))
                    {
                        eventScores[relevant] = 0;
                    }
                    eventScores[relevant] += 5;
                }
            }

            // Prioritize by Tag Matches
            foreach (var keyword in keywordsSet)
            {
                var relevantEvents = SearchByTag(keyword);
                foreach (var relevant in relevantEvents)
                {
                    if (!eventScores.ContainsKey(relevant))
                    {
                        eventScores[relevant] = 0;
                    }
                    eventScores[relevant] += 3;
                }
            }

            foreach (var recentKeyword in recentSearchHistoryKeywords)
            {
                var relevantEvents = SearchByTag(recentKeyword);
                foreach (var relevant in relevantEvents)
                {
                    if (!eventScores.ContainsKey(relevant))
                    {
                        eventScores[relevant] = 0;
                    }
                    eventScores[relevant] += 20;
                }
            }

            // Add more weight for older searches in recommendations
            foreach (var olderKeyword in searchHistoryKeywords)
            {
                var relevantEvents = SearchByTag(olderKeyword);
                foreach (var relevant in relevantEvents)
                {
                    if (!eventScores.ContainsKey(relevant))
                    {
                        eventScores[relevant] = 0;
                    }
                    eventScores[relevant] += 5;  // Moderate weight for older search history
                }
            }

            return eventScores;
        }

        // Method to search events by date
        public List<Event> SearchByDate(string date)
        {
            return _eventManager.SearchByDate(date);
        }

        // Method to search events by tag
        public List<Event> SearchByTag(string tag)
        {
            return _eventManager.SearchByTag(tag);
        }

        // search for event name
        public List<Event> SearchByName(HashSet<string> keywordSet)
        {
            return _eventManager.SearchByName(keywordSet);
        }

        public HashSet<string> RemoveIgnoredKeywords(HashSet<string> searchKeywords)
        {
            return new HashSet<string>(searchKeywords.Except(ignoredWords));
        }

        // convert all dates to specific format dd-mm-yyyy
        public HashSet<string> StanderdiseDates(HashSet<string> dateSet)
        {
            HashSet<string> standardizedDates = new HashSet<string>();
            // accepted formats
            string[] dateFormats = {
                "dd/MM/yyyy",
                "dd-MM-yyyy",
                "dd MMMM yyyy"
            };
            foreach (string dateString in dateSet)
            {
                if (DateTime.TryParseExact(dateString, dateFormats,
                                           CultureInfo.InvariantCulture,
                                           DateTimeStyles.None,
                                           out DateTime parsedDate))
                {
                    // Convert to dd-MM-yyyy format and add to the new HashSet
                    standardizedDates.Add(parsedDate.ToString("dd-MM-yyyy"));
                }
                else
                {
                    Debug.WriteLine($"Unable to parse date: {dateString}");
                }
            }
            return standardizedDates;
        }

        public Event NextEvent()
        {
            if (eventQueue.Count > 0)
            {
                Event evnt = eventQueue.Pop();
                eventStack.Push(evnt);
                return evnt;
            }
            return null;
        }

        public Event NextRecomendedEvent()
        {
            if (recommendedStack.Count > 0)
            {
                Event evnt = recommendedStack.Pop();
                return evnt;
            }
            return null;
        }

        // Move to the previous event (backward)
        public Event PreviousEvent()
        {
            if (eventStack.Count > 1)
            {
                Event temp = eventStack.Pop();
                Event evnt = eventStack.Peek();
                eventQueue.Push(temp);
                return evnt;
            }
            return null;
        }
    }
}
