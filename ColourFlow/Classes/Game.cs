using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ColourFlow.Classes
{
   public class Game
    { 
       //This Class contains the main functions of the Game

       public GDec Dec = new GDec(); //Declarations Class File

       short GameMode = 0; //Gamemode is changed when the Game is started
       //1 = Easy / 2 = Medium / 3 = Large / 4 = VLarge

       //Set when the a Game instance is started
       private short MSize = 0;  //Grid Size for Drawing and checking
       private int TSize = 0; //Tile Size for drawing

       #region Initilization

       public Game(short Mode)
       {
           GameMode = Mode; //Setting the Game mode on creation
           Init(); //Loads in the values for size, tile size and the number of steps allowed
       }

       public short Size
       { 
           //Returns the size of the Grid for counting loops within the main game function
           get { return MSize; }
       }

       private void Init()
       {
           //Gets the Map and Tile Size depending on the mode that has been selected
           switch (GameMode)
           {
               case 1: { MSize = Dec.SmallS; TSize = Dec.STile; break; }
               case 2: { MSize = Dec.MedS; TSize = Dec.MTile; break; }
               case 3: { MSize = Dec.LargeS; TSize = Dec.LTile; break; }
               case 4: { MSize = Dec.VlargeS; TSize = Dec.VLTIle; break; }
           }
       }

       #endregion

       #region Game Functions

       public void DrawGrid(short[,] Grid, Flow.Declarations.Palette Palette)
       {
           int x = 0, y = 0; //Used for setting the coordinates of the squares to be drawn
           short index = 0, index2 = 0; //Counting variables
           short Choice = 0; //Used when choosing what colour to Draw the sqaures onto
           Brush Colour = Brushes.Black; //Set and then used to draw the squares - Black is set as default

           for (index = 0; index <= MSize - 1; index++)
           {
               y = 0; //Setting X as 0 as so to draw the right squares

               for (index2 = 0; index2 <= MSize - 1; index2++)
               {
                   Choice = Grid[index, index2]; //Get's the number of the current Grid location

                   switch (Choice) //Depending on the colour, will choose a colour associated with it.
                           //Colour is picked from the plaette passed into the routine
                   {
                       case 0: { Colour = new SolidBrush(Palette.Colour.C1); break; }
                       case 1: { Colour = new SolidBrush(Palette.Colour.C2); break; }
                       case 2: { Colour = new SolidBrush(Palette.Colour.C3); break; }
                       case 3: { Colour = new SolidBrush(Palette.Colour.C4); break; }
                       case 4: { Colour = new SolidBrush(Palette.Colour.C5); break; }
                       case 5: { Colour = new SolidBrush(Palette.Colour.C6); break; }
                   }

                    FrmGame.G.FillRectangle(Colour, x, y, TSize, TSize); //Drawing the rectange to the screen

                   y += TSize;
               }

               x += TSize;
           }
    
       }

       public short[,] CheckGrid(short[,] Grid, short choice)
       {
           //This method checks the squares of the grid and changes the correct ones to be changed
           short[,] NewGrid = new short[MSize, MSize]; //return variable where the new gird is saved
           bool[,] TempGridA = new bool[MSize, MSize]; //boolean variable which is used for testing the square's colour
           bool[,] TempGridB = new bool[MSize, MSize]; //boolean variable which is used for testing squares in other direction
           short CurrentColour = Grid[0, 0]; //The current colour of the game used a reference to see what squares might need to be changed
           short X = 0, Y = 0; //Counting variables
           short Limit = Convert.ToInt16(MSize - 1); //Used in Second counting loop

            //Loop is used to find all the squares of the current colour that are found within the grid
           for (X = 0; X <= MSize - 1; X++)
           {
               for (Y = 0; Y <= MSize - 1; Y++)
               {
                   if (Grid[X, Y] == CurrentColour) { TempGridA[X, Y] = true; TempGridB[X, Y] = true; } //Checks if the value of each square is equal to the top-right value
               }
           }


          /*Now check's the TempGrid for all true values. Will check the surrounding squares of the current one to check if it is surrounded by one
          /*of the same colour. If not then the value is set to false, so this wont change colour later on
           * This Check if performed from the top right to bottom left and checks
           *   ^
           * < X
           * 
           * Where "X" = Square being tested
          */
           for (X = 0; X <= MSize - 1; X++)
           {
               for (Y = 0; Y <= MSize - 1; Y++)
               {
                   if (TempGridA[X, Y] == true)
                   {

                       if ((X == 0) && (Y == 0))
                       {
                           TempGridA[X, Y] = true;
                       }
                       else if (X == 0)
                       {
                           if (TempGridA[X, Y - 1] == false)
                           {
                               TempGridA[X, Y] = false;
                           }
                       }
                       else if (Y == 0)
                       {
                           if (TempGridA[X - 1, Y] == false)
                           {
                               TempGridA[X, Y] = false;
                           }
                       }
                       else
                       {
                           if ((TempGridA[X-1,Y] == false) && (TempGridA[X,Y-1] == false))
                           {
                               TempGridA[X,Y] = false;
                           }
                       }
                   }
               }
             }


           /*Now check's the second TempGrid for all true values. Will check the surrounding squares of the current one to check if it is surrounded by one
           /*of the same colour. If not then the value is set to false, so this wont change colour later on
            * This Check if performed from the bottom left to top right and checks
            *   x >
            *   v
            *   
            * Where "X" = Square being tested
            */
           for (X = Limit; X >= 0; X--)
           {
               for (Y = Limit; Y >= 0; Y--)
               {
                   if (TempGridB[X,Y] == true)
                   {

                       if ((X == MSize - 1) && (Y == MSize - 1))
                       {
                           if ((TempGridA[X - 1, Y] == false) || (TempGridA[X, Y - 1] == false))
                           {
                               TempGridB[X, Y] = false;
                           }
                       }
                       else if (X == MSize -1)
                       {
                           if (TempGridA[X, Y + 1] == false)
                           {
                               TempGridB[X, Y] = false;
                           }
                       }
                       else if (Y == MSize - 1)
                       {
                           if (TempGridA[X + 1, Y] == false)
                           {
                               TempGridB[X, Y] = false;
                           }
                       }
                       else
                       {
                           if ((TempGridA[X + 1, Y] == false) && (TempGridA[X, Y + 1] == false))
                           {
                               TempGridB[X, Y] = false;
                           }
                       }
                   }
               }
           }

           /*Finally, once the 2 checks have been completed for adjacent squares the 2 arrays are checked
            * and if one, or the other is equal to true, then that value in the Grid has been changed
            */
           for (X = 0; X <= MSize - 1; X++)
           {
               for (Y = 0; Y <= MSize - 1; Y++)
               {
                   if ((TempGridA[X, Y] == true) || (TempGridB[X, Y] == true))
                   {
                       NewGrid[X, Y] = choice;
                   }
                   else
                   {
                       NewGrid[X, Y] = Grid[X, Y]; //If there is no change, then the old value is placed back in
                   }
               }
           }

           return NewGrid; 
       }

       public bool CheckWin(short[,] Grid, short choice)
       {
           //This method will calcualte if the game has been won or not

           bool Win = false; //Set to true if the game is finished. This is also the return value
           short total = 0; //Used when counting the number of equal squares
           short X = 0, Y = 0; //Counting variables

           for (X = 0; X <= MSize - 1; X++)
           {
               for (Y = 0; Y <= MSize - 1; Y++)
               {
                   if (Grid[X, Y] == choice) { total++; } //Checking each location and if it's equal to the choice, then total is incremented
               }
           }

           if (total == Grid.Length) { Win = true; } //Checking if all squares are the same and so will then return a true that a game has been won

           return Win;
       }

       #endregion

    }
}