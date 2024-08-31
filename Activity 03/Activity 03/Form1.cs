using Activity_03.NewFolder1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonSum.Click += ButtonSum_Click;
        }

        private void ButtonSum_Click(object sender, EventArgs e)
        {
            myClass obj = new myClass();

            /*label1.Text = obj.Sum(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();*/

            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);

            label1.Text = obj.sum(number1,number2).ToString();
            

        }
    }
}
