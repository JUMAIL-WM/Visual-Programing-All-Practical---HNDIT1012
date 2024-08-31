using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonCalculate.Click += ButtonCalculate_Click;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            /*try
            {
                int index = int.Parse(textBox1.Text);
                string lastdigit = index.ToString().ToCharArray().LastOrDefault().ToString();

                if (lastdigit == "0")
                {
                    textBox2.Text = "Group A";
                    textBox2.ForeColor = Color.Red;
                }

                if (lastdigit == "1")
                {
                    textBox2.Text = "Group B";
                    textBox2.ForeColor = Color.Green;
                }

                if (lastdigit == "2")
                {
                    textBox2.Text = "Group C";
                    textBox2.ForeColor = Color.Blue;
                }

                if (lastdigit == "3")
                {
                    textBox2.Text = "Group D";
                    textBox2.ForeColor = Color.Black;
                }

                if (lastdigit == "4")
                {
                    textBox2.Text = "Group E";
                    textBox2.ForeColor = Color.Gray;
                }*/
            try
            {
                int index = int.Parse(textBox1.Text);

                if (index % 2 == 0)
                {
                    textBox2.Text = "Even number";
                }

                else
                {
                    textBox2.Text = "Odd number";
                }
            }
            catch (Exception)
            {

                throw;
            }

            /*}
            catch (Exception)
            {

                throw;
            } 
        }

        private void buttonCalculate_Click_1(object sender, EventArgs e)
        {
          
        }*/
        }
    }
}
