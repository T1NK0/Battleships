using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    class NPC : GameController
    {
        #region npc methods
        //randomize ship placement within array
        //Choose target at random if no target is hit.
        //If target is hit, try to 1 of 4 sides, if hit again, continue, if not, hit oposit, or try the 2 sides.
        #endregion

        //Enemy ships
        public bool[,] npcShipBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.
        public string NpcPlaceShips()
        {
            Random rnd = new Random();
            int tempX = rnd.Next(0, 10);
            int tempY = rnd.Next(0, 10);
            int tempHV = rnd.Next(1, 11);
            string hv = null;
            if (tempHV <= 5)
            {
                hv = "h";
            }
            if (tempHV > 5)
            {
                hv = "v";
            }
            return hv;
        }

        //Enemy target areas 10x10
        public bool[,] npcTargetsBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.
    }
}
