using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ColourFlow.Classes
{
    public class Palette
    {
        //Contains some of the basic functions used by the game when running.
        //Also is used in Palette creation when loading in the default palettes

        public Flow.Declarations.Palette[] Default = new Flow.Declarations.Palette[5]; //Variable to store some of the Default colour schemes

        public Flow.Declarations.Palette LoadPalette(string ID)
        {
            //This will load the curernt Palette into the game
            Flow.Declarations.Palette Palette = new Flow.Declarations.Palette();

            switch (ID) //Checking the ID
            {
                    //Default Schemes
                case "DEFAULT_BASIC": { Palette = Default[0]; break; } //Basic
                case "DEFAULT_CHALLENGE": { Palette = Default[1]; break; } //Challenge
                case "DEFAULT_FIREY": { Palette = Default[2]; break; } //Firey
                case "DEFAULT_COLD": { Palette = Default[3]; break;} //Cold

                    //User Schemes
                default: { Palette = Flow.Palettes.Load_Palette(Flow.Palettes.GetRecord(ID,true)); break; } //If the Default is not a defualt palette, then it's loaded from file
            }
           
            return Palette;
        }

        public void Setup()
        {
            //Setting up the Default Schemes
            //Files the variable with the hardcoded colour values

            //Basic Scheme
            Default[0].Name = "Basic";
            Default[0].Colour.C1 = Color.White;
            Default[0].Colour.C2 = Color.Red;
            Default[0].Colour.C3 = Color.Blue;
            Default[0].Colour.C4 = Color.Green;
            Default[0].Colour.C5 = Color.Orange;
            Default[0].Colour.C6 = Color.Yellow;

            //Challenge Scheme
            Default[1].Name = "Challenge";
            Default[1].Colour.C1 = Color.White;
            Default[1].Colour.C2 = Color.White;
            Default[1].Colour.C3 = Color.White;
            Default[1].Colour.C4 = Color.White;
            Default[1].Colour.C5 = Color.White;
            Default[1].Colour.C6 = Color.White;

            //Firey Scheme
            Default[2].Name = "Firey";
            Default[2].Colour.C1 = Color.Red;
            Default[2].Colour.C2 = Color.DarkOrange;
            Default[2].Colour.C3 = Color.Orange;
            Default[2].Colour.C4 = Color.Goldenrod;
            Default[2].Colour.C5 = Color.Yellow;
            Default[2].Colour.C6 = Color.White;
            
            //Cold
            Default[3].Name = "Cold";
            Default[3].Colour.C1 = Color.DarkBlue;
            Default[3].Colour.C2 = Color.Blue;
            Default[3].Colour.C3 = Color.RoyalBlue;
            Default[3].Colour.C4 = Color.SkyBlue;
            Default[3].Colour.C5 = Color.Green;
            Default[3].Colour.C6 = Color.LightGreen;

        }

    }
}
