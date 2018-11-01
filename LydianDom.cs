﻿using System;

namespace ScalesOnCordTypes
{
    public class LydianDom
    {

        public String lydianDominantScale;

        public LydianDom(String keyNote)
        {

            String note1, note2, note3, note4, note5, note6, note7, note8;

            WS ws = new WS();
            HS hs = new HS();

            //System.out.println("Lydian dominant/Acoustic scale for V cord (7)");
            //System.out.println(" W W W H W H W ");

                note1 = keyNote;

                //intervalli1 = "W";
                note2 = ws.getScales(keyNote);

                //intervalli2 = "W";
                note3 = ws.getScales(note2);

                //intervalli3 = "W";
                note4 = ws.getScales(note3);

                //intervalli4 = "H";
                note5 = hs.getScales(note4);

                //intervalli5 = "W";
                note6 = ws.getScales(note5);

                //intervalli6 = "H";
                note7 = hs.getScales(note6);

                //intervalli7 = "W";
                note8 = ws.getScales(note7);

                this.lydianDominantScale = keyNote + "   " + note2 + "   " + note3 + "   " + note4 + "   " + note5 + "   " + note6 + "   " + note7 + "   " + note8;
          
        }

    }
}
