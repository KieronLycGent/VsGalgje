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
    public partial class KiesLijst : Form
    {
        public KiesLijst()
        {
            InitializeComponent();
        }
        //Een variabele die meegeeft welke array die overgedragen moet worden naar Game
        public static string lijstId = "";
        //De standaars arrays
        String[] meubilair;
        String[] eten;
        String[] kledij;
        String[] dieren;
        String[] lichaamsdelen;
        String[] grieksalfabet;
        Random rand = new Random();
        private void KiesLijst_Load(object sender, EventArgs e)
        {
            //custom lijst 1
            lstCustom1.Items.Clear();
            if (System.IO.File.ReadAllText(@"C1w1.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w1.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w2.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w2.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w3.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w3.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w4.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w4.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w5.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w5.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w6.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w6.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w7.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w7.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w8.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w8.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w9.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w9.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w10.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w10.txt"));
            }
            //custom lijst 2
            lstCustom2.Items.Clear();
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
            lblWhitespace.Text = "";
            //arrey meubilair aangeven
            meubilair = Home.meubilair;
            //arrey van het meubilair in listbox zetten
            for (int i = 0; i < meubilair.Length; i++)
            {
                lstMeubilair.Items.Add(meubilair[i]);
            }
            //arrey eten aangeven
            eten = Home.eten;
            //arrey van het eten in listbox zetten
            for (int i = 0; i < eten.Length; i++)
            {
                lstEten.Items.Add(eten[i]);
            }
            //arrey kledij aangeven
            kledij = Home.kledij;
            //arrey van het kledij in listbox zetten
            for (int i = 0; i < kledij.Length; i++)
            {
                lstKledij.Items.Add(kledij[i]);
            }
            //arrey dieren aangeven
            dieren = Home.dieren;
            //arrey van het kledij in listbox zetten
            for (int i = 0; i < dieren.Length; i++)
            {
                lstDieren.Items.Add(dieren[i]);
            }
            //arrey lichaamsdelen aangeven
            lichaamsdelen = Home.lichaamsdelen;
            //arrey van de lichaamsdelen in listbox zetten
            for (int i = 0; i < lichaamsdelen.Length; i++)
            {
                lstLichaamsdelen.Items.Add(lichaamsdelen[i]);
            }
            //arrey grieksalfabet aangeven
            grieksalfabet = Home.lstAlfabetGr;
            //arrey van de lstGrieksAlfabet in listbox zetten
            for (int i = 0; i < grieksalfabet.Length; i++)
            {
                lstGrieksAlfabet.Items.Add(grieksalfabet[i]);
            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            int rng = rand.Next(8);
            switch(rng)
            {
                case 1:
                    lijstId = "meubels";
                    Game frmGame1 = new Game();
                    frmGame1.Show();
                    break;
                case 2:
                    lijstId = "eten";
                    Game frmGame2 = new Game();
                    frmGame2.Show();
                    break;
                case 3:
                    lijstId = "kledij";
                    Game frmGame3 = new Game();
                    frmGame3.Show();
                    break;
                case 4:
                    lijstId = "dieren";
                    Game frmGame4 = new Game();
                    frmGame4.Show();
                    break;
                case 5:
                    lijstId = "lichaamsD";
                    Game frmGame5 = new Game();
                    frmGame5.Show();
                    break;
                case 6:
                    lijstId = "grAlfabet";
                    Game frmGame6 = new Game();
                    frmGame6.Show();
                    break;
                case 7:
                    lijstId = "c1";
                    Game frmGame7 = new Game();
                    frmGame7.Show();
                    break;
                case 8:
                    lijstId = "C2";
                    Game frmGame8 = new Game();
                    frmGame8.Show();
                    break;
                default:
                    lijstId = "meubels";
                    Game frmGame9 = new Game();
                    frmGame9.Show();
                    break;
            }
        }

        private void btnMeubilair_Click(object sender, EventArgs e)
        {
            lijstId = "meubels";
            Game frmGame0 = new Game();
            frmGame0.Show();
        }


        private void btnEten_Click(object sender, EventArgs e)
        {
            lijstId = "eten";
            Game frmGame0 = new Game();
            frmGame0.Show();
        }

        private void btnKledij_Click(object sender, EventArgs e)
        {
            lijstId = "kledij";
            Game frmGame0 = new Game();
            frmGame0.Show();
        }

        private void btnDieren_Click(object sender, EventArgs e)
        {
            lijstId = "dieren";
            Game frmGame0 = new Game();
            frmGame0.Show();
        }

        private void btnLichaamsdelen_Click(object sender, EventArgs e)
        {
            lijstId = "lichaamsD";
            Game frmGame0 = new Game();
            frmGame0.Show();
        }

        private void btnGrieksAlfabet_Click(object sender, EventArgs e)
        {
            lijstId = "grAlfabet";

            Game frmGame0 = new Game();
            frmGame0.Show();
        }

        private void KiesLijst_Activated(object sender, EventArgs e)
        {
            //custom lijst 1
            lstCustom1.Items.Clear();
            if (System.IO.File.ReadAllText(@"C1w1.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w1.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w2.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w2.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w3.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w3.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w4.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w4.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w5.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w5.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w6.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w6.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w7.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w7.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w8.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w8.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w9.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w9.txt"));
            }
            if (System.IO.File.ReadAllText(@"C1w10.txt") != "")
            {
                lstCustom1.Items.Add(System.IO.File.ReadAllText(@"C1w10.txt"));
            }
            //custom lijst 2
            lstCustom2.Items.Clear();
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
            if (Game.opnieuw)
            {
                Game frmGame0 = new Game();
                frmGame0.Show();
                Game.opnieuw = false;
            }
            if (Game.end)
            {
                Game.end = false;
                this.Close();                
            }
        }

        private void BtnCustom1_Click(object sender, EventArgs e)
        {
            lijstId = "C1";
            Game frmGame0 = new Game();
            frmGame0.Show();
        }

        private void BtnCustom2_Click(object sender, EventArgs e)
        {
            lijstId = "C2";
            Game frmGame0 = new Game();
            frmGame0.Show();
        }
    }
}
