
namespace ScalesOnCordTypes
{
    class Ionian
    {
        public string ionianScale;

        public string tonic;
        public string subDom;
        public string dominant;

        public Ionian(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println(" W W H W W W H ");
            note1 = keyNote;
            this.tonic = note1;

            //intervalli1 = "W";
            note2 = ws.getScales(note1);

            //intervalli2 = "W";
            note3 = ws.getScales(note2);

            //intervalli3 = "H";
            note4 = hs.getScales(note3);
            this.subDom = note4;

            //intervalli4 = "W";
            note5 = ws.getScales(note4);
            this.dominant = note5;

            //intervalli5 = "W";
            note6 = ws.getScales(note5);

            //intervalli6 = "W";
            note7 = ws.getScales(note6);

            //intervalli7 = "H";
            note8 = hs.getScales(note7);

            this.ionianScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;
        }
    }
}
