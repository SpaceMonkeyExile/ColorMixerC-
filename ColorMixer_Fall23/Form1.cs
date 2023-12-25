/* Auth: Weston Miller
 * Date: 10/17/23
 * Desc: #4 Color Mixer
        The colors red, blue, and yellow are known as the primary colors because they cannot 
        be made by mixing other colors. When you mix two primary colors, you get a secondary 
        color, as shown here:
            When you mix red and blue, you get purple.
            When you mix red and yellow, you get orange.
            When you mix blue and yellow, you get green.
        Create an application that lets the user select two primary colors from two 
        different sets of Radio buttons. The form should also have a Mix button. When the 
        user clicks the Mix button, the form’s background should change to the color that you 
        get when you mix the two selected primary colors.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer_Fall23
{
    public partial class ColorMixerForm : Form
    {
        public ColorMixerForm()
        {
            InitializeComponent();
        }

        private void QuitBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // This closes the app
        }

        private void MixBtn_Click(object sender, EventArgs e)
        {
            if (Red1RB.Checked)
            {
                if (Red2RB.Checked)
                    this.BackColor = Color.Red;
                else if (Blue2RB.Checked)
                    this.BackColor = Color.Purple;
                else if (Yellow2RB.Checked)
                    this.BackColor = Color.Orange;
                else
                    this.BackColor = Color.Red;
            }
            else if (Blue1RB.Checked)
            {
                if (Red2RB.Checked)
                    this.BackColor = Color.Purple;
                else if (Blue2RB.Checked)
                    this.BackColor = Color.Blue;
                else if (Yellow2RB.Checked)
                    this.BackColor = Color.Green;
                else
                    this.BackColor = Color.Blue;
            }
            else if (Yellow1RB.Checked)
            {
                if (Red2RB.Checked)
                    this.BackColor = Color.Orange;
                else if (Blue2RB.Checked)
                    this.BackColor = Color.Green;
                else if (Yellow2RB.Checked)
                    this.BackColor = Color.Yellow;
                else
                    this.BackColor = Color.Yellow;
            }
            else
            {
                if (Red2RB.Checked)
                    this.BackColor = Color.Red;
                else if (Blue2RB.Checked)
                    this.BackColor = Color.Blue;
                else if (Yellow2RB.Checked)
                    this.BackColor = Color.Yellow;
                else
                    MessageBox.Show("Please select a color.");
            }
        }

        private void Red1RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Red1RB.Checked)
            {
                if (Red2RB.Checked)
                    this.BackColor = Color.Red;
                else if (Blue2RB.Checked)
                    this.BackColor = Color.Purple;
                else if (Yellow2RB.Checked)
                    this.BackColor = Color.Orange;
                else
                    this.BackColor = Color.Red;
            }
        }

        private void Blue1RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Blue1RB.Checked)
            {
                if (Red2RB.Checked)
                    this.BackColor = Color.Purple;
                else if (Blue2RB.Checked)
                    this.BackColor = Color.Blue;
                else if (Yellow2RB.Checked)
                    this.BackColor = Color.Green;
                else
                    this.BackColor = Color.Blue;
            }
        }

        private void Yellow1RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Yellow1RB.Checked)
            {
                if (Red2RB.Checked)
                    this.BackColor = Color.Orange;
                else if (Blue2RB.Checked)
                    this.BackColor = Color.Green;
                else if (Yellow2RB.Checked)
                    this.BackColor = Color.Yellow;
                else
                    this.BackColor = Color.Yellow;
            }
        }

        private void Red2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Red2RB.Checked)
            {
                if (Red1RB.Checked)
                    this.BackColor = Color.Red;
                else if (Blue1RB.Checked)
                    this.BackColor = Color.Purple;
                else if (Yellow1RB.Checked)
                    this.BackColor = Color.Orange;
                else
                    this.BackColor = Color.Red;
            }
        }

        private void Blue2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Blue2RB.Checked)
            {
                if (Red1RB.Checked)
                    this.BackColor = Color.Purple;
                else if (Blue1RB.Checked)
                    this.BackColor = Color.Blue;
                else if (Yellow1RB.Checked)
                    this.BackColor = Color.Green;
                else
                    this.BackColor = Color.Blue;
            }
        }

        private void Yellow2RB_CheckedChanged(object sender, EventArgs e)
        {
            if (Yellow2RB.Checked)
            {
                if (Red1RB.Checked)
                    this.BackColor = Color.Orange;
                else if (Blue1RB.Checked)
                    this.BackColor = Color.Green;
                else if (Yellow1RB.Checked)
                    this.BackColor = Color.Yellow;
                else
                    this.BackColor = Color.Yellow;
            }
        }

        private void DeselectBtn_Click(object sender, EventArgs e)
        {
            Red1RB.Checked = false;
            Red2RB.Checked = false;
            Blue1RB.Checked = false;
            Blue2RB.Checked = false;
            Yellow1RB.Checked = false;
            Yellow2RB.Checked = false;
            RedCB.Checked = false;
            BlueCB.Checked = false;
            YellowCB.Checked = false;   
            this.BackColor = Color.LightGray;
        }

        private void RedCB_CheckedChanged(object sender, EventArgs e)
        {
            if (RedCB.Checked)
            {
                if (!BlueCB.Checked && !YellowCB.Checked)
                    this.BackColor = Color.Red;
                else if (BlueCB.Checked && !YellowCB.Checked)
                    this.BackColor = Color.Purple;
                else if (YellowCB.Checked && !BlueCB.Checked)
                    this.BackColor = Color.Orange;
                else
                    this.BackColor = Color.Brown;
            }
            else
            {
                if (!BlueCB.Checked && !YellowCB.Checked)
                    this.BackColor = Color.LightGray;
                else if (BlueCB.Checked && !YellowCB.Checked)
                    this.BackColor = Color.Blue;
                else if (YellowCB.Checked && !BlueCB.Checked)
                    this.BackColor = Color.Yellow;
                else
                    this.BackColor = Color.Green;
            }
        }

        private void BlueCB_CheckedChanged(object sender, EventArgs e)
        {
            if (BlueCB.Checked)
            {
                if (!RedCB.Checked && !YellowCB.Checked)
                    this.BackColor = Color.Blue;
                else if (RedCB.Checked && !YellowCB.Checked)
                    this.BackColor = Color.Purple;
                else if (YellowCB.Checked && !RedCB.Checked)
                    this.BackColor = Color.Green;
                else
                    this.BackColor = Color.Brown;
            }
            else
            {
                if (!RedCB.Checked && !YellowCB.Checked)
                    this.BackColor = Color.LightGray;
                else if (RedCB.Checked && !YellowCB.Checked)
                    this.BackColor = Color.Red;
                else if (YellowCB.Checked && !RedCB.Checked)
                    this.BackColor = Color.Yellow;
                else
                    this.BackColor = Color.Orange;
            }
        }

        private void YellowCB_CheckedChanged(object sender, EventArgs e)
        {
            if (YellowCB.Checked)
            {
                if (!BlueCB.Checked && !RedCB.Checked)
                    this.BackColor = Color.Yellow;
                else if (BlueCB.Checked && !RedCB.Checked)
                    this.BackColor = Color.Green;
                else if (RedCB.Checked && !BlueCB.Checked)
                    this.BackColor = Color.Orange;
                else
                    this.BackColor = Color.Brown;
            }
            else
            {
                if (!BlueCB.Checked && !RedCB.Checked)
                    this.BackColor = Color.LightGray;
                else if (BlueCB.Checked && !RedCB.Checked)
                    this.BackColor = Color.Blue;
                else if (RedCB.Checked && !BlueCB.Checked)
                    this.BackColor = Color.Red;
                else
                    this.BackColor = Color.Purple;
            }
        }
    }
}
