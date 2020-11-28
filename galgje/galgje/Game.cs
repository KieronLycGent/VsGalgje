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
        bool a,b,c,d,ee,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z =false;

        private void pctQ_Click(object sender, EventArgs e)
        {
            if (!q)
            {
                chosenLetter = 'q';
                btnFunctie(chosenLetter);
                pctQ.Image = Properties.Resources.grafsteenNa1;
                q = true;
            }
        }

        private void pctR_Click(object sender, EventArgs e)
        {
            if (!r)
            {
                chosenLetter = 'r';
                btnFunctie(chosenLetter);
                pctR.Image = Properties.Resources.grafsteenNa1;
                r = true;
            }
        }

        private void pctS_Click(object sender, EventArgs e)
        {
            if (!s)
            {
                chosenLetter = 's';
                btnFunctie(chosenLetter);
                pctS.Image = Properties.Resources.grafsteenNa1;
                s = true;
            }
        }

        private void pctT_Click(object sender, EventArgs e)
        {
            if (!t)
            {
                chosenLetter = 't';
                btnFunctie(chosenLetter);
                pctT.Image = Properties.Resources.grafsteenNa1;
                t = true;
            }
        }

        private void pctU_Click(object sender, EventArgs e)
        {
            if (!u)
            {
                chosenLetter = 'u';
                btnFunctie(chosenLetter);
                pctU.Image = Properties.Resources.grafsteenNa1;
                u = true;
            }
        }

        private void pctV_Click(object sender, EventArgs e)
        {
            if (!v)
            {
                chosenLetter = 'v';
                btnFunctie(chosenLetter);
                pctV.Image = Properties.Resources.grafsteenNa1;
                v = true;
            }
        }

        private void pctW_Click(object sender, EventArgs e)
        {
            if (!w)
            {
                chosenLetter = 'w';
                btnFunctie(chosenLetter);
                pctW.Image = Properties.Resources.grafsteenNa1;
                w = true;
            }
        }

        private void pctX_Click(object sender, EventArgs e)
        {
            if (!x)
            {
                chosenLetter = 'x';
                btnFunctie(chosenLetter);
                pctX.Image = Properties.Resources.grafsteenNa1;
                x = true;
            }
        }

        private void pctY_Click(object sender, EventArgs e)
        {
            if (!y)
            {
                chosenLetter = 'y';
                btnFunctie(chosenLetter);
                pctY.Image = Properties.Resources.grafsteenNa1;
                y = true;
            }
        }

        private void pctZ_Click(object sender, EventArgs e)
        {
            if (!z)
            {
                chosenLetter = 'z';
                btnFunctie(chosenLetter);
                pctZ.Image = Properties.Resources.grafsteenNa1;
                z = true;
            }
        }

        private void pctP_Click(object sender, EventArgs e)
        {
            if (!p)
            {
                chosenLetter = 'p';
                btnFunctie(chosenLetter);
                pctP.Image = Properties.Resources.grafsteenNa1;
                p = true;
            }
        }

        private void pctO_Click(object sender, EventArgs e)
        {
            if (!o)
            {
                chosenLetter = 'o';
                btnFunctie(chosenLetter);
                pctO.Image = Properties.Resources.grafsteenNa1;
                o = true;
            }
        }

        private void pctN_Click(object sender, EventArgs e)
        {
            if (!n)
            {
                chosenLetter = 'n';
                btnFunctie(chosenLetter);
                pctN.Image = Properties.Resources.grafsteenNa1;
                n = true;
            }
        }

        private void pctM_Click(object sender, EventArgs e)
        {
            if (!m)
            {
                chosenLetter = 'm';
                btnFunctie(chosenLetter);
                pctM.Image = Properties.Resources.grafsteenNa1;
                m = true;
            }
        }

        private void pctL_Click(object sender, EventArgs e)
        {
            if (!l)
            {
                chosenLetter = 'l';
                btnFunctie(chosenLetter);
                pctL.Image = Properties.Resources.grafsteenNa1;
                l = true;
            }
        }

        private void pctK_Click(object sender, EventArgs e)
        {
            if (!k)
            {
                chosenLetter = 'k';
                btnFunctie(chosenLetter);
                pctK.Image = Properties.Resources.grafsteenNa1;
                k = true;
            }
        }

        private void pctJ_Click(object sender, EventArgs e)
        {
            if (!j)
            {
                chosenLetter = 'j';
                btnFunctie(chosenLetter);
                pctJ.Image = Properties.Resources.grafsteenNa1;
                j = true;
            }
        }

        private void pctI_Click(object sender, EventArgs e)
        {
            if (!i)
            {
                chosenLetter = 'i';
                btnFunctie(chosenLetter);
                pctI.Image = Properties.Resources.grafsteenNa1;
                i = true;
            }
        }

        private void pctH_Click(object sender, EventArgs e)
        {
            if (!h)
            {
                chosenLetter = 'h';
                btnFunctie(chosenLetter);
                pctH.Image = Properties.Resources.grafsteenNa1;
                h = true;
            }
        }

        private void pctG_Click(object sender, EventArgs e)
        {
            if (!g)
            {
                chosenLetter = 'g';
                btnFunctie(chosenLetter);
                pctG.Image = Properties.Resources.grafsteenNa1;
                g = true;
            }
        }

        private void pctF_Click(object sender, EventArgs e)
        {
            if (!f)
            {
                chosenLetter = 'f';
                btnFunctie(chosenLetter);
                pctF.Image = Properties.Resources.grafsteenNa1;
                f = true;
            }
        }

        private void pctE_Click(object sender, EventArgs e)
        {
            if (!ee)
            {
                chosenLetter = 'e';
                btnFunctie(chosenLetter);
                pctE.Image = Properties.Resources.grafsteenNa1;
                ee = true;
            }
        }

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

            pctA.Image = Properties.Resources.A;
            pctB.Image = Properties.Resources.B;
            pctC.Image = Properties.Resources.C;
            pctD.Image = Properties.Resources.D;
            pctE.Image = Properties.Resources.E;
            pctF.Image = Properties.Resources.F;
            pctG.Image = Properties.Resources.G;
            pctH.Image = Properties.Resources.H;
            pctI.Image = Properties.Resources.I;
            pctJ.Image = Properties.Resources.J;
            pctK.Image = Properties.Resources.K;
            pctL.Image = Properties.Resources.L;
            pctM.Image = Properties.Resources.M;
            pctN.Image = Properties.Resources.N;
            pctO.Image = Properties.Resources.O;
            pctP.Image = Properties.Resources.p;
            pctQ.Image = Properties.Resources.Q;
            pctR.Image = Properties.Resources.R;
            pctS.Image = Properties.Resources.S;
            pctT.Image = Properties.Resources.T;
            pctU.Image = Properties.Resources.U;
            pctV.Image = Properties.Resources.V;
            pctW.Image = Properties.Resources.W;
            pctX.Image = Properties.Resources.X;
            pctY.Image = Properties.Resources.Y;
            pctZ.Image = Properties.Resources.Z;
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
            btnOpnieuw.Visible = true;
            btnKies.Visible = true;
            btnHome.Visible = true;

            pctA.Image = Properties.Resources.grafsteenNa1;
            pctB.Image = Properties.Resources.grafsteenNa1;
            pctC.Image = Properties.Resources.grafsteenNa1;
            pctD.Image = Properties.Resources.grafsteenNa1;
            pctE.Image = Properties.Resources.grafsteenNa1;
            pctF.Image = Properties.Resources.grafsteenNa1;
            pctG.Image = Properties.Resources.grafsteenNa1;
            pctH.Image = Properties.Resources.grafsteenNa1;
            pctI.Image = Properties.Resources.grafsteenNa1;
            pctJ.Image = Properties.Resources.grafsteenNa1;
            pctK.Image = Properties.Resources.grafsteenNa1;
            pctL.Image = Properties.Resources.grafsteenNa1;
            pctM.Image = Properties.Resources.grafsteenNa1;
            pctN.Image = Properties.Resources.grafsteenNa1;
            pctO.Image = Properties.Resources.grafsteenNa1;
            pctP.Image = Properties.Resources.grafsteenNa1;
            pctQ.Image = Properties.Resources.grafsteenNa1;
            pctR.Image = Properties.Resources.grafsteenNa1;
            pctS.Image = Properties.Resources.grafsteenNa1;
            pctT.Image = Properties.Resources.grafsteenNa1;
            pctU.Image = Properties.Resources.grafsteenNa1;
            pctV.Image = Properties.Resources.grafsteenNa1;
            pctW.Image = Properties.Resources.grafsteenNa1;
            pctX.Image = Properties.Resources.grafsteenNa1;
            pctY.Image = Properties.Resources.grafsteenNa1;
            pctZ.Image = Properties.Resources.grafsteenNa1;

            
        }

        private void pctC_Click(object sender, EventArgs e)
        {
            if (!c)
            {
                chosenLetter = 'c';
                btnFunctie(chosenLetter);
                pctC.Image = Properties.Resources.grafsteenNa1;
                c = true;
            }
        }

        private void pctD_Click(object sender, EventArgs e)
        {
            if (!d)
            {
                chosenLetter = 'd';
                btnFunctie(chosenLetter);
                pctD.Image = Properties.Resources.grafsteenNa1;
                d = true;
            }
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

        private void pctA_Click_1(object sender, EventArgs e)
        {
            if(!a)
            {
                chosenLetter = 'a';
                btnFunctie(chosenLetter);
                pctA.Image = Properties.Resources.grafsteenNa1;
                a = true;
            }
        }

        private void pctB_Click(object sender, EventArgs e)
        {
            if (!b)
            {
                chosenLetter = 'b';
                btnFunctie(chosenLetter);
                pctB.Image = Properties.Resources.grafsteenNa1;
                b = true;
            }
        }
    }
}
