using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColourFlow.Classes
{
    public class GDec
    {
        //Contains all the Declarations for games.
        //They are accessed on the load function of a new game.

        //Board Sizes
      public short SmallS { get { return 10; } }
      public short MedS { get { return 15; } }
      public short LargeS { get { return 20; } }
      public short VlargeS { get { return 25; } }


        //Tile Sizes
      public int STile { get { return 40; } }
      public int MTile { get { return 27; } }
      public int LTile { get { return 20; } }
      public int VLTIle { get { return 16; } }

        //Number of Moves
      public int SMoves { get { return 27; } }
      public int MMoves { get { return 39; } }
      public int LMoves { get { return 51; } }
      public int VLMoves { get { return 63; } }

    }
}