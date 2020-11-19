using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
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
        public static char[] galgjeChars;
        public static char chosenLetter;
        public static int levens;
        public static bool opnieuw = false;
        public static bool end = false;
        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Game_Load(object sender, EventArgs e)
        {
            levens = 9;
            btnOpnieuw.Visible = false;
            btnKies.Visible = false;
            btnHome.Visible = false;
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
            galgjeChars = new char[woord.Length];
            for(int i = 0; i < woord.Length; i++)
            {
                charCorrect[i] = false;
                galgjeChars[i] = Convert.ToChar(woord.Substring(i, 1));
                lblWoord.Text = lblWoord.Text + "_ ";
            }
        }

        private bool winCheck()
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

        //Deze funtie runt IEDERE KEER dat je een letterbtn klikt.
        private void btnFunctie(char letter)
        {
            int btnCorr = 0;
            //update welke letters correct zijn
            for(int i = 0; i < woord.Length; i++)
            {
                if (galgjeChars[i].Equals(letter))
                {
                    charCorrect[i] = true;
                    btnCorr++;
                }
            }
            //update de lbl om het deel van het woord te laten zien.
            lblWoord.Text = "";
            for (int i = 0; i < woord.Length; i++)
            {
                if (charCorrect[i])
                {
                    lblWoord.Text = lblWoord.Text + Convert.ToString(galgjeChars[i]);
                }
                else
                {
                    lblWoord.Text = lblWoord.Text + "_ ";
                }
            }
            chosenLetter = '/';
            //past foto aan om levens te laten zien + doet lose screen
            if(btnCorr == 0)
            {
                levens--;
                switch (levens)
                {
                    case 8:
                        pb9Levens.Visible = false;
                        pb8Levens.Visible = true;
                        break;
                    case 7:
                        pb8Levens.Visible = false;
                        pb7Levens.Visible = true;
                        break;
                    case 6:
                        pb7Levens.Visible = false;
                        pb6Levens.Visible = true;
                        break;
                    case 5:
                        pb6Levens.Visible = false;
                        pb5Levens.Visible = true;
                        break;
                    case 4:
                        pb5Levens.Visible = false;
                        pb4Levens.Visible = true;
                        break;
                    case 3:
                        pb4Levens.Visible = false;
                        pb3Levens.Visible = true;
                        break;
                    case 2:
                        pb3Levens.Visible = false;
                        pb2Levens.Visible = true;
                        break;
                    case 1:
                        pb2Levens.Visible = false;
                        pb1Leven.Visible = true;
                        break;
                    case 0:
                        pb1Leven.Visible = false;
                        pbDood.Visible = true;
                        gameOver();
                        lblWoord.Text = woord;
                        MessageBox.Show("U hebt helaas verloren...","Verloren...",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        break;
                    default:
                        pb9Levens.Visible = true;
                        pb8Levens.Visible = false;
                        pb7Levens.Visible = false;
                        pb6Levens.Visible = false;
                        pb5Levens.Visible = false;
                        pb4Levens.Visible = false;
                        pb3Levens.Visible = false;
                        pb2Levens.Visible = false;
                        pb1Leven.Visible = false;
                        break;
                }
            }
            //runt de code om te kijken of je hebt gewonnen
            if (winCheck())
            {
                gameOver();
                MessageBox.Show("U hebt gewonnen!", "Gewonnen!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        //heb hier een functie van gemaakt voor overzicht: maakt alle bt
        private void gameOver()
        {
            btnA.Visible = false;
            btnB.Visible = false;
            btnC.Visible = false;
            btnD.Visible = false;
            btnE.Visible = false;
            btnF.Visible = false;
            btnG.Visible = false;
            btnH.Visible = false;
            btnI.Visible = false;
            btnJ.Visible = false;
            btnK.Visible = false;
            btnL.Visible = false;
            btnM.Visible = false;
            btnN.Visible = false;
            btnO.Visible = false;
            btnP.Visible = false;
            btnQ.Visible = false;
            btnR.Visible = false;
            btnS.Visible = false;
            btnT.Visible = false;
            btnU.Visible = false;
            btnV.Visible = false;
            btnW.Visible = false;
            btnX.Visible = false;
            btnY.Visible = false;
            btnZ.Visible = false;
            btnOpnieuw.Visible = true;
            btnKies.Visible = true;
            btnHome.Visible = true;
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            chosenLetter = 'a';
            btnFunctie(chosenLetter);
            btnA.Visible = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            chosenLetter = 'b';
            btnFunctie(chosenLetter);
            btnB.Visible = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            chosenLetter = 'c';
            btnFunctie(chosenLetter);
            btnC.Visible = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            chosenLetter = 'd';
            btnFunctie(chosenLetter);
            btnD.Visible = false;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            chosenLetter = 'e';
            btnFunctie(chosenLetter);
            btnE.Visible = false;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            chosenLetter = 'f';
            btnFunctie(chosenLetter);
            btnF.Visible = false;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            chosenLetter = 'g';
            btnFunctie(chosenLetter);
            btnG.Visible = false;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            chosenLetter = 'h';
            btnFunctie(chosenLetter);
            btnH.Visible = false;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            chosenLetter = 'i';
            btnFunctie(chosenLetter);
            btnI.Visible = false;
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            chosenLetter = 'j';
            btnFunctie(chosenLetter);
            btnJ.Visible = false;
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            chosenLetter = 'k';
            btnFunctie(chosenLetter);
            btnK.Visible = false;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            chosenLetter = 'l';
            btnFunctie(chosenLetter);
            btnL.Visible = false;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            chosenLetter = 'm';
            btnFunctie(chosenLetter);
            btnM.Visible = false;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            chosenLetter = 'n';
            btnFunctie(chosenLetter);
            btnN.Visible = false;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            chosenLetter = 'o';
            btnFunctie(chosenLetter);
            btnO.Visible = false;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            chosenLetter = 'p';
            btnFunctie(chosenLetter);
            btnP.Visible = false;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            chosenLetter = 'q';
            btnFunctie(chosenLetter);
            btnQ.Visible = false;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            chosenLetter = 'r';
            btnFunctie(chosenLetter);
            btnR.Visible = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            chosenLetter = 's';
            btnFunctie(chosenLetter);
            btnS.Visible = false;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            chosenLetter = 't';
            btnFunctie(chosenLetter);
            btnT.Visible = false;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            chosenLetter = 'u';
            btnFunctie(chosenLetter);
            btnU.Visible = false;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            chosenLetter = 'v';
            btnFunctie(chosenLetter);
            btnV.Visible = false;
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            chosenLetter = 'w';
            btnFunctie(chosenLetter);
            btnW.Visible = false;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            chosenLetter = 'x';
            btnFunctie(chosenLetter);
            btnX.Visible = false;
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            chosenLetter = 'y';
            btnFunctie(chosenLetter);
            btnY.Visible = false;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            chosenLetter = 'z';
            btnFunctie(chosenLetter);
            btnZ.Visible = false;
        }

        private void btnOpnieuw_Click(object sender, EventArgs e)
        {
            opnieuw = true;
            this.Hide();
            this.Close();
        }

        private void pb9Levens_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void BtnKies_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            end = true;
            this.Hide();
            this.Close();
        }
    }
}
