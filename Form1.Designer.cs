namespace ScalesOnCordTypes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.isSharp = new System.Windows.Forms.RadioButton();
            this.isFlat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.scaleNotes_I = new System.Windows.Forms.Label();
            this.isNone = new System.Windows.Forms.RadioButton();
            this.major_II = new System.Windows.Forms.Button();
            this.major_V = new System.Windows.Forms.Button();
            this.minor_II = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.scaleNotes_II = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.degree_I = new System.Windows.Forms.Label();
            this.degree_IV = new System.Windows.Forms.Label();
            this.degree_V = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.major_I = new System.Windows.Forms.Button();
            this.minor_I = new System.Windows.Forms.Button();
            this.minor_V = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Intervals_I = new System.Windows.Forms.Label();
            this.Intervals_II = new System.Windows.Forms.Label();
            this.ScaleName_I = new System.Windows.Forms.Label();
            this.ScaleName_II = new System.Windows.Forms.Label();
            this.ScaleName_III = new System.Windows.Forms.Label();
            this.Intervals_III = new System.Windows.Forms.Label();
            this.scaleNotes_III = new System.Windows.Forms.Label();
            this.mode_I = new System.Windows.Forms.Label();
            this.mode_II = new System.Windows.Forms.Label();
            this.mode_III = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the key:";
            // 
            // cboState
            // 
            this.cboState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(635, 41);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(83, 37);
            this.cboState.TabIndex = 5;
            this.cboState.SelectedIndexChanged += new System.EventHandler(this.cboState_SelectedIndexChanged);
            // 
            // isSharp
            // 
            this.isSharp.AutoSize = true;
            this.isSharp.Location = new System.Drawing.Point(738, 28);
            this.isSharp.Name = "isSharp";
            this.isSharp.Size = new System.Drawing.Size(87, 24);
            this.isSharp.TabIndex = 23;
            this.isSharp.TabStop = true;
            this.isSharp.Text = "# sharp";
            this.isSharp.UseVisualStyleBackColor = true;
            this.isSharp.CheckedChanged += new System.EventHandler(this.isSharp_CheckedChanged);
            // 
            // isFlat
            // 
            this.isFlat.AutoSize = true;
            this.isFlat.Location = new System.Drawing.Point(738, 58);
            this.isFlat.Name = "isFlat";
            this.isFlat.Size = new System.Drawing.Size(69, 24);
            this.isFlat.TabIndex = 24;
            this.isFlat.TabStop = true;
            this.isFlat.Text = "b flat";
            this.isFlat.UseVisualStyleBackColor = true;
            this.isFlat.CheckedChanged += new System.EventHandler(this.isFlat_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 25;
            // 
            // scaleNotes_I
            // 
            this.scaleNotes_I.AutoSize = true;
            this.scaleNotes_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleNotes_I.ForeColor = System.Drawing.Color.Maroon;
            this.scaleNotes_I.Location = new System.Drawing.Point(400, 468);
            this.scaleNotes_I.Name = "scaleNotes_I";
            this.scaleNotes_I.Size = new System.Drawing.Size(435, 40);
            this.scaleNotes_I.TabIndex = 36;
            this.scaleNotes_I.Text = "Scale Notes for the Cord";
            // 
            // isNone
            // 
            this.isNone.AutoSize = true;
            this.isNone.Location = new System.Drawing.Point(738, 88);
            this.isNone.Name = "isNone";
            this.isNone.Size = new System.Drawing.Size(70, 24);
            this.isNone.TabIndex = 38;
            this.isNone.TabStop = true;
            this.isNone.Text = "none";
            this.isNone.UseVisualStyleBackColor = true;
            this.isNone.CheckedChanged += new System.EventHandler(this.isNone_CheckedChanged);
            // 
            // major_II
            // 
            this.major_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.major_II.Location = new System.Drawing.Point(153, 240);
            this.major_II.Name = "major_II";
            this.major_II.Size = new System.Drawing.Size(149, 48);
            this.major_II.TabIndex = 39;
            this.major_II.Text = "minor7";
            this.major_II.UseVisualStyleBackColor = true;
            this.major_II.Click += new System.EventHandler(this.major_II_Click);
            // 
            // major_V
            // 
            this.major_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.major_V.Location = new System.Drawing.Point(154, 319);
            this.major_V.Name = "major_V";
            this.major_V.Size = new System.Drawing.Size(149, 48);
            this.major_V.TabIndex = 40;
            this.major_V.Text = "Dominant 7";
            this.major_V.UseVisualStyleBackColor = true;
            this.major_V.Click += new System.EventHandler(this.major_V_Click);
            // 
            // minor_II
            // 
            this.minor_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minor_II.Location = new System.Drawing.Point(434, 240);
            this.minor_II.Name = "minor_II";
            this.minor_II.Size = new System.Drawing.Size(149, 48);
            this.minor_II.TabIndex = 43;
            this.minor_II.Text = "minor7 b5";
            this.minor_II.UseVisualStyleBackColor = true;
            this.minor_II.Click += new System.EventHandler(this.minor_II_Click);
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.Color.Maroon;
            this.key.Location = new System.Drawing.Point(862, 62);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(53, 29);
            this.key.TabIndex = 44;
            this.key.Text = "key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(862, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Key";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(36, 29);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(267, 37);
            this.Heading.TabIndex = 46;
            this.Heading.Text = "Scales on Cords";
            // 
            // scaleNotes_II
            // 
            this.scaleNotes_II.AutoSize = true;
            this.scaleNotes_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleNotes_II.ForeColor = System.Drawing.Color.Maroon;
            this.scaleNotes_II.Location = new System.Drawing.Point(400, 619);
            this.scaleNotes_II.Name = "scaleNotes_II";
            this.scaleNotes_II.Size = new System.Drawing.Size(435, 40);
            this.scaleNotes_II.TabIndex = 51;
            this.scaleNotes_II.Text = "Scale Notes for the Cord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "option 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 53;
            this.label4.Text = "option 2";
            // 
            // degree_I
            // 
            this.degree_I.AutoSize = true;
            this.degree_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_I.ForeColor = System.Drawing.Color.Maroon;
            this.degree_I.Location = new System.Drawing.Point(81, 166);
            this.degree_I.Name = "degree_I";
            this.degree_I.Size = new System.Drawing.Size(26, 37);
            this.degree_I.TabIndex = 56;
            this.degree_I.Text = "I";
            // 
            // degree_IV
            // 
            this.degree_IV.AutoSize = true;
            this.degree_IV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_IV.ForeColor = System.Drawing.Color.Maroon;
            this.degree_IV.Location = new System.Drawing.Point(72, 243);
            this.degree_IV.Name = "degree_IV";
            this.degree_IV.Size = new System.Drawing.Size(35, 37);
            this.degree_IV.TabIndex = 57;
            this.degree_IV.Text = "II";
            // 
            // degree_V
            // 
            this.degree_V.AutoSize = true;
            this.degree_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degree_V.ForeColor = System.Drawing.Color.Maroon;
            this.degree_V.Location = new System.Drawing.Point(67, 322);
            this.degree_V.Name = "degree_V";
            this.degree_V.Size = new System.Drawing.Size(40, 37);
            this.degree_V.TabIndex = 58;
            this.degree_V.Text = "V";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 29);
            this.label7.TabIndex = 59;
            this.label7.Text = "Major";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(473, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 29);
            this.label8.TabIndex = 60;
            this.label8.Text = "minor";
            // 
            // major_I
            // 
            this.major_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.major_I.Location = new System.Drawing.Point(153, 163);
            this.major_I.Name = "major_I";
            this.major_I.Size = new System.Drawing.Size(149, 48);
            this.major_I.TabIndex = 62;
            this.major_I.Text = "Major7";
            this.major_I.UseVisualStyleBackColor = true;
            this.major_I.Click += new System.EventHandler(this.major_I_Click);
            // 
            // minor_I
            // 
            this.minor_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minor_I.Location = new System.Drawing.Point(434, 163);
            this.minor_I.Name = "minor_I";
            this.minor_I.Size = new System.Drawing.Size(149, 48);
            this.minor_I.TabIndex = 47;
            this.minor_I.Text = "minor";
            this.minor_I.UseVisualStyleBackColor = true;
            this.minor_I.Click += new System.EventHandler(this.minor_I_Click);
            // 
            // minor_V
            // 
            this.minor_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minor_V.Location = new System.Drawing.Point(435, 319);
            this.minor_V.Name = "minor_V";
            this.minor_V.Size = new System.Drawing.Size(149, 48);
            this.minor_V.TabIndex = 63;
            this.minor_V.Text = "Dominant 7";
            this.minor_V.UseVisualStyleBackColor = true;
            this.minor_V.Click += new System.EventHandler(this.minor_V_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(77, 726);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 65;
            this.label6.Text = "option 3";
            // 
            // Intervals_I
            // 
            this.Intervals_I.AutoSize = true;
            this.Intervals_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intervals_I.ForeColor = System.Drawing.Color.Maroon;
            this.Intervals_I.Location = new System.Drawing.Point(402, 416);
            this.Intervals_I.Name = "Intervals_I";
            this.Intervals_I.Size = new System.Drawing.Size(387, 40);
            this.Intervals_I.TabIndex = 66;
            this.Intervals_I.Text = "Intervals for the Scale";
            // 
            // Intervals_II
            // 
            this.Intervals_II.AutoSize = true;
            this.Intervals_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intervals_II.ForeColor = System.Drawing.Color.Maroon;
            this.Intervals_II.Location = new System.Drawing.Point(400, 555);
            this.Intervals_II.Name = "Intervals_II";
            this.Intervals_II.Size = new System.Drawing.Size(387, 40);
            this.Intervals_II.TabIndex = 67;
            this.Intervals_II.Text = "Intervals for the Scale";
            // 
            // ScaleName_I
            // 
            this.ScaleName_I.AutoSize = true;
            this.ScaleName_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleName_I.Location = new System.Drawing.Point(203, 478);
            this.ScaleName_I.Name = "ScaleName_I";
            this.ScaleName_I.Size = new System.Drawing.Size(145, 29);
            this.ScaleName_I.TabIndex = 68;
            this.ScaleName_I.Text = "Scale Name";
            // 
            // ScaleName_II
            // 
            this.ScaleName_II.AutoSize = true;
            this.ScaleName_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleName_II.Location = new System.Drawing.Point(203, 629);
            this.ScaleName_II.Name = "ScaleName_II";
            this.ScaleName_II.Size = new System.Drawing.Size(145, 29);
            this.ScaleName_II.TabIndex = 69;
            this.ScaleName_II.Text = "Scale Name";
            // 
            // ScaleName_III
            // 
            this.ScaleName_III.AutoSize = true;
            this.ScaleName_III.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleName_III.Location = new System.Drawing.Point(203, 782);
            this.ScaleName_III.Name = "ScaleName_III";
            this.ScaleName_III.Size = new System.Drawing.Size(145, 29);
            this.ScaleName_III.TabIndex = 70;
            this.ScaleName_III.Text = "Scale Name";
            // 
            // Intervals_III
            // 
            this.Intervals_III.AutoSize = true;
            this.Intervals_III.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intervals_III.ForeColor = System.Drawing.Color.Maroon;
            this.Intervals_III.Location = new System.Drawing.Point(402, 716);
            this.Intervals_III.Name = "Intervals_III";
            this.Intervals_III.Size = new System.Drawing.Size(387, 40);
            this.Intervals_III.TabIndex = 71;
            this.Intervals_III.Text = "Intervals for the Scale";
            // 
            // scaleNotes_III
            // 
            this.scaleNotes_III.AutoSize = true;
            this.scaleNotes_III.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleNotes_III.ForeColor = System.Drawing.Color.Maroon;
            this.scaleNotes_III.Location = new System.Drawing.Point(401, 772);
            this.scaleNotes_III.Name = "scaleNotes_III";
            this.scaleNotes_III.Size = new System.Drawing.Size(435, 40);
            this.scaleNotes_III.TabIndex = 72;
            this.scaleNotes_III.Text = "Scale Notes for the Cord";
            // 
            // mode_I
            // 
            this.mode_I.AutoSize = true;
            this.mode_I.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_I.Location = new System.Drawing.Point(203, 425);
            this.mode_I.Name = "mode_I";
            this.mode_I.Size = new System.Drawing.Size(75, 29);
            this.mode_I.TabIndex = 73;
            this.mode_I.Text = "Mode";
            // 
            // mode_II
            // 
            this.mode_II.AutoSize = true;
            this.mode_II.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_II.Location = new System.Drawing.Point(203, 566);
            this.mode_II.Name = "mode_II";
            this.mode_II.Size = new System.Drawing.Size(75, 29);
            this.mode_II.TabIndex = 74;
            this.mode_II.Text = "Mode";
            // 
            // mode_III
            // 
            this.mode_III.AutoSize = true;
            this.mode_III.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mode_III.Location = new System.Drawing.Point(203, 726);
            this.mode_III.Name = "mode_III";
            this.mode_III.Size = new System.Drawing.Size(75, 29);
            this.mode_III.TabIndex = 75;
            this.mode_III.Text = "Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 902);
            this.Controls.Add(this.mode_III);
            this.Controls.Add(this.mode_II);
            this.Controls.Add(this.mode_I);
            this.Controls.Add(this.scaleNotes_III);
            this.Controls.Add(this.Intervals_III);
            this.Controls.Add(this.ScaleName_III);
            this.Controls.Add(this.ScaleName_II);
            this.Controls.Add(this.ScaleName_I);
            this.Controls.Add(this.Intervals_II);
            this.Controls.Add(this.Intervals_I);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minor_V);
            this.Controls.Add(this.major_I);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.degree_V);
            this.Controls.Add(this.degree_IV);
            this.Controls.Add(this.degree_I);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scaleNotes_II);
            this.Controls.Add(this.minor_I);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.key);
            this.Controls.Add(this.minor_II);
            this.Controls.Add(this.major_V);
            this.Controls.Add(this.major_II);
            this.Controls.Add(this.isNone);
            this.Controls.Add(this.scaleNotes_I);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.isFlat);
            this.Controls.Add(this.isSharp);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Scales for New Jazz";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.RadioButton isSharp;
        private System.Windows.Forms.RadioButton isFlat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label scaleNotes_I;
        private System.Windows.Forms.RadioButton isNone;
        private System.Windows.Forms.Button major_II;
        private System.Windows.Forms.Button major_V;
        private System.Windows.Forms.Button minor_II;
        private System.Windows.Forms.Label key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label scaleNotes_II;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label degree_I;
        private System.Windows.Forms.Label degree_IV;
        private System.Windows.Forms.Label degree_V;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button major_I;
        private System.Windows.Forms.Button minor_I;
        private System.Windows.Forms.Button minor_V;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Intervals_I;
        private System.Windows.Forms.Label Intervals_II;
        private System.Windows.Forms.Label ScaleName_I;
        private System.Windows.Forms.Label ScaleName_II;
        private System.Windows.Forms.Label ScaleName_III;
        private System.Windows.Forms.Label Intervals_III;
        private System.Windows.Forms.Label scaleNotes_III;
        private System.Windows.Forms.Label mode_I;
        private System.Windows.Forms.Label mode_II;
        private System.Windows.Forms.Label mode_III;
    }
}



