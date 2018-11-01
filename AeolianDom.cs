
namespace ScalesOnCordTypes
{
    public class AeolianDom
    {

        public string aeolianDomScale;

        public AeolianDom(string keyNote)
        {

            string note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();


                //System.out.println("Aeolian dominant scale for V cord (7)");
                //System.out.println(" W W H W H W W ");

                note1 = keyNote;

                //intervalli1 = "W";
                note2 = ws.getScales(note1);

                //intervalli2 = "W";
                note3 = ws.getScales(note2);

                //intervalli3 = "H";
                note4 = hs.getScales(note3);

                //intervalli4 = "W";
                note5 = ws.getScales(note4);

                //intervalli5 = "H";
                note6 = hs.getScales(note5);

                //intervalli6 = "W";
                note7 = ws.getScales(note6);

                //intervalli7 = "W";
                note8 = ws.getScales(note7);

                this.aeolianDomScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;

           

            
        }

    }

}