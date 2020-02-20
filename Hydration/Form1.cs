using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hydration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string glassOfWater = lblResult.Text;

            if (glassOfWater.Length > 12)
            {
                lblResult.Text = "Too many";
                lblResult.BackColor = Color.Red;
                this.BackColor = Color.Green;
            }
            else if (glassOfWater.Length > 9 && glassOfWater.Length < 12)
            {
                lblResult.Text = "Awesome";
                lblResult.BackColor = Color.DarkBlue;
                this.BackColor = Color.Green;
            }
            else if (glassOfWater.Length >= 5 && glassOfWater.Length <= 8) 
            {
                lblResult.Text = "Great Job!";
                lblResult.BackColor = Color.Blue;
                this.BackColor = Color.Green;
            }
            else if (glassOfWater.Length >= 3 && glassOfWater.Length < 5) 
            {
                lblResult.Text = "Good Work";
                lblResult.BackColor = Color.LightBlue;
                this.BackColor = Color.Green;
            }
            else  
            {
                lblResult.Text = "Drink more water";
                lblResult.BackColor = Color.Gray;
                this.BackColor = Color.Green;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
