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
        private void button1_Click(object sender, EventArgs e)
        {
            Game frmGegevens_instantie = new Game();
            frmGegevens_instantie.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.MsgBox("Dit programma is geschreven door Sepp Degroote, Kieron Parmentier en Rein Goossens, uit 6IB");
        }
    }
}
