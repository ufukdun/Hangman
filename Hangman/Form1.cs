using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        private Bitmap[] hangImages = {Hangman.Properties.Resources.stage1, Hangman.Properties.Resources.stage2, Hangman.Properties.Resources.stage3,Hangman.Properties.Resources.stage4,Hangman.Properties.Resources.stage5, Hangman.Properties.Resources.stage6,Hangman.Properties.Resources.stage7, Hangman.Properties.Resources.stage8, Hangman.Properties.Resources.stage9 };
        private int wrongGuesses = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] readText;
        public frmHangman()
        {
            InitializeComponent();
        }
        private void loadwords()
        {
            readText = File.ReadAllLines("wordss.txt");
            //words = new string[readText.Length];
            int index = 0;
        }
        private void setupWordChoice()
        {
            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            int guessIndex = (new Random()).Next(readText.Length-1);
            current = readText[guessIndex];

            copyCurrent = "";

            for (int index = 0; index<current.Length; index++)
            {
                copyCurrent += "_";
            }
            displayCopy();
        }
        private void displayCopy()
        {
            lblShowWord.Text += " ";
            for (int index = 0; index<copyCurrent.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index, 1);
                lblShowWord.Text += " ";
            }
        }
        private void updateCopy(char guess)
        {

        }

        private void guessClick(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if (current.Contains(choice.Text))
                {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);
                for(int index=0; index<find.Length; index++)
                {
                    if(find[index]==guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();
            }
            else
            {
                wrongGuesses++;
            }
            if(wrongGuesses < 9)
            {
                hangImage.Image = hangImages[wrongGuesses];
            }
            else
            {
                lblResult.Text = "Bye Bye";
            }
            if(copyCurrent.Equals(current))
            {
                lblResult.Text = "You Win";
            }
            hangImage.Image = hangImages[wrongGuesses];
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            setupWordChoice();
            lblResult.Text = " ";
            this.Controls.Add(lblResult);
        }
    }
}
