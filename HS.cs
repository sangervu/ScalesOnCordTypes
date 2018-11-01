
using System.Collections.Generic;

namespace ScalesOnCordTypes
{
    public class HS
    {
        public string getScales(string savel)
        {

            // Create Dictionary.
            Dictionary<string, string> hash = new Dictionary<string, string>();

            hash.Add("C", "C#");
            hash.Add("C#", "D");
            hash.Add("D", "D#");
            hash.Add("D#", "E");
            hash.Add("E", "F");
            hash.Add("F", "F#");
            hash.Add("F#", "G");
            hash.Add("G", "G#");
            hash.Add("G#", "A");
            hash.Add("A", "A#");
            hash.Add("A#", "B");
            hash.Add("B", "C");

            hash.TryGetValue(savel, out string value);
            return value;
        }
    }
}
