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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] Boxes = new PictureBox[4]; //Array to store the boxes of the GUI
        GUI GUI = new GUI(); //GUI Class file

       //Most code within this form deals with the GU Interface of the form
       //It also contains links to the other forms required.

        private void Form1_Load(object sender, EventArgs e)
        {    
            //Adding Boxes to Picture Box array
            Boxes[0] = this.Pb1;
            Boxes[1] = this.Pb2;
            Boxes[2] = this.Pb3;
            Boxes[3] = this.Pb4;

            GUI.Setup(); //Fills the scheme variables
            GUI.FillBoxes(ref Boxes); //Selects and chooses a scheme then adds it to the picture boxes on the main form.

            Flow.HS.CheckFile(); //Checking to make sure there is a Highscores file in the content folder.

            //Checking for if the Game has to use the "Dark" Skin or the "Light Skin"
            if (Properties.Settings.Default.Skin == true)
            {
                chkBoxSkin.Checked = false; //Updates the form
                Change_Skin(); //Updates the Skin of the game
                Properties.Settings.Default.Save();
            }
        }

        #region Label Mouse Events
        //This area deals with the displaying and hidnig of the colour squares on the main form

        private void lblStart_MEnter(object sender, EventArgs e)
        {
            GUI.UpdateBoxes(ref Boxes, 0);
        }   

        private void lblPalette_MEnter(object sender, EventArgs e)
        {
            GUI.UpdateBoxes(ref Boxes, 1);
        }  

        private void lblHS_MEnter(object sender, EventArgs e)
        {
            GUI.UpdateBoxes(ref Boxes, 2);
        }
      
        private void lblExit_MEnter(object sender, EventArgs e)
        {
            GUI.UpdateBoxes(ref Boxes, 3);
        }
      
        private void LabelLeave(object sender, EventArgs e)
        {
            GUI.HideBoxes(ref Boxes);
        }

        #endregion

        #region Label Click Events
        //This region has the code for when a label on the GUI is clicked

        private void lblStart_Click(object sender, EventArgs e)
        {
            Form Game = new FrmGame(); //Declares new instance of the Game form
            Game.Show(); //Show's the form
            this.Visible = false;
        }

        private void lblPalette_Click(object sender, EventArgs e)
        {
            Form Palette = new FrmPalette(); //Declares new instance of the Palette form
            Palette.Show(); //Show's the form
            this.Visible = false;
        }

        private void lblHS_Click(object sender, EventArgs e)
        {
            Form HS = new FrmHS();
            HS.Show();
            this.Visible = false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            //Exit's the Game when the label is clicked
            System.Environment.Exit(0) ;
        }

        #endregion

        private void lblHelp_Click(object sender, EventArgs e)
        {
            Classes.Help Help = new Classes.Help(0);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(1);
        }


        private void Change_Skin()
        {
            //Changes the From either White or Black and the text on the form to the respective colour
            if (chkBoxSkin.Checked == true)
            {
                Properties.Settings.Default.Skin = false; //Updating the Settings within the game so it will use this skin when playing
                Properties.Settings.Default.Save();

                lblPalette.ForeColor = Color.White;
                lblStart.ForeColor = Color.White;
                lblHS.ForeColor = Color.White;
                lblHelp.ForeColor = Color.White;
                lblAuthor.ForeColor = Color.White;
                lblExit.ForeColor = Color.White;

                chkBoxSkin.ForeColor = Color.White;

                pbLogo.Image = Properties.Resources.Logo__Dark;

                this.BackColor = Color.Black;
            }
            else
            {
                Properties.Settings.Default.Skin = true; //Updating the Settings within the game so it will use this skin when playing
                Properties.Settings.Default.Save();

                lblPalette.ForeColor = Color.Black;
                lblStart.ForeColor = Color.Black;
                lblHS.ForeColor = Color.Black;
                lblHelp.ForeColor = Color.Black;
                lblAuthor.ForeColor = Color.Black;
                lblExit.ForeColor = Color.Black;

                chkBoxSkin.ForeColor = Color.Black;

                pbLogo.Image = Properties.Resources.Logo__White;

                this.BackColor = Color.White;

                this.Update();
                this.Refresh();
            }

        }

        private void chkBoxSkin_CheckedChanged(object sender, EventArgs e)
        {
            Change_Skin();
        }
    }
}