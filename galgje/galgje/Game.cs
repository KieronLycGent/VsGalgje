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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            //!!TODO: Dit omzetten om een array te kiezen TODO!!
            string[] woordenlst;
            woordenlst = KiesLijst.lstAlfabetGr;
            label1.Text = woordenlst[0];
            label2.Text = woordenlst[1];
            label3.Text = woordenlst[2];
            label4.Text = woordenlst[3];
            label5.Text = woordenlst[4];
            label6.Text = woordenlst[5];
            label7.Text = woordenlst[6];
            label8.Text = woordenlst[7];
            label9.Text = woordenlst[8];
            label10.Text = woordenlst[9];
        }
    }
}
