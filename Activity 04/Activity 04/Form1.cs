using Activity_04.User_Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            buttonClick.Click += ButtonClick_Click;
        }

        private void ButtonClick_Click(object sender, EventArgs e)
        {
            Class obj = new Class();

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
