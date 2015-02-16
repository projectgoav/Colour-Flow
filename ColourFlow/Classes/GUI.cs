using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ColourFlow
{
   public class GUI
    {
       const short SchemeCount = 6; //Used for storing the number of schemes and in scheme picking

       //Structure used for storing a Colourscheme on the GUI
       public struct Scheme { public Color S1; public Color S2; public Color S3; public Color S4;} 

       //The sets of colours that will be used to display
       Scheme Red = new Scheme();
       Scheme Blue = new Scheme();
       Scheme Green = new Scheme();
       Scheme Orange = new Scheme();
       Scheme Pink = new Scheme();
       Scheme Purple = new Scheme();

       public void Setup()
       {
           //Adds the Colours of the GUI Squares to the Arrays

           //Red
           Red.S1 = Color.Red;
           Red.S2 = Color.Brown;
           Red.S3 = Color.Firebrick;
           Red.S4 = Color.IndianRed;

           //Blue
           Blue.S1 = Color.DarkBlue;
           Blue.S2 = Color.MediumBlue;
           Blue.S3 = Color.Blue;
           Blue.S4 = Color.RoyalBlue;

           //Green
           Green.S1 = Color.DarkGreen;
           Green.S2 = Color.Green;
           Green.S3 = Color.Lime;
           Green.S4 = Color.PaleGreen;

           //Orange
           Orange.S1 = Color.DarkOrange;
           Orange.S2 = Color.Orange;
           Orange.S3 = Color.Goldenrod;
           Orange.S4 = Color.Yellow;

           //Pink
           Pink.S1 = Color.MediumVioletRed;
           Pink.S2 = Color.DeepPink;
           Pink.S3 = Color.HotPink;
           Pink.S4 = Color.Violet;

           //Purple
           Purple.S1 = Color.Indigo;
           Purple.S2 = Color.DarkOrchid;
           Purple.S3 = Color.MediumOrchid;
           Purple.S4 = Color.Plum;
       }

       public void FillBoxes(ref PictureBox[] Box)
       {
           //Selects a random scheme and fills the boxes with the colours from that scheme
           Random rnd = new Random();
           int scheme = rnd.Next(0, SchemeCount); 

           switch (scheme)
           {
               case 0:
                   {
                       Box[0].BackColor = Red.S1;
                       Box[1].BackColor = Red.S2;
                       Box[2].BackColor = Red.S3;
                       Box[3].BackColor = Red.S4;
                       break;
                   }
               case 1:
                   {
                       Box[0].BackColor = Blue.S1;
                       Box[1].BackColor = Blue.S2;
                       Box[2].BackColor = Blue.S3;
                       Box[3].BackColor = Blue.S4;
                       break;
                   }

               case 2:
                   {
                       Box[0].BackColor = Green.S1;
                       Box[1].BackColor = Green.S2;
                       Box[2].BackColor = Green.S3;
                       Box[3].BackColor = Green.S4;
                       break;
                   }
               case 3:
                   {
                       Box[0].BackColor = Orange.S1;
                       Box[1].BackColor = Orange.S2;
                       Box[2].BackColor = Orange.S3;
                       Box[3].BackColor = Orange.S4;
                       break;
                   }
               case 4:
                   {
                       Box[0].BackColor = Pink.S1;
                       Box[1].BackColor = Pink.S2;
                       Box[2].BackColor = Pink.S3;
                       Box[3].BackColor = Pink.S4;
                       break;
                   }
               case 5:
                   {
                       Box[0].BackColor = Purple.S1;
                       Box[1].BackColor = Purple.S2;
                       Box[2].BackColor = Purple.S3;
                       Box[3].BackColor = Purple.S4;
                       break;
                   }

           }

       }

       public void UpdateBoxes(ref PictureBox[] Box, short BoxNum)
       {
           Box[BoxNum].Visible = true; //Sets the visible property of the selected Box to be visible
       }

       public void HideBoxes(ref PictureBox[] Box)
       {
           //Will hide the picture boxes from the form
           Box[0].Visible = false;
           Box[1].Visible = false;
           Box[2].Visible = false;
           Box[3].Visible = false;
       }
 
    }
}