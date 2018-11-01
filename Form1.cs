using System;
using System.Collections.Generic;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace ScalesOnCordTypes
{
    public partial class Form1 : Form

    {
        private string postFix;
        private string keyNote;
        private string keyNoteNull;
        private string newKeyNote;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            cboState.Items.Clear();
            List<RootNotes> list = new List<RootNotes>();
            list.Add(new RootNotes() { ID = "01", Name = "C" });
            list.Add(new RootNotes() { ID = "02", Name = "D" });
            list.Add(new RootNotes() { ID = "03", Name = "E" });
            list.Add(new RootNotes() { ID = "04", Name = "F" });
            list.Add(new RootNotes() { ID = "05", Name = "G" });
            list.Add(new RootNotes() { ID = "06", Name = "A" });
            list.Add(new RootNotes() { ID = "07", Name = "B" });
            cboState.DataSource = list;
            cboState.ValueMember = "ID";
            cboState.DisplayMember = "name";
            cboState.SelectedIndex = 4;
        }

        private void isSharp_CheckedChanged(object sender, EventArgs e)
        {
            if (isSharp.Checked)
            {
                this.postFix = "#";
                this.keyNote = cboState.Text + postFix;
            }
        }

        private void isFlat_CheckedChanged(object sender, EventArgs e)
        {
            if (isFlat.Checked)
            {
                this.postFix = "b";
                this.keyNote = cboState.Text + postFix;
            }
        }

        private void isNone_CheckedChanged(object sender, EventArgs e)
        {
            if (isNone.Checked)
            {
                this.postFix = "";
                this.keyNote = cboState.Text + postFix;
            }
        }
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {

            RootNotes obj = cboState.SelectedItem as RootNotes;
            if (obj != null)
            {
                this.keyNote = cboState.Text + postFix;
                this.keyNoteNull = cboState.Text;
            }
        }

        private void major_I_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;

            //Ionian
            Intervals_I.Text = "W   W   H   W   W   W   H";
            ScaleName_I.Text = "Ionian";
            mode_I.Text = "MA7";
            //newKey = churchModes.ionian;
            Ionian ionian = new Ionian(keyNote);
            scaleNotes_I.Text = ionian.ionianScale;

            //Lydian
            Intervals_II.Text = "W   W   W   H   W   W   H";
            ScaleName_II.Text = "Lydian";
            mode_II.Text = "MA7";
            Lydian lydian = new Lydian(keyNote);
            scaleNotes_II.Text = lydian.lydianScale;

            //Lydian augmneted
            Intervals_III.Text = "W   W   W   W   H   W   H";
            ScaleName_III.Text = "Lydian Aug";
            mode_III.Text = "MA7#5";
            LydianAug lydianAug = new LydianAug(keyNote);
            scaleNotes_III.Text = lydianAug.lydianAugmentedScale;
        }

        private void major_II_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;

            ChurchModes newKey = new ChurchModes(keyNote);
            newKeyNote = newKey.dorian;

            //Dorian
            Intervals_I.Text = "W   H   W   W   W   H   W";
            ScaleName_I.Text = "Dorian";
            mode_I.Text = "m7";
            Dorian dorian = new Dorian(newKeyNote);
            scaleNotes_I.Text = dorian.dorianScale;

            //Phrygian
            Intervals_II.Text = "H   W   W   W   H   W   W";
            ScaleName_II.Text = "Phrygian";
            mode_II.Text = "m7";
            Phrygian phrygian = new Phrygian(newKeyNote);
            scaleNotes_II.Text = phrygian.phrygianScale;

            Intervals_III.Text = "-";
            ScaleName_III.Text = "-";
            mode_III.Text = "-";
            scaleNotes_III.Text = "-";
        }

        private void major_V_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;

            //Mixolydian
            Intervals_I.Text = "W   W   H   W   W   H   W";
            ScaleName_I.Text = "Mixolydian";
            mode_I.Text = "Dom7";
            ChurchModes churchModes = new ChurchModes(keyNote);
            newKeyNote = churchModes.mixolydian;
            Mixolydian mixolydian = new Mixolydian(newKeyNote);
            scaleNotes_I.Text = mixolydian.mixolydianScale;

            //Diminished
            Intervals_II.Text = "H   W   H   W   H   W   H   W";
            ScaleName_II.Text = "Diminished";
            mode_II.Text = "Dom7";
            Diminished diminished = new Diminished(newKeyNote);
            scaleNotes_II.Text = diminished.diminishedScale;

            //Lydian Dominant
            Intervals_III.Text = " W   W   W   H   W   H   W";
            ScaleName_III.Text = "Lydian Dom";
            mode_III.Text = "Dom7";
            LydianDom lydianDom = new LydianDom(newKeyNote);
            scaleNotes_III.Text = lydianDom.lydianDominantScale;

            /*
            //Whole Tone
            Intervals_III.Text = "W   W   W   W   W   W";
            ScaleName_III.Text = "Whole Tone";
            mode_III.Text = "dom 7";
            WholeTone wholeTone = new WholeTone(newKeyNote);
            scaleNotes_III.Text = wholeTone.wholeToneScale;
            */
        }

        private void minor_I_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;

            Intervals_I.Text = "W   W   H   W   W   W   H";
            ScaleName_I.Text = "Aeolian";
            mode_I.Text = "mi7";
            //ChurchModes churchModes = new ChurchModes(keyNote);
            //newKeyNote = churchModes.aeolian;
            Aeolian aeolian = new Aeolian(keyNote);
            scaleNotes_I.Text = aeolian.aeolianScale;

            Intervals_II.Text = "W   H   W   W   W   W   H";
            ScaleName_II.Text = "Melodic minor";
            mode_II.Text = "mi M7";
            MelodicMinor melodicMinor = new MelodicMinor(keyNote);
            scaleNotes_II.Text = melodicMinor.melodicMinorScale;

            Intervals_III.Text = "-";
            ScaleName_III.Text = "-";
            mode_III.Text = "-";
            scaleNotes_III.Text = "-";
        }

        private void minor_II_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;

            ChurchModes churchModes = new ChurchModes(keyNote);
            newKeyNote = churchModes.dorian;

            //locrian scale
            Intervals_I.Text = "W   W   H   W   W   W   H";
            ScaleName_I.Text = "Locrian";
            mode_I.Text = "mi7b5";
            Locrian locrian = new Locrian(newKeyNote);
            scaleNotes_I.Text = locrian.locrianScale;

            //half diminished scale
            Intervals_II.Text = "W   H   W   H   W   W   W";
            ScaleName_II.Text = "Half Diminished";
            mode_II.Text = "mi7b5";
            HalfDiminished halfDim = new HalfDiminished(newKeyNote);
            scaleNotes_II.Text = halfDim.halfDiminishedScale;

            //dorian b2
            Intervals_III.Text = "H   W   W   W   W   H   W";
            ScaleName_III.Text = "Dorian b2";
            mode_III.Text = "mi7";
            Dorianb2 dorb2 = new Dorianb2(newKeyNote);
            scaleNotes_III.Text = dorb2.dorianb2Scale;
        }

        private void minor_V_Click(object sender, EventArgs e)
        {
            key.Text = keyNoteNull.ToUpper() + postFix;

            ChurchModes churchModes = new ChurchModes(keyNote);
            newKeyNote = churchModes.mixolydian;

            //diminished whole tone
            Intervals_I.Text = "H   W   H   W   W   W   W";
            ScaleName_I.Text = "Altered";
            mode_I.Text = "Dom7";
            Altered alt = new Altered(newKeyNote);
            scaleNotes_I.Text = alt.alteredScale;

            //aeolian dominant
            Intervals_II.Text = "W   W   H   W   H   W   W";
            ScaleName_II.Text = "Aeolian Dom";
            mode_II.Text = "Dom7";
            HalfDiminished halfDim = new HalfDiminished(newKeyNote);
            scaleNotes_II.Text = halfDim.halfDiminishedScale;

            Intervals_III.Text = "-";
            ScaleName_III.Text = "-";
            mode_III.Text = "-";
            scaleNotes_III.Text = "-";

        }
    }
}

