
namespace ScalesOnCordTypes
{
    public class Lydian
    {

        public string lydianScale;

        public string tonic;
        public string subDom;
        public string dominant;

        public Lydian(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("W W W H W W H");
            note1 = keyNote;
            this.subDom = note1;

            //intervalli1 = "W";
            note2 = ws.getScales(note1);
            this.dominant = note2;

            //intervalli2 = "W";
            note3 = ws.getScales(note2);

            //intervalli3 = "W";
            note4 = ws.getScales(note3);

            //intervalli4 = "H";
            note5 = hs.getScales(note4);
            this.tonic = note5;

            //intervalli5 = "W";
            note6 = ws.getScales(note5);

            //intervalli6 = "W";
            note7 = ws.getScales(note6);
            

            //intervalli7 = "H";
            note8 = hs.getScales(note7);

            this.lydianScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;
        }
    }
}
