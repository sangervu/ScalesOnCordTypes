
namespace ScalesOnCordTypes
{
    public class Phrygian
    {

        public string phrygianScale;

        public string tonic;
        public string subDom;
        public string dominant;

        public Phrygian(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("H W W W H W W");
            note1 = keyNote;

            //intervalli1 = "H";
            note2 = hs.getScales(note1);
            this.subDom = note2;

            //intervalli2 = "W";
            note3 = ws.getScales(note2);
            this.dominant = note3;

            //intervalli3 = "W";
            note4 = ws.getScales(note3);
            
            //intervalli4 = "W";
            note5 = ws.getScales(note4);

            //intervalli5 = "H";
            note6 = hs.getScales(note5);
            this.tonic = note6;

            //intervalli6 = "W";
            note7 = ws.getScales(note6);
            
            //intervalli7 = "W";
            note8 = ws.getScales(note7);

            this.phrygianScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;
        }
    }
}
