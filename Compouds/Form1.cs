using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compounds
{
    public partial class Form1 : Form
    {
        string suit = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void hurricaneButton_Click(object sender, EventArgs e)
        {
            //get the inputted category
            int category = Convert.ToInt32(categoryInput.Text);
            string cat = categoryInput.Text;

            //check the inputted category with a switch block
            switch (cat)
            {
                case"1":
                    categoryOutput.Text = "119-153 km/hr";
                    break;
                case "2":
                    categoryOutput.Text = "154-177 km/hr";
                    break;
                case "3":
                    categoryOutput.Text = "178-209 km/hr";
                    break;
                case "4":
                    categoryOutput.Text = "210-249 km/hr";
                    break;
                case "5":
                    categoryOutput.Text = "greater than 249 km/hr";
                    break;
                default:
                    categoryOutput.Text = "values between 1-5 only";
                    break;
            }
        }

        private void heartButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "heart";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Goldenrod;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Black;
        }

        private void diamondButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "diamond";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Goldenrod;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Black;

        }

        private void clubButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "club";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Goldenrod;
            spadeButton.BackColor = Color.Black;
        }

        private void spadeButton_Click(object sender, EventArgs e)
        {
            //set suit value
            suit = "spade";

            //set button colour to goldenrod, (other buttons black)
            heartButton.BackColor = Color.Black;
            diamondButton.BackColor = Color.Black;
            clubButton.BackColor = Color.Black;
            spadeButton.BackColor = Color.Goldenrod;
        }

        private void orButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to check what suit
            //has been selected and output the colour of the suit
            if (suit == "heart" || suit == "diamond")
            {
                suitOutput.Text = "The colour is red";
            }
            else if (suit == "club" || suit == "spade")
            {
                suitOutput.Text = "The colour is black";
            }
            else
            {
                suitOutput.Text = "Pick a suit first";
            }
        }

        private void thisButton_Click(object sender, EventArgs e)
        {
            //alternate BackColor between Black and Goldenrod 
            if (thisButton.BackColor == Color.Black)
            {
                thisButton.BackColor = Color.Goldenrod;
            }
            else
            {
                thisButton.BackColor = Color.Black;
            }
        }

        private void thatButton_Click(object sender, EventArgs e)
        {
            //alternate BackColor between Black and Goldenrod 
            if (thatButton.BackColor == Color.Black)
            {
                thatButton.BackColor = Color.Goldenrod;
            }
            else
            {
                thatButton.BackColor = Color.Black;
            }
        }

        private void andButton_Click(object sender, EventArgs e)
        {
            //use compound if statements to give outputs based on 
            //if both colours are the same or different
            if (thisButton.BackColor == Color.Black && thatButton.BackColor == Color.Black)
            {
                andLabel.Text = "Both buttons are Black";
            }
            else if (thisButton.BackColor == Color.Goldenrod && thatButton.BackColor == Color.Goldenrod)
            {
                andLabel.Text = "Both Buttons are Goldenrod";
            }
            else
            {
                andLabel.Text = "the colours are different";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
