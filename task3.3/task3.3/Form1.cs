using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool calc_was_clicked = false;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int output = 0;
            int num1, num2;
            
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("please enter a number");
                return;
            }
           
            
            

            
            num1 = Int32.Parse(txtNum1.Text);
            num2 = Int32.Parse(txtNum2.Text);
            if (rbtAdd.Checked == true)
            {
                output = num1 + num2;
                if (calc_was_clicked)
                {
                    MessageBox.Show("ufhh");
                    return;
                }
                else calc_was_clicked = true;
                MessageBox.Show(" The answer is: " + output);

            }
            else if (rbtDiv.Checked == true)
            {
                output = num1 / num2;
            }
            else if (rbtMult.Checked == true)
            {
                output = num1 * num2;
            }
            else if (rbtSub.Checked == true)
            {
                output = num1 - num2;
            }
            MessageBox.Show(" The answer is: " + output);
            
        }
    }
}
