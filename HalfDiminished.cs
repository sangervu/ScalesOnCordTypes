
namespace ScalesOnCordTypes
{
    class HalfDiminished
    {
        public string halfDiminishedScale;

        public HalfDiminished(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("Half diminished scale for II cord (mi7b5)");
            //System.out.println(" W H W H W W W ");

            note1 = keyNote;

                //intervalli1 = "W";
                note2 = ws.getScales(note1);

                //intervalli2 = "H";
                note3 = hs.getScales(note2);

                //intervalli3 = "W";
                note4 = ws.getScales(note3);

                //intervalli4 = "H";
                note5 = hs.getScales(note4);

                //intervalli5 = "W";
                note6 = ws.getScales(note5);

                //intervalli6 = "W";
                note7 = ws.getScales(note6);

                //intervalli7 = "W";
                note8 = ws.getScales(note7);

                this.halfDiminishedScale = keyNote + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;        
        }

    }
}
