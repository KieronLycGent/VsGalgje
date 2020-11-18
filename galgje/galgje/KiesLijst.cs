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
        public static string[] meubilair = new string[10];
        public static string[] eten = new string[10];
        public static string[] kledij = new string[10];
        public static string[] dieren = new string[10];
        public static string[] lichaamsdelen = new string[10];
        public static string[] lstAlfabetGr = new string[10];
        private void KiesLijst_Load(object sender, EventArgs e)
        {
            lblWhitespace.Text = "";
            //arrey van het meubilair
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
            //arrey van het meubilair in listbox zetten
            for (int i = 0; i < meubilair.Length; i++)
            {
                lstMeubilair.Items.Add(meubilair[i]);
            }
            //arrey van het eten
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
            //arrey van het eten in listbox zetten
            for (int i = 0; i < eten.Length; i++)
            {
                lstEten.Items.Add(eten[i]);
            }
            //arrey van het kledij
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
            //arrey van het kledij in listbox zetten
            for (int i = 0; i < kledij.Length; i++)
            {
                lstKledij.Items.Add(kledij[i]);
            }
            //arrey van het dieren
            dieren[0] = "kat";
            dieren[1] = "hond";
            dieren[2] = "paard";
            dieren[3] = "koe";
            dieren[4] = "ezel";
            dieren[5] = "varken";
            dieren[6] = "kip";
            dieren[7] = "pouw";
            dieren[8] = "haai";
            dieren[9] = "walvis";
            //arrey van het dieren in listbox zetten
            for (int i = 0; i < dieren.Length; i++)
            {
                lstDieren.Items.Add(dieren[i]);
            }
            //arrey van het lichaamsdelen
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
            //arrey van het lichaamsdelen in listbox zetten
            for (int i = 0; i < lichaamsdelen.Length; i++)
            {
                lstLichaamsdelen.Items.Add(lichaamsdelen[i]);
            }
            //arrey van het Griekse alfabet
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
            //arrey van het lstAlfabetGr in listbox zetten
            for (int i = 0; i < lstAlfabetGr.Length; i++)
            {
                lstGrieksAlfabet.Items.Add(lstAlfabetGr[i]);
            }

        }

        private void btnRandom_Click(object sender, EventArgs e)
        {

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
            if (Game.opnieuw)
            {
                Game frmGame0 = new Game();
                frmGame0.Show();
                Game.opnieuw = false;
            }
        }
    }
}
