
namespace ScalesOnCordTypes
{
    public class Dorianb2
    {

        public string dorianb2Scale;

        public Dorianb2(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println(" H W W W W H W ");
            note1 = keyNote;

                //intervalli1 = "H";
                note2 = hs.getScales(note1);

                //intervalli2 = "W";
                note3 = ws.getScales(note2);

                //intervalli3 = "W";
                note4 = ws.getScales(note3);

                //intervalli4 = "W";
                note5 = ws.getScales(note4);

                //intervalli5 = "W";
                note6 = ws.getScales(note5);

                //intervalli6 = "H";
                note7 = hs.getScales(note6);

                //intervalli7 = "W";
                note8 = ws.getScales(note7);

                this.dorianb2Scale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;       
        }

    }
}
