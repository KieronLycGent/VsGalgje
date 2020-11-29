using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            string woord = txtwoord.Text;
            if (!Regex.IsMatch(woord, @"^[a-z]+$"))
            {
                MessageBox.Show("Het woord kan alleen tekens uit het alfabet gebruiken.", "Er ging iets fout",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtwoord.Focus();
            }
            else 
            {
                lbLijst.Items.Add(woord);
                txtwoord.Text = "";
                txtwoord.Focus();
            }

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
            if (frmLijsten.lijst == 1)
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
            else
            {
                if (!System.IO.File.Exists("C2w1.txt"))
                {
                    System.IO.File.WriteAllText("C2w1.txt", "");
                }
                if (!System.IO.File.Exists("C2w2.txt"))
                {
                    System.IO.File.WriteAllText("C2w2.txt", "");
                }
                if (!System.IO.File.Exists("C2w3.txt"))
                {
                    System.IO.File.WriteAllText("C2w3.txt", "");
                }
                if (!System.IO.File.Exists("C2w4.txt"))
                {
                    System.IO.File.WriteAllText("C2w4.txt", "");
                }
                if (!System.IO.File.Exists("C2w5.txt"))
                {
                    System.IO.File.WriteAllText("C2w5.txt", "");
                }
                if (!System.IO.File.Exists("C2w6.txt"))
                {
                    System.IO.File.WriteAllText("C2w6.txt", "");
                }
                if (!System.IO.File.Exists("C2w7.txt"))
                {
                    System.IO.File.WriteAllText("C2w7.txt", "");
                }
                if (!System.IO.File.Exists("C2w8.txt"))
                {
                    System.IO.File.WriteAllText("C2w8.txt", "");
                }
                if (!System.IO.File.Exists("C2w9.txt"))
                {
                    System.IO.File.WriteAllText("C2w9.txt", "");
                }
                if (!System.IO.File.Exists("C2w10.txt"))
                {
                    System.IO.File.WriteAllText("C2w10.txt", "");
                }
            }


            
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}