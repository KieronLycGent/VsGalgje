using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace galgje
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        Game frmbegin = new Game();
        bool g,a,l,gg,j,ee= false;
        public static string[] meubilair = new string[10];
        public static string[] eten = new string[10];
        public static string[] kledij = new string[10];
        public static string[] dieren = new string[10];
        public static string[] lichaamsdelen = new string[10];
        public static string[] lstAlfabetGr = new string[10];
        int kapot = 0;

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("Dit programma is geschreven door Sepp Degroote, Kieron Parmentier en Rein Goossens, uit 6IB");
        }

        private void BtnOpties_Click(object sender, EventArgs e)
        {
            frmLijsten frmLijsten0 = new frmLijsten();
            frmLijsten0.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if(!System.IO.File.Exists("C1w1.txt"))
            {
                System.IO.File.WriteAllText("C1w1.txt", "");
            }
            if(!System.IO.File.Exists("C1w2.txt"))
            {
                System.IO.File.WriteAllText("C1w2.txt", "");
            }
            if(!System.IO.File.Exists("C1w3.txt"))
            {
                System.IO.File.WriteAllText("C1w3.txt", "");
            }
            if(!System.IO.File.Exists("C1w4.txt"))
            {
                System.IO.File.WriteAllText("C1w4.txt", "");
            }
            if(!System.IO.File.Exists("C1w5.txt"))
            {
                System.IO.File.WriteAllText("C1w5.txt", "");
            }
            if(!System.IO.File.Exists("C1w6.txt"))
            {
                System.IO.File.WriteAllText("C1w6.txt", "");
            }
            if(!System.IO.File.Exists("C1w7.txt"))
            {
                System.IO.File.WriteAllText("C1w7.txt", "");
            }
            if(!System.IO.File.Exists("C1w8.txt"))
            {
                System.IO.File.WriteAllText("C1w8.txt", "");
            }
            if(!System.IO.File.Exists("C1w9.txt"))
            {
                System.IO.File.WriteAllText("C1w9.txt", "");
            }
            if(!System.IO.File.Exists("C1w10.txt"))
            {
                System.IO.File.WriteAllText("C1w10.txt", "");
            }

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
            pctA.Image = Properties.Resources.A;
            pctE.Image = Properties.Resources.E;
            pctG.Image = Properties.Resources.G;
            pctG2.Image = Properties.Resources.G;
            pctJ.Image = Properties.Resources.J;
            pctL.Image = Properties.Resources.L;
            pctStartSpel.Image = Properties.Resources.start_spel;

            timer1.Interval = 10000;
            timer1.Start();

            meubilair[0] = "tafel";
            meubilair[1] = "stoel";
            meubilair[2] = "kast";
            meubilair[3] = "bed";
            meubilair[4] = "zetel";
            meubilair[5] = "nachtkastje";
            meubilair[6] = "bureau";
            meubilair[7] = "kruk";
            meubilair[8] = "kapstok";
            meubilair[9] = "bureaustoel";
           
            eten[0] = "pizza";
            eten[1] = "lasagne";
            eten[2] = "donut";
            eten[3] = "hamburger";
            eten[4] = "sushi";
            eten[5] = "boterham";
            eten[6] = "spaghetti";
            eten[7] = "moelleux";
            eten[8] = "pannenkoeken";
            eten[9] = "wafel";
            
            kledij[0] = "broek";
            kledij[1] = "rok";
            kledij[2] = "jas";
            kledij[3] = "polo";
            kledij[4] = "hemd";
            kledij[5] = "das";
            kledij[6] = "trui";
            kledij[7] = "schoenen";
            kledij[8] = "pullover";
            kledij[9] = "hoodie";
            
            dieren[0] = "kat";
            dieren[1] = "hond";
            dieren[2] = "paard";
            dieren[3] = "koe";
            dieren[4] = "ezel";
            dieren[5] = "varken";
            dieren[6] = "kip";
            dieren[7] = "pauw";
            dieren[8] = "haai";
            dieren[9] = "walvis";
            
            lichaamsdelen[0] = "hoofd";
            lichaamsdelen[1] = "arm";
            lichaamsdelen[2] = "been";
            lichaamsdelen[3] = "voet";
            lichaamsdelen[4] = "hand";
            lichaamsdelen[5] = "teen";
            lichaamsdelen[6] = "vinger";
            lichaamsdelen[7] = "oksel";
            lichaamsdelen[8] = "elleboog";
            lichaamsdelen[9] = "knie";
            
            lstAlfabetGr[0] = "alfa";
            lstAlfabetGr[1] = "beta";
            lstAlfabetGr[2] = "omega";
            lstAlfabetGr[3] = "theta";
            lstAlfabetGr[4] = "delta";
            lstAlfabetGr[5] = "gamma";
            lstAlfabetGr[6] = "sigma";
            lstAlfabetGr[7] = "mu";
            lstAlfabetGr[8] = "psi";
            lstAlfabetGr[9] = "tau";



        }

        private void pctG_Click(object sender, EventArgs e)
        {
            if (!g)
            {
                pctG.Image = Properties.Resources.grafsteenNa1;
                g = true;
                kapot++;
                kapotCheck(kapot);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Maakt een Lijsten Form --> Zo kan frmGame0 arrays binnenhalen
            KiesLijst frmKieslst0 = new KiesLijst();
            //Opent Game Form
            frmKieslst0.Show();
            pctStartSpel.Image = Properties.Resources.grafsteenNa1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pctStartSpel.Image = Properties.Resources.start_spel;
        }

        private void pctA_Click(object sender, EventArgs e)
        {
            if (!a)
            {
                pctA.Image = Properties.Resources.grafsteenNa1;
                a = true;
                kapot++;
                kapotCheck(kapot);
            }
        }

        private void pctL_Click(object sender, EventArgs e)
        {
            if (!l)
            {
                pctL.Image = Properties.Resources.grafsteenNa1;
                l = true;
                kapot++;
                kapotCheck(kapot);
            }
        }

        private void pctG2_Click(object sender, EventArgs e)
        {
            if (!gg)
            {
                pctG2.Image = Properties.Resources.grafsteenNa1;
                gg = true;
                kapot++;
                kapotCheck(kapot);
            }
        }

        private void pctJ_Click(object sender, EventArgs e)
        {
            if (!j)
            {
                pctJ.Image = Properties.Resources.grafsteenNa1;
                j = true;
                kapot++;
                kapotCheck(kapot);
            }
        }

        private void pctE_Click(object sender, EventArgs e)
        {
            if (!ee)
            {
                pctE.Image = Properties.Resources.grafsteenNa1;
                ee = true;
                kapot++;
                kapotCheck(kapot);
            }
        }

        private void kapotCheck(int nr)
        {
            if(nr == 1)
            {
                MessageBox.Show("Moest dat nu echt?", "Vandaal!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else if(nr == 6)
            {
                MessageBox.Show("Nu blij?", "Vandaal!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
