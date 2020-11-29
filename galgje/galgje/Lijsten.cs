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
            //custom lijst 1
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

        private void frmLijsten_Activated(object sender, EventArgs e)
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
        }
    }
}
