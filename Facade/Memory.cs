using System.Collections.Generic;
using System.Collections.Specialized;

namespace Facade
{
    class Memory
    {
        private static Dictionary<string, string> Mem = new Dictionary<string, string>();

        public static void Load(string key, string data)
        {
            Mem.Add(key, data);
        }

        public static string Read(string key)
        {
            return Mem.GetValueOrDefault(key);
        }
    }
}
