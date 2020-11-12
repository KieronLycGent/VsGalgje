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
        //lstAlfabetGr
        public static string[] lstAlfabetGr = new string[10];
        private void KiesLijst_Load(object sender, EventArgs e)
        {
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
            //Maakt een Game form
            Game frmGame0 = new Game();
            frmGame0.Show();
        }

        private void KiesLijst_Activated(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
