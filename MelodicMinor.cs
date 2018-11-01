/*
* @author Sakari Angervuori
*/

namespace ScalesOnCordTypes
{
    public class MelodicMinor
    {
        public string melodicMinorScale;

        public MelodicMinor(string keyNote)
        {
            string note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println(" W H W W W W H ");
            //intervalli1 = "W";
            note2 = ws.getScales(keyNote);

                //intervalli2 = "H";
                note3 = hs.getScales(note2);

                //intervalli3 = "W";
                note4 = ws.getScales(note3);

                //intervalli4 = "W";
                note5 = ws.getScales(note4);

                //intervalli5 = "W";
                note6 = ws.getScales(note5);

                //intervalli6 = "W";
                note7 = ws.getScales(note6);

                //intervalli7 = "H";
                note8 = hs.getScales(note7);

                this.melodicMinorScale = keyNote + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;                      
        }

    }
}
