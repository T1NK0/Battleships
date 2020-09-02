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
        public void NpcPlaceShips(int shipLength)
        {
            Random rnd = new Random(); //Makes us able to randomice the npc with random numbers and do actions on the numbers given.
            int thisShipsLength = shipLength;

            int tempX = rnd.Next(0, 10); //Gives us a random X value to use for placement
            int tempY = rnd.Next(0, 10); //Gives us a random Y value to use for placement

            int tempHV = rnd.Next(1, 11); //Gives a random value for the horizontal or vertical, gotta calculate more
            string hv = null;
            if (tempHV <= 5)
            {
                hv = "h";
            }
            if (tempHV > 5)
            {
                hv = "v";
            }

            if (hv == "h")
            {
                for (int i = 0; i < thisShipsLength; i++)
                {
                    if (true)
                    {

                    }
                    npcShipBoard[tempX, tempY + i] = true; //Skal finde en måde at få Y værdien calculated med ind i. Acceptere kun 2 values pt.         
                }
            }
            else if (hv == "v")
            {
                for (int j = 0; j < thisShipsLength; j++)
                {
                    npcShipBoard[tempX + j, tempY] = true;//Skal finde en måde at få X værdien calculated med ind i. Acceptere kun 2 values pt.
                }
            }

            switch (shipLength)
            {
                case 5:

                    break;
                case 4:
                    break;
                case 3:
                    break;
                case 2:
                    break;
            }
        }

        //Enemy target areas 10x10
        public bool[,] npcTargetsBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.
    }
}
