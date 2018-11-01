
namespace ScalesOnCordTypes
{
    class Mixolydian
    {
        public string mixolydianScale;

        public string tonic;
        public string subDom;
        public string dominant;

        public Mixolydian(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("W W H W W H W");
            note1 = keyNote;
            this.dominant = note1;
            //intervalli1 = "W";
            note2 = ws.getScales(note1);

            //intervalli2 = "W";
            note3 = ws.getScales(note2);

            //intervalli3 = "H";
            note4 = hs.getScales(note3);
            this.tonic = note4;

            //intervalli4 = "W";
            note5 = ws.getScales(note4);

            //intervalli5 = "W";
            note6 = ws.getScales(note5);

            //intervalli6 = "H";
            note7 = hs.getScales(note6);
            this.subDom = note7;

            //intervalli7 = "W";
            note8 = ws.getScales(note7);     

            this.mixolydianScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;
        }
    }
}
