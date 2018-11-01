using System;

namespace ScalesOnCordTypes
{
    public class LydianAug
    {

        public String lydianAugmentedScale;

        public LydianAug(String keyNote)
        {

            String note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("Ma7#5 Lydian augmented scale");
            //System.out.println(" W W W W H W H ");

            note1 = keyNote;

            //intervalli1 = "W";
            note2 = ws.getScales(note1);

            //intervalli2 = "W";
            note3 = ws.getScales(note2);

            //intervalli3 = "W";
            note4 = ws.getScales(note3);

            //intervalli4 = "W";
            note5 = ws.getScales(note4);

            //intervalli5 = "H";
            note6 = hs.getScales(note5);

            //intervalli6 = "W";
            note7 = ws.getScales(note6);

            //intervalli7 = "H";
            note8 = hs.getScales(note7);

            this.lydianAugmentedScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;


        }

    }
}
