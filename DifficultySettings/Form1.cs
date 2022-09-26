using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        int babyCounter = 0;
        bool easyOn = false;
        bool normalOn = false;
        bool hardOn = false;
        bool masterOn = false;
        string[] directions = new string[1023];
        int konamiOp = 0;
        string[] konami = { "up", "up", "down", "down", "left", "right", "left", "right", "B", "A", "begin"};
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            nameChecker.Start();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            if (babyCounter == 10)
            {
                difficultyLabel.Text = "Wittle Baby Needs His Easy Mode?";
                easyButton.BackColor = Color.LightBlue;
                normalButton.BackColor = Color.LightBlue;
                hardButton.BackColor = Color.LightBlue;
                masterButton.BackColor = Color.LightBlue;
                aButton.BackColor = Color.LightBlue;
                bButton.BackColor = Color.LightBlue;
                easyButton.Text = "Baby";
                normalButton.Text = "Baby";
                hardButton.Text = "Baby";
                masterButton.Text = "Baby";
                aButton.Text = "Baby";
                bButton.Text = "Baby";
            } else
            {
                setToBlack();
                easyButton.BackColor = Color.Green;
                difficultyLabel.Text = "Really?";
                babyCounter++; 

                easyOn = true;
                normalOn = false;
                hardOn = false;
                masterOn = false;

                directions[index] = "left";
                index++;
            }
        }
        void setToBlack()
        {
            easyButton.BackColor = Color.Black;
            normalButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
            masterButton.BackColor = Color.Black;
            aButton.BackColor = Color.Black;
            bButton.BackColor = Color.Black;
        }

        void indexCheck()
        {
            konamiOp = 0;
            int indexSub = 0;
            for (int i = 0; i <= index; i++)
            {
                if (konamiOp == 11)
                {
                    difficultyLabel.Text = "!Cheater!";
                    easyButton.BackgroundImage = Properties.Resources.konamiImage;
                    normalButton.BackgroundImage = Properties.Resources.konamiImage;
                    hardButton.BackgroundImage = Properties.Resources.konamiImage;
                    masterButton.BackgroundImage = Properties.Resources.konamiImage;
                    beginButton.BackgroundImage = Properties.Resources.konamiImage;
                    aButton.BackgroundImage = Properties.Resources.konamiImage;
                    bButton.BackgroundImage = Properties.Resources.konamiImage;
                    easyButton.Text = "";
                    normalButton.Text = "";
                    hardButton.Text = "";
                    masterButton.Text = "";
                    beginButton.Text = "";
                    aButton.Text = "";
                    bButton.Text = "";
                }
                else if (directions[indexSub + i] == konami[konamiOp])
                {
                    konamiOp++;
                }
            }
        }

        private void easyButton_MouseEnter(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.LimeGreen;
        }

        private void easyButton_MouseLeave(object sender, EventArgs e)
        {
            if (easyOn == false)
            {
                easyButton.BackColor = Color.Black;
            }
            else
            {
                easyButton.BackColor = Color.Green;
            }
        }

        private void aButton_MouseEnter(object sender, EventArgs e)
        {
            aButton.BackColor = Color.LightBlue;
        }

        private void aButton_MouseLeave(object sender, EventArgs e)
        {
            aButton.BackColor = Color.Black;
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            difficultyLabel.Text = "Worry Not About Those Buttons! They are Useless";
            directions[index] = "A";
            index++;
        }

        private void nameChecker_Tick(object sender, EventArgs e)
        {
            if ((nameInput.Text == "") == false) 
            {
                string nameHold = Convert.ToString(nameInput.Text);
                welcomeLabel.Text = $"Welcome {nameHold}, to the Land of Yore!";
                welcomeLabel.Visible = true;
            }
        }

        private void bButton_Click(object sender, EventArgs e)
        {
            difficultyLabel.Text = "Worry Not About Those Buttons! They are Useless";
            directions[index] = "B";
            index++;
        }

        private void bButton_MouseEnter(object sender, EventArgs e)
        {
            bButton.BackColor = Color.LightBlue;
        }

        private void bButton_MouseLeave(object sender, EventArgs e)
        {
            bButton.BackColor = Color.Black;
        }

        private void normalButton_Click(object sender, EventArgs e)
        {
            setToBlack();
            normalButton.BackColor = Color.Yellow;
            difficultyLabel.Text = "Respectable";

            easyOn = false;
            normalOn = true;
            hardOn = false;
            masterOn = false;

            directions[index] = "up";
            index++;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            setToBlack();
            hardButton.BackColor = Color.Orange;
            difficultyLabel.Text = "Thou Shalt Be Challenged";

            easyOn = false;
            normalOn = false;
            hardOn = true;
            masterOn = false;

            directions[index] = "right";
            index++;
        }

        private void masterButton_Click(object sender, EventArgs e)
        {
            setToBlack();
            masterButton.BackColor = Color.Red;
            difficultyLabel.Text = "Art Thou Insane?!";

            easyOn = false;
            normalOn = false;
            hardOn = false;
            masterOn = true;

            directions[index] = "down";
            index++;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            setToBlack();
            beginButton.BackColor = Color.Gold;
            difficultyLabel.Text = "Beginning your Quest";

            easyOn = false;
            normalOn = false;
            hardOn = false;
            masterOn = false;

            directions[index] = "begin";
            index++;
            indexCheck();

        }

        private void normalButton_MouseEnter(object sender, EventArgs e)
        {
            normalButton.BackColor = Color.YellowGreen;
        }

        private void normalButton_MouseLeave(object sender, EventArgs e)
        {
            if (normalOn == false)
            {
                normalButton.BackColor = Color.Black;
            }
            else
            {
                normalButton.BackColor = Color.Yellow;
            }
        }

        private void hardButton_MouseEnter(object sender, EventArgs e)
        {
            hardButton.BackColor = Color.OrangeRed;
        }

        private void hardButton_MouseLeave(object sender, EventArgs e)
        {
            if (hardOn == false)
            {
                hardButton.BackColor = Color.Black;
            }
            else
            {
                hardButton.BackColor = Color.Orange;
            }
        }

        private void masterButton_MouseEnter(object sender, EventArgs e)
        {
            masterButton.BackColor = Color.DarkRed;
        }

        private void masterButton_MouseLeave(object sender, EventArgs e)
        {
            if (masterOn == false)
            {
                masterButton.BackColor = Color.Black;
            }
            else
            {
                masterButton.BackColor = Color.Red;
            }
        }

        private void beginButton_MouseEnter(object sender, EventArgs e)
        {
            beginButton.BackColor = Color.Silver;
        }

        private void beginButton_MouseLeave(object sender, EventArgs e)
        {
                beginButton.BackColor = Color.Black;
        }
    }
}
