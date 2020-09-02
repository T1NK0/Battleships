using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    class Player : GameController
    {
        public bool[,] playerShipsBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.

        public void PlaceShips(int x, int y, string horizontalOrVertical, int shipToPlacelength)
        {
            int tempX = x;
            int tempY = y;
            string tempHV = horizontalOrVertical;

            int shipslength = shipToPlacelength; //Sets the int to the current ships length.

            if (tempHV == "h")
            {
                for (int i = 0; i < shipslength; i++)
                {
                    playerShipsBoard[tempX, tempY + i] = true; //Skal finde en måde at få Y værdien calculated med ind i. Acceptere kun 2 values pt.         
                }
            }
            else if (tempHV == "v")
            {
                for (int j = 0; j < shipslength; j++)
                {
                    playerShipsBoard[tempX + j, tempY] = true;//Skal finde en måde at få X værdien calculated med ind i. Acceptere kun 2 values pt.
                }
            }
        }

        //Player target area 10x10
        public bool[,] playerTargetBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.
        public string PlayerShoot(int xTargetPosition, int yTargetPosition)
        {
            NPC npc = new NPC();
            int targetX = xTargetPosition;
            int targetY = yTargetPosition;

            playerTargetBoard[targetX, targetY] = true;

            if (npc.npcShipBoard[targetX, targetY] == true)
            {
                return "SHIP HIT";
            }
            else
            {
                return "SPLASH!";

            }
        }

    }
}
