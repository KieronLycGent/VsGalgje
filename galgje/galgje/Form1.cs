using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace galgje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button1.Visible = true;
        }
    }
}
