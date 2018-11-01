
namespace ScalesOnCordTypes
{
    class Diminished
    {
        public string diminishedScale;

        public Diminished(string keyNote)
        {
            string note1, note2, note3, note4, note5, note6, note7, note8, note9;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("H W H W H W H W");
            note1 = keyNote;

            //intervalli1 = "H";
            note2 = hs.getScales(note1);

            //intervalli2 = "W";
            note3 = ws.getScales(note2);

            //intervalli3 = "H";
            note4 = hs.getScales(note3);

            //intervalli4 = "W";
            note5 = ws.getScales(note4);

            //intervalli5 = "H";
            note6 = hs.getScales(note5);

            //intervalli6 = "W";
            note7 = ws.getScales(note6);

            //intervalli6 = "H";
            note8 = hs.getScales(note7);

            //intervalli6 = "W";
            note9 = ws.getScales(note8);

            this.diminishedScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8 + "   " + note9;
        }
    }
}
