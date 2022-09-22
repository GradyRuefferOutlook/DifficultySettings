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
        public Form1()
        {
            InitializeComponent();
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
    }
}
