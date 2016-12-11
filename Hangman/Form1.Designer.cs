namespace Hangman
{
    partial class frmHangman
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
            this.hangImage = new System.Windows.Forms.PictureBox();
            this.cmdA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblShowWord = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).BeginInit();
            this.SuspendLayout();
            // 
            // hangImage
            // 
            this.hangImage.Image = global::Hangman.Properties.Resources.stage1;
            this.hangImage.Location = new System.Drawing.Point(179, 12);
            this.hangImage.Name = "hangImage";
            this.hangImage.Size = new System.Drawing.Size(256, 194);
            this.hangImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hangImage.TabIndex = 0;
            this.hangImage.TabStop = false;
            // 
            // cmdA
            // 
            this.cmdA.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmdA.Location = new System.Drawing.Point(179, 235);
            this.cmdA.Name = "cmdA";
            this.cmdA.Size = new System.Drawing.Size(28, 35);
            this.cmdA.TabIndex = 1;
            this.cmdA.Text = "a";
            this.cmdA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdA.UseVisualStyleBackColor = true;
            this.cmdA.Click += new System.EventHandler(this.guessClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(213, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "b";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.guessClick);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(441, 12);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(178, 41);
            this.lblResult.TabIndex = 3;
            // 
            // lblShowWord
            // 
            this.lblShowWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowWord.Location = new System.Drawing.Point(179, 209);
            this.lblShowWord.Name = "lblShowWord";
            this.lblShowWord.Size = new System.Drawing.Size(312, 23);
            this.lblShowWord.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(247, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "c";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.guessClick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(357, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "f";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.guessClick);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(323, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "e";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.guessClick);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(289, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 35);
            this.button5.TabIndex = 6;
            this.button5.Text = "d";
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.guessClick);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(391, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(28, 35);
            this.button6.TabIndex = 11;
            this.button6.Text = "g";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.guessClick);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(427, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(28, 35);
            this.button7.TabIndex = 10;
            this.button7.Text = "h";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.guessClick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(461, 235);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(28, 35);
            this.button8.TabIndex = 9;
            this.button8.Text = "i";
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.guessClick);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(179, 276);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(28, 35);
            this.button9.TabIndex = 14;
            this.button9.Text = "j";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.guessClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(213, 276);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(28, 35);
            this.button10.TabIndex = 13;
            this.button10.Text = "k";
            this.button10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.guessClick);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(247, 276);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(28, 35);
            this.button11.TabIndex = 12;
            this.button11.Text = "l";
            this.button11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.guessClick);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(357, 276);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(28, 35);
            this.button12.TabIndex = 17;
            this.button12.Text = "o";
            this.button12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.guessClick);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(323, 276);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(28, 35);
            this.button13.TabIndex = 16;
            this.button13.Text = "n";
            this.button13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.guessClick);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(289, 276);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(28, 35);
            this.button14.TabIndex = 15;
            this.button14.Text = "m";
            this.button14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.guessClick);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(461, 276);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(28, 35);
            this.button15.TabIndex = 20;
            this.button15.Text = "r";
            this.button15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.guessClick);
            // 
            // button16
            // 
            this.button16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(427, 276);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(28, 35);
            this.button16.TabIndex = 19;
            this.button16.Text = "q";
            this.button16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.guessClick);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.Location = new System.Drawing.Point(393, 276);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(28, 35);
            this.button17.TabIndex = 18;
            this.button17.Text = "p";
            this.button17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.guessClick);
            // 
            // button18
            // 
            this.button18.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(247, 317);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(28, 35);
            this.button18.TabIndex = 23;
            this.button18.Text = "u";
            this.button18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.guessClick);
            // 
            // button19
            // 
            this.button19.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.Location = new System.Drawing.Point(213, 317);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(28, 35);
            this.button19.TabIndex = 22;
            this.button19.Text = "t";
            this.button19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.guessClick);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(179, 317);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(28, 35);
            this.button20.TabIndex = 21;
            this.button20.Text = "s";
            this.button20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.guessClick);
            // 
            // button21
            // 
            this.button21.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(289, 317);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(28, 35);
            this.button21.TabIndex = 26;
            this.button21.Text = "v";
            this.button21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.guessClick);
            // 
            // button22
            // 
            this.button22.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button22.Location = new System.Drawing.Point(357, 317);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(28, 35);
            this.button22.TabIndex = 25;
            this.button22.Text = "x";
            this.button22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.guessClick);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.Location = new System.Drawing.Point(323, 317);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(28, 35);
            this.button23.TabIndex = 24;
            this.button23.Text = "w";
            this.button23.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.guessClick);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button25.Location = new System.Drawing.Point(427, 317);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(28, 35);
            this.button25.TabIndex = 28;
            this.button25.Text = "z";
            this.button25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.guessClick);
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.Location = new System.Drawing.Point(393, 317);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(28, 35);
            this.button26.TabIndex = 27;
            this.button26.Text = "y";
            this.button26.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.guessClick);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(565, 287);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 23);
            this.button24.TabIndex = 29;
            this.button24.Text = "Restart";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // frmHangman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 419);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblShowWord);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmdA);
            this.Controls.Add(this.hangImage);
            this.Name = "frmHangman";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.frmHangman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox hangImage;
        private System.Windows.Forms.Button cmdA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblShowWord;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button24;
    }
}

