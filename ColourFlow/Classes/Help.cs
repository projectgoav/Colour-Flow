using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColourFlow.Classes
{
    public class Help
    {
        //The Help calss sets up the help window with required text before showing it. 
        //The Help is hardcoded into game and no loaded from file.
         
        public Help(short Type)
        {
            //When a "new" help instance is created, the value passed will setup the help required by the form it is then displayed and disposed
            switch (Type)
            {
                case 0: { Main_Menu(); break; } //Main Menu
                case 1: { Game();  break; } //Game
                case 2: { Palette(); break; } //Palette
                case 3: { Highscores(); break; } //Highscores
            }

        }

        #region Help Setup Functions

        //Each method in here declares a new instance of the help form. Adds a title bar text and the amount of help text that is needed before displaying the form

        private void Main_Menu()
        {
            FrmHelp Help = new FrmHelp();
            Help.lblHTitle.Text = "Help: Main Menu";
            Help.txtHelp.Text = "This is the Main Menu of the game. Click one of the labels to go to that part of the program. A small icon marks which label you have the mouse pointer at." + Environment.NewLine + Environment.NewLine + "Start : Starts a new game." + Environment.NewLine + Environment.NewLine + "Palette Creation: Here you can edit Palettes and choose what one you wish to use when playing." + Environment.NewLine + Environment.NewLine + "Highscores: Displays the Highscores." + Environment.NewLine + Environment.NewLine + "Exit: Closes the Game." + Environment.NewLine + Environment.NewLine + "Skin Changing: Check and uncheck the 'Use Dark Skin' box to change the game's skin. You have have either the 'Dark' or 'Light' Skin." + Environment.NewLine + "Dark: Black Background and White Text." + Environment.NewLine + "Light: White Background and Black Text";
            Help.ShowDialog();
            Help.Dispose();
        }

        private void Game()
        {
            FrmHelp Help = new FrmHelp();
            Help.lblHTitle.Text = "Help: Game";
            Help.txtHelp.Text = "Welcome to ColourFlow" + Environment.NewLine + "The aim of the game is to colour the entire board with the same colour. Starting with the TOP LEFT corner, you change the colour of the board using the 6 coloured squares around the side of the grid. Click on these to change the colour. Each time you change the colour it's counted as a 'step'." + Environment.NewLine + Environment.NewLine + "When you change colour, the top left square will change. All squares of the same colour adjacent to the top left corner will change colour as well. The idea is complete the board with the fewest number of steps." + Environment.NewLine + Environment.NewLine + "In Challenge Mode you have a step limit. If you haven't completed the board, but you reach the number of steps allocated the game ends. In Free Mode you have unlimited steps." + Environment.NewLine + Environment.NewLine + "The 6 colours that make up a grid are called a Palette. If you don't like the colours then why not visit the Palette Creation and choose a different palette. Or even create you own?" ;
            Help.ShowDialog();
            Help.Dispose();
        }

        private void Palette()
        {
            FrmHelp Help = new FrmHelp();
            Help.lblHTitle.Text = "Help: Palette Creation";
            Help.txtHelp.Text = "Welcome to Palette Creation" + Environment.NewLine + "Here you can choose what palette you want to use. If you don't like the default palettes - why not create your own?" + Environment.NewLine + Environment.NewLine + " To view a palette and edit it - click it's name from the list on the left of the form" + Environment.NewLine + Environment.NewLine + "Creating your own: To create your own Palette click 'New' above the list of names on the form. You can then name your palette. The name must be 10 characters OR LESS." + Environment.NewLine + "Once you have named your palette you can change any of the 6 colours contained in it. 6 coloured boxes signifiy the 6 colours of your palette. Click 'Change' beside the coloured square you wish to change the colour of." + Environment.NewLine + "You can then select a colour you wish to use in your palette" + Environment.NewLine + Environment.NewLine + "To save the current palette - click 'Save'" + Environment.NewLine + Environment.NewLine + "To delete the current palette - click 'Delete'" + Environment.NewLine + "Note: Once a palette has been deleted, you can not undo this action" + Environment.NewLine + Environment.NewLine + "To use the current palette - Click 'Use this Palette'." + Environment.NewLine + "By doing this, whenever you play a game, it will use the 6 colours you have choosen to make up the grid.";
            Help.ShowDialog();
            Help.Dispose();
        }

        private void Highscores()
        {
            FrmHelp Help = new FrmHelp();
            Help.lblHTitle.Text = "Help: High Scores";
            Help.txtHelp.Text = "The High scores displays some stats of the game." + Environment.NewLine + "These stats are updated automatically whenever you finish a game." + Environment.NewLine + Environment.NewLine + "Each board is shown here. They all contain the Total number of games you have played (In Challenge Mode, as Free Mode are not recorded), the number of games you have Won (again Challenge Mode only), a percetange of Wins:Loses and the shortest number of moves you have completed the grid in." + Environment.NewLine + Environment.NewLine+ "To can reset the stats." + Environment.NewLine + "To do this click 'Reset(!)' under a board. This will clear the data for that particular board. Clicking 'Reset All (!)' will clear data from all boards.";
            Help.ShowDialog();
            Help.Dispose();
        }

        #endregion
    }
}
