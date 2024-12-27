using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalAppPROGPOE
{
    public class MultiMap<TKey, TValue>
    {
        private Dictionary<TKey, List<Issues>> map;

        public MultiMap()
        {
            map = new Dictionary<TKey, List<Issues>>();
        }

        // Adds a value to the map for the given key
        public void Add(TKey key, Issues value)
        {
            if (!map.ContainsKey(key))
            {
                map[key] = new List<Issues>();
            }
            map[key].Add(value);
        }

        // Removes a value for the given key
        public bool Remove(TKey key, Issues value)
        {
            if (map.ContainsKey(key))
            {
                return map[key].Remove(value);
            }
            return false;
        }

        // Gets all values associated with the key
        public IEnumerable<Issues> GetValues(TKey key)
        {
            if (map.ContainsKey(key))
            {
                return map[key];
            }
            return new List<Issues>(); // return empty list if no key is found
        }

        // Removes the entire key and associated values
        public bool RemoveKey(TKey key)
        {
            return map.Remove(key);
        }

        // Checks if the key exists
        public bool ContainsKey(TKey key)
        {
            return map.ContainsKey(key);
        }

        // Checks if the value exists for a given key
        public bool ContainsValue(TKey key, Issues value)
        {
            return map.ContainsKey(key) && map[key].Contains(value);
        }

        // returns the total count of all entries in the multimap
        public int Count
        {
            get
            {
                int count = 0;
                foreach (var list in map.Values)
                {
                    count += list.Count;
                }
                return count;
            }
        }
    }
}
