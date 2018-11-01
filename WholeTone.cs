
namespace ScalesOnCordTypes
{
    class WholeTone
    {

            public string wholeToneScale;


            public WholeTone(string keyNote)
            {

                string note1, note2, note3, note4, note5, note6, note7;

                WS ws = new WS();
                //HS hs = new HS();

                //System.out.println("W W W W W W");
                note1 = keyNote;
        
                //intervalli1 = "W";
                note2 = ws.getScales(note1);

                //intervalli2 = "W";
                note3 = ws.getScales(note2);

                //intervalli3 = "H";
                note4 = ws.getScales(note3);
        

                //intervalli4 = "W";
                note5 = ws.getScales(note4);

                //intervalli5 = "W";
                note6 = ws.getScales(note5);

                //intervalli6 = "W";
                note7 = ws.getScales(note6);


                this.wholeToneScale = note1 + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7;
            }
        


    }
}
