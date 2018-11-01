
using System.Collections.Generic;

namespace ScalesOnCordTypes
{
    public class WS
    {
        public string getScales(string savel)
        {
            // Create Dictionary.
            Dictionary<string, string> hash = new Dictionary<string, string>();

            hash.Add("C", "D");
            hash.Add("C#", "D#");
            hash.Add("D", "E");
            hash.Add("D#", "F");
            hash.Add("E", "F#");
            hash.Add("F", "G");
            hash.Add("F#", "G#");
            hash.Add("G", "A");
            hash.Add("G#", "A#");
            hash.Add("A", "B");
            hash.Add("A#", "C");
            hash.Add("B", "C#");

            hash.TryGetValue(savel, out string value);
            return value;
        }
    }
}
