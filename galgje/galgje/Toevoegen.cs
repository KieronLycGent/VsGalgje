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
        int teller = 0;
        bool vol = false;
        int select;
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
                if(frmLijsten.lijst == 1)
                {
                    switch (teller)
                    {
                        case 0:
                            System.IO.File.WriteAllText("C1w1.txt", woord);
                            teller++;
                            break;
                        case 1:
                            System.IO.File.WriteAllText("C1w2.txt", woord);
                            teller++;
                            break;
                        case 2:
                            System.IO.File.WriteAllText("C1w3.txt", woord);
                            teller++;
                            break;
                        case 3:
                            System.IO.File.WriteAllText("C1w4.txt", woord);
                            teller++;
                            break;
                        case 4:
                            System.IO.File.WriteAllText("C1w5.txt", woord);
                            teller++;
                            break;
                        case 5:
                            System.IO.File.WriteAllText("C1w6.txt", woord);
                            teller++;
                            break;
                        case 6:
                            System.IO.File.WriteAllText("C1w7.txt", woord);
                            teller++;
                            break;
                        case 7:
                            System.IO.File.WriteAllText("C1w8.txt", woord);
                            teller++;
                            break;
                        case 8:
                            System.IO.File.WriteAllText("C1w9.txt", woord);
                            teller++;
                            break;
                        case 9:
                            System.IO.File.WriteAllText("C1w10.txt", woord);
                            teller++;
                            break;
                        default:
                            MessageBox.Show("Er kunnen geen  woorden aan deze lijst meer worden toegevoegd: er zijn er meer dan 10.", "Er ging iets fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            vol = true;
                            break;
                    }
                }
                else if (frmLijsten.lijst == 2)
                {
                    switch (teller)
                    {
                        case 0:
                            System.IO.File.WriteAllText("C2w1.txt", woord);
                            teller++;
                            break;
                        case 1:
                            System.IO.File.WriteAllText("C2w2.txt", woord);
                            teller++;
                            break;
                        case 2:
                            System.IO.File.WriteAllText("C2w3.txt", woord);
                            teller++;
                            break;
                        case 3:
                            System.IO.File.WriteAllText("C2w4.txt", woord);
                            teller++;
                            break;
                        case 4:
                            System.IO.File.WriteAllText("C2w5.txt", woord);
                            teller++;
                            break;
                        case 5:
                            System.IO.File.WriteAllText("C2w6.txt", woord);
                            teller++;
                            break;
                        case 6:
                            System.IO.File.WriteAllText("C2w7.txt", woord);
                            teller++;
                            break;
                        case 7:
                            System.IO.File.WriteAllText("C2w8.txt", woord);
                            teller++;
                            break;
                        case 8:
                            System.IO.File.WriteAllText("C2w9.txt", woord);
                            teller++;
                            break;
                        case 9:
                            System.IO.File.WriteAllText("C2w10.txt", woord);
                            teller++;
                            break;
                        default:
                            MessageBox.Show("Er kunnen geen  woorden aan deze lijst meer worden toegevoegd: er zijn er meer dan 10.", "Er ging iets fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            vol = true;
                            break;
                    }
                }
                if (!vol)
                {
                    lbLijst.Items.Add(woord);
                    txtwoord.Text = "";
                    txtwoord.Focus();
                }
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
            if(frmLijsten.lijst == 1)
            {
                select = lbLijst.SelectedIndex;
                switch (select)
                {
                    //WHY HAVE YOU FORSAKEN ME?!?!
                    case 0:
                        System.IO.File.WriteAllText("C1w1.txt", System.IO.File.ReadAllText(@"C1w2.txt"));
                        System.IO.File.WriteAllText("C1w2.txt", System.IO.File.ReadAllText(@"C1w3.txt"));
                        System.IO.File.WriteAllText("C1w3.txt", System.IO.File.ReadAllText(@"C1w4.txt"));
                        System.IO.File.WriteAllText("C1w4.txt", System.IO.File.ReadAllText(@"C1w5.txt"));
                        System.IO.File.WriteAllText("C1w5.txt", System.IO.File.ReadAllText(@"C1w6.txt"));
                        System.IO.File.WriteAllText("C1w6.txt", System.IO.File.ReadAllText(@"C1w7.txt"));
                        System.IO.File.WriteAllText("C1w7.txt", System.IO.File.ReadAllText(@"C1w8.txt"));
                        System.IO.File.WriteAllText("C1w8.txt", System.IO.File.ReadAllText(@"C1w9.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 1:
                        System.IO.File.WriteAllText("C1w2.txt", System.IO.File.ReadAllText(@"C1w3.txt"));
                        System.IO.File.WriteAllText("C1w3.txt", System.IO.File.ReadAllText(@"C1w4.txt"));
                        System.IO.File.WriteAllText("C1w4.txt", System.IO.File.ReadAllText(@"C1w5.txt"));
                        System.IO.File.WriteAllText("C1w5.txt", System.IO.File.ReadAllText(@"C1w6.txt"));
                        System.IO.File.WriteAllText("C1w6.txt", System.IO.File.ReadAllText(@"C1w7.txt"));
                        System.IO.File.WriteAllText("C1w7.txt", System.IO.File.ReadAllText(@"C1w8.txt"));
                        System.IO.File.WriteAllText("C1w8.txt", System.IO.File.ReadAllText(@"C1w9.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 2:
                        System.IO.File.WriteAllText("C1w3.txt", System.IO.File.ReadAllText(@"C1w4.txt"));
                        System.IO.File.WriteAllText("C1w4.txt", System.IO.File.ReadAllText(@"C1w5.txt"));
                        System.IO.File.WriteAllText("C1w5.txt", System.IO.File.ReadAllText(@"C1w6.txt"));
                        System.IO.File.WriteAllText("C1w6.txt", System.IO.File.ReadAllText(@"C1w7.txt"));
                        System.IO.File.WriteAllText("C1w7.txt", System.IO.File.ReadAllText(@"C1w8.txt"));
                        System.IO.File.WriteAllText("C1w8.txt", System.IO.File.ReadAllText(@"C1w9.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 3:
                        System.IO.File.WriteAllText("C1w4.txt", System.IO.File.ReadAllText(@"C1w5.txt"));
                        System.IO.File.WriteAllText("C1w5.txt", System.IO.File.ReadAllText(@"C1w6.txt"));
                        System.IO.File.WriteAllText("C1w6.txt", System.IO.File.ReadAllText(@"C1w7.txt"));
                        System.IO.File.WriteAllText("C1w7.txt", System.IO.File.ReadAllText(@"C1w8.txt"));
                        System.IO.File.WriteAllText("C1w8.txt", System.IO.File.ReadAllText(@"C1w9.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 4:
                        System.IO.File.WriteAllText("C1w5.txt", System.IO.File.ReadAllText(@"C1w6.txt"));
                        System.IO.File.WriteAllText("C1w6.txt", System.IO.File.ReadAllText(@"C1w7.txt"));
                        System.IO.File.WriteAllText("C1w7.txt", System.IO.File.ReadAllText(@"C1w8.txt"));
                        System.IO.File.WriteAllText("C1w8.txt", System.IO.File.ReadAllText(@"C1w9.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 5:
                        System.IO.File.WriteAllText("C1w6.txt", System.IO.File.ReadAllText(@"C1w7.txt"));
                        System.IO.File.WriteAllText("C1w7.txt", System.IO.File.ReadAllText(@"C1w8.txt"));
                        System.IO.File.WriteAllText("C1w8.txt", System.IO.File.ReadAllText(@"C1w9.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 6:
                        System.IO.File.WriteAllText("C1w7.txt", System.IO.File.ReadAllText(@"C1w8.txt"));
                        System.IO.File.WriteAllText("C1w8.txt", System.IO.File.ReadAllText(@"C1w9.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 7:
                        System.IO.File.WriteAllText("C1w8.txt", System.IO.File.ReadAllText(@"C1w9.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 8:
                        System.IO.File.WriteAllText("C1w9.txt", System.IO.File.ReadAllText(@"C1w10.txt"));
                        System.IO.File.WriteAllText("C1w9.txt", "");
                        teller--;
                        break;
                    case 9:
                        System.IO.File.WriteAllText("C1w10.txt", "");
                        teller--;
                        break;
                }
                lbLijst.Items.Remove(lbLijst.SelectedItem);
            }
            else if(frmLijsten.lijst == 2)
            {
                switch (select)
                {
                    //Round 2: Die!
                    case 0:
                        System.IO.File.WriteAllText("C2w1.txt", System.IO.File.ReadAllText(@"C2w2.txt"));
                        System.IO.File.WriteAllText("C2w2.txt", System.IO.File.ReadAllText(@"C2w3.txt"));
                        System.IO.File.WriteAllText("C2w3.txt", System.IO.File.ReadAllText(@"C2w4.txt"));
                        System.IO.File.WriteAllText("C2w4.txt", System.IO.File.ReadAllText(@"C2w5.txt"));
                        System.IO.File.WriteAllText("C2w5.txt", System.IO.File.ReadAllText(@"C2w6.txt"));
                        System.IO.File.WriteAllText("C2w6.txt", System.IO.File.ReadAllText(@"C2w7.txt"));
                        System.IO.File.WriteAllText("C2w7.txt", System.IO.File.ReadAllText(@"C2w8.txt"));
                        System.IO.File.WriteAllText("C2w8.txt", System.IO.File.ReadAllText(@"C2w9.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 1:
                        System.IO.File.WriteAllText("C2w2.txt", System.IO.File.ReadAllText(@"C2w3.txt"));
                        System.IO.File.WriteAllText("C2w3.txt", System.IO.File.ReadAllText(@"C2w4.txt"));
                        System.IO.File.WriteAllText("C2w4.txt", System.IO.File.ReadAllText(@"C2w5.txt"));
                        System.IO.File.WriteAllText("C2w5.txt", System.IO.File.ReadAllText(@"C2w6.txt"));
                        System.IO.File.WriteAllText("C2w6.txt", System.IO.File.ReadAllText(@"C2w7.txt"));
                        System.IO.File.WriteAllText("C2w7.txt", System.IO.File.ReadAllText(@"C2w8.txt"));
                        System.IO.File.WriteAllText("C2w8.txt", System.IO.File.ReadAllText(@"C2w9.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 2:
                        System.IO.File.WriteAllText("C2w3.txt", System.IO.File.ReadAllText(@"C2w4.txt"));
                        System.IO.File.WriteAllText("C2w4.txt", System.IO.File.ReadAllText(@"C2w5.txt"));
                        System.IO.File.WriteAllText("C2w5.txt", System.IO.File.ReadAllText(@"C2w6.txt"));
                        System.IO.File.WriteAllText("C2w6.txt", System.IO.File.ReadAllText(@"C2w7.txt"));
                        System.IO.File.WriteAllText("C2w7.txt", System.IO.File.ReadAllText(@"C2w8.txt"));
                        System.IO.File.WriteAllText("C2w8.txt", System.IO.File.ReadAllText(@"C2w9.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 3:
                        System.IO.File.WriteAllText("C2w4.txt", System.IO.File.ReadAllText(@"C2w5.txt"));
                        System.IO.File.WriteAllText("C2w5.txt", System.IO.File.ReadAllText(@"C2w6.txt"));
                        System.IO.File.WriteAllText("C2w6.txt", System.IO.File.ReadAllText(@"C2w7.txt"));
                        System.IO.File.WriteAllText("C2w7.txt", System.IO.File.ReadAllText(@"C2w8.txt"));
                        System.IO.File.WriteAllText("C2w8.txt", System.IO.File.ReadAllText(@"C2w9.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 4:
                        System.IO.File.WriteAllText("C2w5.txt", System.IO.File.ReadAllText(@"C2w6.txt"));
                        System.IO.File.WriteAllText("C2w6.txt", System.IO.File.ReadAllText(@"C2w7.txt"));
                        System.IO.File.WriteAllText("C2w7.txt", System.IO.File.ReadAllText(@"C2w8.txt"));
                        System.IO.File.WriteAllText("C2w8.txt", System.IO.File.ReadAllText(@"C2w9.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 5:
                        System.IO.File.WriteAllText("C2w6.txt", System.IO.File.ReadAllText(@"C2w7.txt"));
                        System.IO.File.WriteAllText("C2w7.txt", System.IO.File.ReadAllText(@"C2w8.txt"));
                        System.IO.File.WriteAllText("C2w8.txt", System.IO.File.ReadAllText(@"C2w9.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 6:
                        System.IO.File.WriteAllText("C2w7.txt", System.IO.File.ReadAllText(@"C2w8.txt"));
                        System.IO.File.WriteAllText("C2w8.txt", System.IO.File.ReadAllText(@"C2w9.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 7:
                        System.IO.File.WriteAllText("C2w8.txt", System.IO.File.ReadAllText(@"C2w9.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 8:
                        System.IO.File.WriteAllText("C2w9.txt", System.IO.File.ReadAllText(@"C2w10.txt"));
                        System.IO.File.WriteAllText("C2w9.txt", "");
                        teller--;
                        break;
                    case 9:
                        System.IO.File.WriteAllText("C2w10.txt", "");
                        teller--;
                        break;
                }
                lbLijst.Items.Remove(lbLijst.SelectedItem);
                lbLijst.SelectedItem = 0;
            }
        }

        private void Toevoegen_Load(object sender, EventArgs e)
        {
            if (frmLijsten.lijst == 1)
            {
                lblTitel.Text = "Custom 1";
                //Kijken of ze bestaan en ze maken indien nodig
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
                //Kijken of er een woord in staat.
                if (System.IO.File.ReadAllText(@"C1w1.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w2.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w3.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w4.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w5.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w6.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w7.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w8.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w9.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C1w10.txt") != "")
                {
                    teller++;
                }
                //lb vullen | WHAT IS THIS TERRIBLENESS?!?
                if(System.IO.File.ReadAllText(@"C1w1.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w1.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w2.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w2.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w3.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w3.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w4.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w4.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w5.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w5.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w6.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w6.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w7.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w7.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w8.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w8.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w9.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w9.txt"));
                }
                if(System.IO.File.ReadAllText(@"C1w10.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C1w10.txt"));
                }
            }
            else
            {
                lblTitel.Text = "Custom 2";
                //kijken of ze bestaan en maken indien nodig
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
                //Kijken of er een woord in staat.
                if (System.IO.File.ReadAllText(@"C2w1.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w2.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w3.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w4.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w5.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w6.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w7.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w8.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w9.txt") != "")
                {
                    teller++;
                }
                if (System.IO.File.ReadAllText(@"C2w10.txt") != "")
                {
                    teller++;
                }
                //lb vullen | WHAT IS THIS TERRIBLENESS?!?
                if (System.IO.File.ReadAllText(@"C2w1.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w1.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w2.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w2.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w3.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w3.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w4.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w4.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w5.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w5.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w6.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w6.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w7.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w7.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w8.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w8.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w9.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w9.txt"));
                }
                if (System.IO.File.ReadAllText(@"C2w10.txt") != "")
                {
                    lbLijst.Items.Add(System.IO.File.ReadAllText(@"C2w10.txt"));
                }
            }


            
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}