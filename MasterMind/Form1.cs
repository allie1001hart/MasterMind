using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int numOfGuesses = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.BackColor == Color.White)
            {
                button1.BackColor = Color.Black;
            }
            else if (button1.BackColor == Color.Black)
            {
                button1.BackColor = Color.Red;
            }
            else if (button1.BackColor == Color.Red)
            {
                button1.BackColor = Color.Yellow;
            }
            else if (button1.BackColor == Color.Yellow)
            {
                button1.BackColor = Color.Green;
            }
            else if (button1.BackColor == Color.Green)
            {
                button1.BackColor = Color.Blue;
            }
            else if (button1.BackColor == Color.Blue)
            {
                button1.BackColor = Color.White;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.BackColor == Color.White)
            {
                button2.BackColor = Color.Black;
            }
            else if (button2.BackColor == Color.Black)
            {
                button2.BackColor = Color.Red;
            }
            else if (button2.BackColor == Color.Red)
            {
                button2.BackColor = Color.Yellow;
            }
            else if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.Green;
            }
            else if (button2.BackColor == Color.Green)
            {
                button2.BackColor = Color.Blue;
            }
            else if (button2.BackColor == Color.Blue)
            {
                button2.BackColor = Color.White;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.BackColor == Color.White)
            {
                button3.BackColor = Color.Black;
            }
            else if (button3.BackColor == Color.Black)
            {
                button3.BackColor = Color.Red;
            }
            else if (button3.BackColor == Color.Red)
            {
                button3.BackColor = Color.Yellow;
            }
            else if (button3.BackColor == Color.Yellow)
            {
                button3.BackColor = Color.Green;
            }
            else if (button3.BackColor == Color.Green)
            {
                button3.BackColor = Color.Blue;
            }
            else if (button3.BackColor == Color.Blue)
            {
                button3.BackColor = Color.White;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.BackColor == Color.White)
            {
                button4.BackColor = Color.Black;
            }
            else if (button4.BackColor == Color.Black)
            {
                button4.BackColor = Color.Red;
            }
            else if (button4.BackColor == Color.Red)
            {
                button4.BackColor = Color.Yellow;
            }
            else if (button4.BackColor == Color.Yellow)
            {
                button4.BackColor = Color.Green;
            }
            else if (button4.BackColor == Color.Green)
            {
                button4.BackColor = Color.Blue;
            }
            else if (button4.BackColor == Color.Blue)
            {
                button4.BackColor = Color.White;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            numOfGuesses++;
            string userGuess1 = Convert.ToString(button1.BackColor);
            string userGuess2 = Convert.ToString(button2.BackColor);
            string userGuess3 = Convert.ToString(button3.BackColor);
            string userGuess4 = Convert.ToString(button4.BackColor);
            if (numOfGuesses == 1)
            {
                lblColorAndPlaceHeader.Visible = true;
                lblColorHeader.Visible = true;
                lblGuess1.Visible = true;
                btnGuess11.Visible = true;
                btnGuess12.Visible = true;
                btnGuess13.Visible = true;
                btnGuess14.Visible = true;
                lblGuess1Color.Visible = true;
                lblGuess1ColorAndPlace.Visible = true;
                Height = 230;
                btnGuess11.BackColor = button1.BackColor;
                btnGuess12.BackColor = button2.BackColor;
                btnGuess13.BackColor = button3.BackColor;
                btnGuess14.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess1Color = ;
                //lblGuess1ColorAndPlace = ;
            }
            else if (numOfGuesses == 2)
            {
                lblGuess2.Visible = true;
                btnGuess21.Visible = true;
                btnGuess22.Visible = true;
                btnGuess23.Visible = true;
                btnGuess24.Visible = true;
                lblGuess2Color.Visible = true;
                lblGuess2ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess21.BackColor = button1.BackColor;
                btnGuess22.BackColor = button2.BackColor;
                btnGuess23.BackColor = button3.BackColor;
                btnGuess24.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess2Color = ;
                //lblGuess2ColorAndPlace = ;
            }
            else if (numOfGuesses == 3)
            {
                lblGuess3.Visible = true;
                btnGuess31.Visible = true;
                btnGuess32.Visible = true;
                btnGuess33.Visible = true;
                btnGuess34.Visible = true;
                lblGuess3Color.Visible = true;
                lblGuess3ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess31.BackColor = button1.BackColor;
                btnGuess32.BackColor = button2.BackColor;
                btnGuess33.BackColor = button3.BackColor;
                btnGuess34.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess3Color = ;
                //lblGuess3ColorAndPlace = ;
            }
            else if (numOfGuesses == 4)
            {
                lblGuess4.Visible = true;
                btnGuess41.Visible = true;
                btnGuess42.Visible = true;
                btnGuess43.Visible = true;
                btnGuess44.Visible = true;
                lblGuess4Color.Visible = true;
                lblGuess4ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess41.BackColor = button1.BackColor;
                btnGuess42.BackColor = button2.BackColor;
                btnGuess43.BackColor = button3.BackColor;
                btnGuess44.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess4Color = ;
                //lblGuess4ColorAndPlace = ;
            }
            else if (numOfGuesses == 5)
            {
                lblGuess5.Visible = true;
                btnGuess51.Visible = true;
                btnGuess52.Visible = true;
                btnGuess53.Visible = true;
                btnGuess54.Visible = true;
                lblGuess5Color.Visible = true;
                lblGuess5ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess51.BackColor = button1.BackColor;
                btnGuess52.BackColor = button2.BackColor;
                btnGuess53.BackColor = button3.BackColor;
                btnGuess54.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess5Color = ;
                //lblGuess5ColorAndPlace = ;
            }
            else if (numOfGuesses == 6)
            {
                lblGuess6.Visible = true;
                btnGuess61.Visible = true;
                btnGuess62.Visible = true;
                btnGuess63.Visible = true;
                btnGuess64.Visible = true;
                lblGuess6Color.Visible = true;
                lblGuess6ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess61.BackColor = button1.BackColor;
                btnGuess62.BackColor = button2.BackColor;
                btnGuess63.BackColor = button3.BackColor;
                btnGuess64.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess6Color = ;
                //lblGuess6ColorAndPlace = ;
            }
            else if (numOfGuesses == 7)
            {
                lblGuess7.Visible = true;
                btnGuess71.Visible = true;
                btnGuess72.Visible = true;
                btnGuess73.Visible = true;
                btnGuess74.Visible = true;
                lblGuess7Color.Visible = true;
                lblGuess7ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess71.BackColor = button1.BackColor;
                btnGuess72.BackColor = button2.BackColor;
                btnGuess73.BackColor = button3.BackColor;
                btnGuess74.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess7Color = ;
                //lblGuess7ColorAndPlace = ;
            }
            else if (numOfGuesses == 8)
            {
                lblGuess8.Visible = true;
                btnGuess81.Visible = true;
                btnGuess82.Visible = true;
                btnGuess83.Visible = true;
                btnGuess84.Visible = true;
                lblGuess8Color.Visible = true;
                lblGuess8ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess81.BackColor = button1.BackColor;
                btnGuess82.BackColor = button2.BackColor;
                btnGuess83.BackColor = button3.BackColor;
                btnGuess84.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess8Color = ;
                //lblGuess8ColorAndPlace = ;
            }
            else if (numOfGuesses == 9)
            {
                lblGuess9.Visible = true;
                btnGuess91.Visible = true;
                btnGuess92.Visible = true;
                btnGuess93.Visible = true;
                btnGuess94.Visible = true;
                lblGuess9Color.Visible = true;
                lblGuess9ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess91.BackColor = button1.BackColor;
                btnGuess92.BackColor = button2.BackColor;
                btnGuess93.BackColor = button3.BackColor;
                btnGuess94.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess9Color = ;
                //lblGuess9ColorAndPlace = ;
            }
            else if (numOfGuesses == 10)
            {
                lblGuess10.Visible = true;
                btnGuess101.Visible = true;
                btnGuess102.Visible = true;
                btnGuess103.Visible = true;
                btnGuess104.Visible = true;
                lblGuess10Color.Visible = true;
                lblGuess10ColorAndPlace.Visible = true;
                Height += 40;
                btnGuess101.BackColor = button1.BackColor;
                btnGuess102.BackColor = button2.BackColor;
                btnGuess103.BackColor = button3.BackColor;
                btnGuess104.BackColor = button4.BackColor;
                //checkForWinner();
                //lblGuess10Color = ;
                //lblGuess10ColorAndPlace = ;
            }
            else
            {
                MessageBox.Show("You Lose");
                this.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblColorAndPlaceHeader.Visible = false;
            lblColorHeader.Visible = false;
            lblGuess1.Visible = false;
            lblGuess2.Visible = false;
            lblGuess3.Visible = false;
            lblGuess4.Visible = false;
            lblGuess5.Visible = false;
            lblGuess6.Visible = false;
            lblGuess7.Visible = false;
            lblGuess8.Visible = false;
            lblGuess9.Visible = false;
            lblGuess10.Visible = false;
            btnGuess11.Visible = false;
            btnGuess12.Visible = false;
            btnGuess13.Visible = false;
            btnGuess14.Visible = false;
            lblGuess1Color.Visible = false;
            lblGuess1ColorAndPlace.Visible = false;
            btnGuess21.Visible = false;
            btnGuess22.Visible = false;
            btnGuess23.Visible = false;
            btnGuess24.Visible = false;
            lblGuess2Color.Visible = false;
            lblGuess2ColorAndPlace.Visible = false;
            btnGuess31.Visible = false;
            btnGuess32.Visible = false;
            btnGuess33.Visible = false;
            btnGuess34.Visible = false;
            lblGuess3Color.Visible = false;
            lblGuess3ColorAndPlace.Visible = false;
            btnGuess41.Visible = false;
            btnGuess42.Visible = false;
            btnGuess43.Visible = false;
            btnGuess44.Visible = false;
            lblGuess4Color.Visible = false;
            lblGuess4ColorAndPlace.Visible = false;
            btnGuess51.Visible = false;
            btnGuess52.Visible = false;
            btnGuess53.Visible = false;
            btnGuess54.Visible = false;
            lblGuess5Color.Visible = false;
            lblGuess5ColorAndPlace.Visible = false;
            btnGuess61.Visible = false;
            btnGuess62.Visible = false;
            btnGuess63.Visible = false;
            btnGuess64.Visible = false;
            lblGuess6Color.Visible = false;
            lblGuess6ColorAndPlace.Visible = false;
            btnGuess71.Visible = false;
            btnGuess72.Visible = false;
            btnGuess73.Visible = false;
            btnGuess74.Visible = false;
            lblGuess7Color.Visible = false;
            lblGuess7ColorAndPlace.Visible = false;
            btnGuess81.Visible = false;
            btnGuess82.Visible = false;
            btnGuess83.Visible = false;
            btnGuess84.Visible = false;
            lblGuess8Color.Visible = false;
            lblGuess8ColorAndPlace.Visible = false;
            btnGuess91.Visible = false;
            btnGuess92.Visible = false;
            btnGuess93.Visible = false;
            btnGuess94.Visible = false;
            lblGuess9Color.Visible = false;
            lblGuess9ColorAndPlace.Visible = false;
            btnGuess101.Visible = false;
            btnGuess102.Visible = false;
            btnGuess103.Visible = false;
            btnGuess104.Visible = false;
            lblGuess10Color.Visible = false;
            lblGuess10ColorAndPlace.Visible = false;
            Height = 125;
        }
    }
}
