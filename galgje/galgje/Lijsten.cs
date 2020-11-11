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
    public partial class Lijsten : Form
    {
        public Lijsten()
        {
            InitializeComponent();
        }
        //lstAlfabetGr
        public static string[] lstAlfabetGr = new string[10];
        
             
        private void Lijsten_Load(object sender, EventArgs e)
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
        }
    }
}
