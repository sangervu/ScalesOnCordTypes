
namespace ScalesOnCordTypes
{
    class Aeolian
    {
        public string aeolianScale;

        public string tonic;
        public string subDom;
        public string dominant;

        public Aeolian(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("W H W W H W W");
            note1 = keyNote;

            //intervalli1 = "W";
            note2 = ws.getScales(note1);

            //intervalli2 = "H";
            note3 = hs.getScales(note2);
            this.tonic = note3;

            //intervalli3 = "W";
            note4 = ws.getScales(note3);

            //intervalli4 = "W";
            note5 = ws.getScales(note4);

            //intervalli5 = "H";
            note6 = hs.getScales(note5);
            this.subDom = note6;

            //intervalli6 = "W";
            note7 = ws.getScales(note6);
            this.dominant = note7;

            //intervalli7 = "W";
            note8 = ws.getScales(note7);

            this.aeolianScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;
        }
    }
}
