using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColourFlow
{
    public partial class FrmHS : Form
    {

        public FrmHS()
        {
            InitializeComponent();
        }

        PictureBox[] Boxes = new PictureBox[4]; //Used in the GU interface
        Label[,] Labels = new Label[4, 3]; //Used for the Overall Labels when loading the highscores
        Label[,] BLabel = new Label[2, 10]; //Used for all the Board labels for quick display of Highscores
        GUI GUI = new GUI(); //GUI Class File

        #region GUI
        //Does all the GUI functions of the form

        private void FrmHS_FormClosing(object sender, EventArgs e)
        {
            //Makes the main form visible again
            Form Main = new Form1();
            Main.Visible = true;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Closing the form
        }

        private void FrmHS_Load(object sender, EventArgs e)
        {
            //Adding Boxes to Picture Box array
            Boxes[0] = this.Pb1;
            Boxes[1] = this.Pb2;
            Boxes[2] = this.Pb3;
            Boxes[3] = this.Pb4;

            //Adding Labels to Array
            Labels[0, 0] = this.lblEG;
            Labels[0, 1] = this.lblEW;
            Labels[0, 2] = this.lblEP;

            Labels[1, 0] = this.lblMG;
            Labels[1, 1] = this.lblMW;
            Labels[1, 2] = this.lblMP;

            Labels[2, 0] = this.lblLG;
            Labels[2, 1] = this.lblLW;
            Labels[2, 2] = this.lblLP;

            Labels[3, 0] = this.lblVLG;
            Labels[3, 1] = this.lblVLW;
            Labels[3, 2] = this.lblVLP;

            GUI.Setup(); //Fills the scheme variables
            GUI.FillBoxes(ref Boxes); //Selects and chooses a scheme then adds it to the picture boxes on the main form.

            Check_Skin(); //Updates the Form's Skin

            Load_Overall(); //Loads in the overall Scores to the form
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            Classes.Help Help = new Classes.Help(3); //Displays the help functions
        }

        #region Click Events
        //Handles the Reset functions of each one

        private void lblRVL_Click(object sender, EventArgs e)
        {
            Reset(4);
            Load_Overall();
        }

        private void lblRL_Click(object sender, EventArgs e)
        {
            Reset(3);
            Load_Overall();
        }

        private void lblRM_Click(object sender, EventArgs e)
        {
            Reset(2);
            Load_Overall();
        }

        private void lblRE_Click(object sender, EventArgs e)
        {
            Reset(1);
            Load_Overall();
        }

        private void lblRSA_Click(object sender, EventArgs e)
        {
            Reset(0);
            Load_Overall();
        }

        #endregion

        #endregion

        private void Load_Overall()
        {
            //This will load in the overall scores and display them on the screen
            short count = 0; //Used in the counting loop
            Flow.Declarations.OverallScore[] Score = new Flow.Declarations.OverallScore[4]; //Used to load in all the scores
            short[] Totals = new short[5];

            Score = Flow.HS.LoadOverall(); //Loading the highscores into the variable

            for (count = 0; count <= 3; count++)  //Going through each one to display it on the main form.
            {
                Labels[count, 0].Text = Convert.ToString(Score[count].Played);
                Labels[count, 1].Text = Convert.ToString(Score[count].Wins);
                Labels[count, 2].Text = Convert.ToString(Flow.HS.GetWinPercentage(Score[count].Wins, Score[count].Played)) + "%";
            }

            //Adding the shortest number of moves onto the form
            lblEM.Text = Convert.ToString(Score[0].Lowest);
            lblMM.Text = Convert.ToString(Score[1].Lowest);
            lblLM.Text = Convert.ToString(Score[2].Lowest);
            lblVLM.Text = Convert.ToString(Score[3].Lowest);


            Totals = Flow.HS.CalculateTotals(Score); //Calculates the totals for the game

            lblTG.Text = Convert.ToString(Totals[0]); //Adds the new total data to the form
            lblTW.Text = Convert.ToString(Totals[1]);
            lblTP.Text = Convert.ToString(Totals[2]) + "%";
        }

        private void Reset(short Type)
        {
            //This deals with the restting of highscores
            switch (Type)
            {
                case 0: { Flow.HS.Reset(0); break; } //Will do a complete reset of all the high scores
                case 1: { Flow.HS.Reset(1); break; } //Else clears the individual board
                case 2: { Flow.HS.Reset(2); break; }
                case 3: { Flow.HS.Reset(3); break; }
                case 4: { Flow.HS.Reset(4); break; }
            }
        }

        private void Check_Skin()
        {
            if (Properties.Settings.Default.Skin == true)
            {

                //Firstly changing all the main labels on the form
                int index1 = 0, index2 = 0;
                for (index1 = 0; index1 <= 3; index1++)
                {
                    for (index2 = 0; index2 <= 2; index2++)
                    {
                        Labels[index1, index2].ForeColor = Color.Black;
                    }
                }

                lblEM.ForeColor = Color.Black;
                lblMM.ForeColor = Color.Black;
                lblLM.ForeColor = Color.Black;
                lblVLM.ForeColor = Color.Black;

                lblEH.ForeColor = Color.Black;
                lblMH.ForeColor = Color.Black;
                lblLH.ForeColor = Color.Black;
                lblVLH.ForeColor = Color.Black;

                lblGT.ForeColor = Color.Black;
                lblWT.ForeColor = Color.Black;
                lblPW.ForeColor = Color.Black;
                lblST.ForeColor = Color.Black;

                lblTitle.ForeColor = Color.Black;
                label10002.ForeColor = Color.Black;

                lblRSA.ForeColor = Color.Black;
                lblRE.ForeColor = Color.Black;
                lblRM.ForeColor = Color.Black;
                lblRL.ForeColor = Color.Black;
                lblRVL.ForeColor = Color.Black;

                lblTGT.ForeColor = Color.Black;
                lblTWT.ForeColor = Color.Black;
                lblTPT.ForeColor = Color.Black;

                lblTG.ForeColor = Color.Black;
                lblTW.ForeColor = Color.Black;
                lblTP.ForeColor = Color.Black;

                lblAuthor.ForeColor = Color.Black;
                lblHelp.ForeColor = Color.Black;
                lblClose.ForeColor = Color.Black;

                pbLogo.Image = Properties.Resources.Logo__White;

                this.BackColor = Color.White;
            }
        }
    }
}