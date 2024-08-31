using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Activity_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            buttonClick.Click += ButtonClick_Click;
        }

        private void ButtonClick_Click(object sender, EventArgs e)
        {
            string no1= Convert.ToString(textBoxnumber1.Text);
            int no2= Convert.ToInt32(textBoxnumber2.Text);

            labelResult.Text = (no1+no2);

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
