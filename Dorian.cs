
namespace ScalesOnCordTypes
{
    public class Dorian
    {

        public string dorianScale;

        public string tonic;
        public string subDom;
        public string dominant;

        public Dorian(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println(" W H W W W H W ");
            note1 = keyNote;

            //intervalli1 = "W";
            note2 = ws.getScales(note1);

            //intervalli2 = "H";
            note3 = hs.getScales(note2);
            this.subDom = note3;

            //intervalli3 = "W";
            note4 = ws.getScales(note3);
            this.dominant = note4;

            //intervalli4 = "W";
            note5 = ws.getScales(note4);

            //intervalli5 = "W";
            note6 = ws.getScales(note5);

            //intervalli6 = "H";
            note7 = hs.getScales(note6);
            this.tonic = note7;

            //intervalli7 = "W";
            note8 = ws.getScales(note7);


            this.dorianScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;
        }
    }
}
