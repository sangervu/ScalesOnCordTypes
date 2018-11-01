
namespace ScalesOnCordTypes
{
    public class ChurchModes
    {
        public string ionian;
        public string dorian;
        public string phrygian;
        public string lydian;
        public string mixolydian;
        public string aeolian;
        public string locrian;

        public ChurchModes(string keyNote)
        {
            string note1, note2, note3, note4, note5, note6, note7;
            WS ws = new WS();
            HS hs = new HS(); ;

            // Find the new roots for the Curch Modes from the Major scale  W W H W W W H

            note1 = keyNote;
            this.ionian = keyNote;
            //intervalli1 = "W";
            note2 = ws.getScales(note1);
            this.dorian = note2;
            //intervalli1 = "W";
            note3 = ws.getScales(note2);
            this.phrygian = note3;
            //intervalli1 = "H";
            note4 = hs.getScales(note3);
            this.lydian = note4;
            //intervalli1 = "W";
            note5 = ws.getScales(note4);
            this.mixolydian = note5;
            //intervalli1 = "W";
            note6 = ws.getScales(note5);
            this.aeolian = note6;
            //intervalli1 = "W";
            note7 = ws.getScales(note6);
            this.locrian = note7;
        }
    }
}
