
namespace ScalesOnCordTypes
{
    class Locrian
    {
        public string locrianScale;

        public string tonic;
        public string subDom;
        public string dominant;

        public Locrian(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("H W W H W W W");
            note1 = keyNote;

            //intervalli1 = "H";
            note2 = hs.getScales(note1);
            this.tonic = note2;

            //intervalli2 = "W";
            note3 = ws.getScales(note2);

            //intervalli3 = "W";
            note4 = ws.getScales(note3);

            //intervalli4 = "H";
            note5 = hs.getScales(note4);
            this.subDom = note5
                ;
            //intervalli5 = "W";
            note6 = ws.getScales(note5);
            this.dominant = note6;

            //intervalli6 = "W";
            note7 = ws.getScales(note6);         

            //intervalli7 = "W";
            note8 = ws.getScales(note7);

            this.locrianScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;
        }
    }
}
