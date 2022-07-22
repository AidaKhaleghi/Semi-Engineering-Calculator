using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedCalculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "2";
            }
            else
            {
                display.Text = display.Text + "2";
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "3";
            }
            else
            {
                display.Text = display.Text + "3";
            }  
        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "1";
            }
            else
            {
                display.Text = display.Text + "1";
            }  
        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "4";
            }
            else
            {
                display.Text = display.Text + "4";
            }  
        }

        private void B5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "5";
            }
            else
            {
                display.Text = display.Text + "5";
            }  
        }

        private void B6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "6";
            }
            else
            {
                display.Text = display.Text + "6";
            }  
        }

        private void B7_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "7";
            }
            else
            {
                display.Text = display.Text + "7";
            }  
        }

        private void B8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "8";
            }
            else
            {
                display.Text = display.Text + "8";
            }  
        }

        private void B9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "9";
            }
            else
            {
                display.Text = display.Text + "9";
            }  
        }

        private void B0_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "0";
            }
            else
            {
                display.Text = display.Text + "0";
            }  
        }

        private void Bsum_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "+";
            }
            else
            {
                display.Text = display.Text + "+";
            }
        }

        private void Bminus_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "-";
            }
            else
            {
                display.Text = display.Text + "-";
            }
        }

        private void Bmul_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "*";
            }
            else
            {
                display.Text = display.Text + "*";
            }
        }

        private void Bdiv_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "/";
            }
            else
            {
                display.Text = display.Text + "/";
            }
        }

        private void Bpow_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "^";
            }
            else
            {
                display.Text = display.Text + "^";
            }
        }

        private void Bopen_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "(";
            }
            else
            {
                display.Text = display.Text + "(";
            }  
        }

        private void Bclose_Click(object sender, EventArgs e)
        {
            if (display.Text != "0" && display.Text != null)
            {
                display.Text = display.Text + ")";
            }
        }

        private void Bequal_Click(object sender, EventArgs e)
        {
            if (Binorder.Checked)
            {
                inorder pn = new inorder();
                display.Text = display.Text + "\n="  + pn.Function_inorder(display.Text).ToString();
                Bpostorder.Enabled = true;
                Bpreorder.Enabled = true;
                Binorder.Enabled = true; 
            }
            if (Bpreorder.Checked)
            {
                preorder pr = new preorder();
                display.Text = display.Text + "\n=" + pr.Function_preorder(display.Text).ToString();
                Bpostorder.Enabled = true;
                Binorder.Enabled = true;
                Bpreorder.Enabled = true;
            }
            if (Bpostorder.Checked)
            {
                postorder pos = new postorder();
                display.Text = display.Text + "\n="  + pos.Function_postorder(display.Text).ToString();
                Bpreorder.Enabled = true;
                Binorder.Enabled = true;
                Bpostorder.Enabled = true;
            }
            // Codes should be added here, checking for infix, postfix or prefix input,
            //calculating ...................................
            // Diplaying the result in new line
        }

        private void Bclear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void Bprefix_Click(object sender, EventArgs e)
        {
            
        }

        private void Bpostfix_Click(object sender, EventArgs e)
        {
            
        }

        private void display_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bpreorder_CheckedChanged(object sender, EventArgs e)
        {
            Bpostorder.Enabled = false;
            Binorder.Enabled = false;
            Bpreorder.Enabled = true;
               
                // setting  mode to preorder
                   
        }

        private void Bpostorder_CheckedChanged(object sender, EventArgs e)
        {
            Bpreorder.Enabled = false;
            Binorder.Enabled = false;
            Bpostorder.Enabled = true;
                
                // setting  mode to postorder
            
        }

        private void Binorder_CheckedChanged(object sender, EventArgs e)
        {
            Bpreorder.Enabled = false;
            Bpostorder.Enabled = false;
            Binorder.Enabled = true;
        }
    }
}
