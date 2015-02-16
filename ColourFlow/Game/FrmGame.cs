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
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
        }

        public static Graphics G; //Used for drawing the ojects

        //Classes used in Game
        Classes.Game Game; //Class File for the game;
        Classes.Palette Palette= new Classes.Palette(); //Palette Class used in the game.
        Flow.Declarations.Palette CurrentPalette = new Flow.Declarations.Palette(); //Used for drawing

        short[,] Grid; //The Game Map
        short Steps = 0; //The number of steps for the current game
        short Last_move = 99; //The value of the last colour selected

        int TotalSteps = 0; //The total number of steps allowed in the current game.
       
        bool FreeMode = false; //Set to true if the game is going to be played in freemode.

        #region Form Events
        //Contains the Basic GUI operations
        //FormLoad is not contined here due to it's complex startup

        private void FrmGame_FormClosing(object sender, EventArgs e)
        {
            //Loads the main form again once you have closed this form
            Form Main = new Form1();
            Main.Visible = true;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close(); //Closing the form
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            Classes.Help Help = new Classes.Help(1); //Displays the help functions
        }

        #endregion

        #region Start Game Functions
        //Contians the methods that are called when a game is setup. Primarily on FormLoad

        private void Start(int mode)
        {
            //Will set up everything for the game that is needed based on what the user that chosen

            switch (mode)   //Setting up each Game mode
            {
                //Each Game mode is setup. the Moves are added and the Grid and tile sizes have been set.
                case 1:
                    {
                        Game = new Classes.Game(1);
                        this.lblTitle.Text = "Game: Easy";
                        this.TotalSteps = Game.Dec.SMoves;
                        break;
                    }

                case 2:
                    {
                        Game = new Classes.Game(2);
                        this.lblTitle.Text = "Game: Medium";
                        this.TotalSteps = Game.Dec.MMoves;
                        break;
                    }

                case 3:
                    {
                        Game = new Classes.Game(3);
                        this.lblTitle.Text = "Game: Large";
                        this.TotalSteps = Game.Dec.LMoves;
                        break;
                    }

                case 4:
                    {
                        Game = new Classes.Game(4);
                        this.lblTitle.Text = "Game: Very Large";
                        this.TotalSteps = Game.Dec.VLMoves;
                        break;
                    }
            }

            Init(); //Runs through and "Init" sub, which is called, so a New Game is made possible.
        }

        private void Init()
        {
            Grid = new short[Game.Size, Game.Size]; //Creates a array for which the grid shall be filled

            Steps = 0; //Set's the curretn Step count to 0

            Palette.Setup(); //Fills Default Schemes, if needed
            CurrentPalette = Palette.LoadPalette(Properties.Settings.Default.Palette); //Loading the currently selected Pallette into the Game

            FillColours(); //Adds the colours of the palette to the form, so the user can choose what colours they wish

            GenMap(ref Grid); //Creates a random game for the player

            Last_move = 99; //Resetting the last move so they can use the first one

            Draw.Start(); //Starts the timer to draw that to screen
        }

        private void FillColours()
        {
            //Fills the 6 colours boxes on the screen so the user knows what colour to choose and so thehame can actually be played.
            PB1.BackColor = CurrentPalette.Colour.C1;
            PB2.BackColor = CurrentPalette.Colour.C2;
            PB3.BackColor = CurrentPalette.Colour.C3;
            PB4.BackColor = CurrentPalette.Colour.C4;
            PB5.BackColor = CurrentPalette.Colour.C5;
            PB6.BackColor = CurrentPalette.Colour.C6;
        }

        #endregion

        #region Game Functions
        //Contains all the Game Functions. 

        #region Colour Buttons
        //This region deals with the coloured buttons being pressed and the code attache to them
        //Each box is tame, just the parametres change
        private void PB1_Click(object sender, EventArgs e)
        {
           if (Last_move != 0) //Checks if this colour was the last move, so the user doesn't click it twice by accident
           {
            Do_Button(0); //Runs the do button method, which calculates all the squares that need to change
            if (FreeMode == false) //Check if the user is playing freemode and if so then don't increment step count
            {
                Steps++; //Increases steps by 1
            }
            Last_move = 0; //Makes this colour the last colour that was played in the game
           }
           CheckSteps(); //Checks if the player has reached the total number of steps allocated.
        }
       
        private void PB2_Click(object sender, EventArgs e)
        {
            if (Last_move != 1)
            {
                Do_Button(1);
                if (FreeMode == false)
                {
                    Steps++;
                }
                Last_move = 1;
            }
            CheckSteps();
        }
       
        private void PB3_Click(object sender, EventArgs e)
        {
           if (Last_move != 2)
           {
            Do_Button(2);
            if (FreeMode == false)
            {
                Steps++;
            }
            Last_move = 2;
           }
           CheckSteps();
        }
    
        private void PB4_Click(object sender, EventArgs e)
        {
            if (Last_move != 3)
            {
                Do_Button(3);
                if (FreeMode == false)
                {
                    Steps++;
                }
                 Last_move = 3;
            }
            CheckSteps();
        }

        private void PB5_Click(object sender, EventArgs e)
        {
            if (Last_move != 4)
            {
                Do_Button(4);
                if (FreeMode == false)
                {
                    Steps++;
                }
                Last_move = 4;
            }
            CheckSteps();
        }

        private void PB6_Click(object sender, EventArgs e)
        {
            if (Last_move != 5)
            {
                Do_Button(5);
                if (FreeMode == false)
                {
                    Steps++;
                }
                Last_move = 5;
            }
            CheckSteps();
        }

        #endregion

        private void Do_Button(short choice)
        {
            //Do Button cupdates the grid and checks if a win has occured
            Grid = Game.CheckGrid(Grid, choice); //Updaing the grid witht he new colour and so will be dipslayed on the drawing timer
            if (Game.CheckWin(Grid, choice) == true) //Calls the CheckWin method and checks if you have won
            {
                Flow.FrmWin Dialog = new Flow.FrmWin(); //Creates new instance of the Win Dialog
                Dialog.Win = true; //Sets all the properties so it will display the right information
                Dialog.Steps = Steps;
                Dialog.Free = FreeMode;
                Dialog.Mode = lblTitle.Text;
                Dialog.ShowDialog(); //Show's the dialog to the user
                if (Dialog.ProperClose == true) { this.Close(); } //Checks a property of the closed window to make sure the user don't wish to start a new game
                else { Draw.Stop(); Init(); } //Starts a new game.
                Dialog.Dispose(); //Removes object from game
            }
        }

        private void CheckSteps()
        {
            //This method checks if the player has used more then the allocated step count. If so the game ends and displays something to the user
            if (Steps == TotalSteps) //Checks if the current sets is equal to the number allowed
            {
                Flow.FrmWin Dialog = new Flow.FrmWin(); //Creates an new instance of the Win Dialog
                Dialog.Win = false; //Sets the properties of it so it will be displayed
                Dialog.Steps = Steps;
                Dialog.Free = FreeMode;
                Dialog.Mode = lblTitle.Text;
                Dialog.ShowDialog(); //Displays this to the user
                if (Dialog.ProperClose == true) { this.Close(); } //Checks for property that is set if the user want's a new game
                else { Draw.Stop(); Init(); } //Starts a new game
                Dialog.Dispose(); //Removes the object from the game
            }
        }

        private void GenMap(ref short[,] Grid)
        {
            //Generatres the Random Grid for the player to use when playing the game
            Random rand = new Random();
            short x = 0, y = 0;
            short choice = 0;

            for (x = 0; x <= (Game.Size - 1); x++)
            {
                for (y = 0; y <= (Game.Size -1); y++)
                {
                    choice = Convert.ToInt16(rand.Next(0, 6)); //For each loction in the Array, each place will be assigned one of the random numbers to which a colour will be attached
                    Grid[x, y] = choice; //Adding to the Grid
                }
            }
        }

        #endregion

        private void FrmGame_Load(object sender, EventArgs e)
        {
            G = this.DPanel.CreateGraphics(); //Creating the Graphics object for the Panel

            Flow.FrmMode Dialog = new Flow.FrmMode(); //Declaring the dialog for the Mode that the user will choose
            Dialog.ShowDialog(); //Showing the dialog to the user

            int choice = Dialog.Mode; //Once it's close it'll get the Mode Property that has been set within the game
            FreeMode = Dialog.Free; //Setting it this is free mode or not

            if (choice == 0) { this.Close(); return; } //Exit this incase the player hasn't picked a value or doesn't want to play to stop errors.

            Dialog.Dispose(); //Getting rid of the object as it's no longer needed

            Check_Skin();

            Start(choice); //Runs through the setup of the game, loading in the required values and starting to draw.
        }

        private void Draw_Tick(object sender, EventArgs e)
        {
            //This draws the Game on the form
            Game.DrawGrid(Grid, CurrentPalette); //Draws the Map on screen while it is playing
            if (FreeMode == false) //Depending on the mode, displays the current number of steps used against the total
            {
                this.lblSteps.Text = "Steps: " + Convert.ToString(Steps) + "/" + Convert.ToString(TotalSteps);
            }
            else
            {
                this.lblSteps.Text = "Steps: ∞/" + Convert.ToString(TotalSteps);
            }
        }

        private void Check_Skin()
        {

            if (Properties.Settings.Default.Skin == true)
            {
                //Firstly changing all the main labels on the form
                lblSteps.ForeColor = Color.Black;
                label1.ForeColor = Color.Black;


                lblTitle.ForeColor = Color.Black;

                lblAuthor.ForeColor = Color.Black;
                lblHelp.ForeColor = Color.Black;
                lblClose.ForeColor = Color.Black;

                pbLogo.Image = Properties.Resources.Logo__White;

                this.BackColor = Color.White;
            }

        }

    }
}