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

        Random random = new Random();
        int rng;
        string woord;
        public static bool[] charCorrect;

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            string[] woordenlst;
            switch (KiesLijst.lijstId)
            {
                case "meubels":
                    woordenlst = KiesLijst.meubilair;
                    break;
                case "eten":
                    woordenlst = KiesLijst.eten;
                    break;
                case "kledij":
                    woordenlst = KiesLijst.kledij;
                    break;
                case "dieren":
                    woordenlst = KiesLijst.dieren;
                    break;
                case "lichaamsD":
                    woordenlst = KiesLijst.lichaamsdelen;
                    break;
                case "grAlfabet":
                    woordenlst = KiesLijst.lstAlfabetGr;
                    break;
                default:
                    //Stel dat er een probleem is met de code dan default het programma naar meubilair.
                    woordenlst = KiesLijst.meubilair;
                    break;  
            }
            rng = random.Next(10);
            woord = woordenlst[rng];
            label1.Text = woord;
            charCorrect = new bool[woord.Length];
            lblWoord.Text = "";
            char[] galgjeChars = new char[woord.Length];
            for(int i = 0; i < woord.Length; i++)
            {
                charCorrect[i] = false;
                galgjeChars[i] = Convert.ToChar(woord.Substring(i, 1));
                lblWoord.Text = lblWoord.Text + "_ ";
            }
        }

        private bool vibeCheck()
        {
            for(int i = 0; i < woord.Length; i++)
            {
                if (!charCorrect[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
