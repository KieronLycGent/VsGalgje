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
    public partial class frmLijsten : Form
    {
        public frmLijsten()
        {
            InitializeComponent();
        }
        //lstAlfabetGr
        public static string[] lstAlfabetGr = new string[10];
        public static int lijst;

        String[] meubilair;
        String[] eten;
        String[] kledij;
        String[] dieren;
        String[] lichaamsdelen;
        String[] grieksalfabet;
        

        private void Lijsten_Load(object sender, EventArgs e)
        {
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
            for (int i = 0; i < lstAlfabetGr.Length; i++)
            {
                lstGrieksAlfabet.Items.Add(grieksalfabet[i]);
            }
        }

        private void BtnKledij_Click(object sender, EventArgs e)
        {

        }

        private void BtnCustom1_Click(object sender, EventArgs e)
        {
            lijst = 1;
            frmToevoegen frmToevoegen0 = new frmToevoegen();
            frmToevoegen0.Show();
        }

        private void BtnCustom2_Click(object sender, EventArgs e)
        {
            lijst = 2;
            frmToevoegen frmToevoegen0 = new frmToevoegen();
            frmToevoegen0.Show();
        }

        private void BtnTerug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
