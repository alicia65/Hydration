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
    /*
     This program is using numericUpDown control to select number of glasses of water. 
    In addition, label control displays color with text message to show level of safety 
    color to drink. For example, red color is drinking too much. Whereas, gray color is not drinking enough. 
    */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string glassOfWater = lblResult.Text;// Initilize label result to pass a string to glass of water variable

            if (glassOfWater.Length > 12)
            {
                lblResult.Text = "Too many";
                lblResult.BackColor = Color.Red;
                this.BackColor = Color.Green;
            }
            else if (glassOfWater.Length > 9 && glassOfWater.Length < 12)//Using && operator to compare to conditions
            {
                lblResult.Text = "Awesome";//Label result displays text 
                lblResult.BackColor = Color.DarkBlue;//Label result shows color
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
