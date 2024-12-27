using System;
using System.Collections;
using System.Collections.Generic;

namespace MunicipalAppPROGPOE
{
    public class Event
    {
        public string Name { get; }
        public string Date { get; }
        public HashSet<string> Tags { get; }

        public Event(string name, string date, HashSet<string> tags)
        {
            Name = name;
            Date = date;
            Tags = tags;
        }

        // Override Equals method
        public override bool Equals(object obj)
        {
            if (obj is Event otherEvent)
            {
                // Compare Name, Date, and Tags
                return Name == otherEvent.Name &&
                       Date == otherEvent.Date &&
                       Tags.SetEquals(otherEvent.Tags); // Compare the contents of the Tags HashSet
            }
            return false;
        }

        // Override GetHashCode method
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + (Name?.GetHashCode() ?? 0);
            hash = hash * 31 + (Date?.GetHashCode() ?? 0);
            hash = hash * 31 + (Tags != null ? Tags.Aggregate(0, (current, tag) => current ^ tag.GetHashCode()) : 0);
            return hash;
        }
    }
}
