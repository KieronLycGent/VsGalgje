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
    public partial class frmToevoegen : Form
    {
        public frmToevoegen()
        {
            InitializeComponent();
        }

        private void BtnToevoegen_Click(object sender, EventArgs e)
        {
            
        }

        private void Txtwoord_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblTitel_Click(object sender, EventArgs e)
        {

        }

        private void LbLijst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnVerwijderen_Click(object sender, EventArgs e)
        {

        }

        private void Toevoegen_Load(object sender, EventArgs e)
        {



            if (!System.IO.File.Exists("C1w1.txt"))
            {
                System.IO.File.WriteAllText("C1w1.txt", "");
            }
            if (!System.IO.File.Exists("C1w2.txt"))
            {
                System.IO.File.WriteAllText("C1w2.txt", "");
            }
            if (!System.IO.File.Exists("C1w3.txt"))
            {
                System.IO.File.WriteAllText("C1w3.txt", "");
            }
            if (!System.IO.File.Exists("C1w4.txt"))
            {
                System.IO.File.WriteAllText("C1w4.txt", "");
            }
            if (!System.IO.File.Exists("C1w5.txt"))
            {
                System.IO.File.WriteAllText("C1w5.txt", "");
            }
            if (!System.IO.File.Exists("C1w6.txt"))
            {
                System.IO.File.WriteAllText("C1w6.txt", "");
            }
            if (!System.IO.File.Exists("C1w7.txt"))
            {
                System.IO.File.WriteAllText("C1w7.txt", "");
            }
            if (!System.IO.File.Exists("C1w8.txt"))
            {
                System.IO.File.WriteAllText("C1w8.txt", "");
            }
            if (!System.IO.File.Exists("C1w9.txt"))
            {
                System.IO.File.WriteAllText("C1w9.txt", "");
            }
            if (!System.IO.File.Exists("C1w10.txt"))
            {
                System.IO.File.WriteAllText("C1w10.txt", "");
            }
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}