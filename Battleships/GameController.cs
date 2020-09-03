using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    class GameController
    {
        public List<Ship> playerShips = new List<Ship>();
        public List<Ship> npcShips = new List<Ship>();

        //Player
        private bool[,] playerShipsBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.
        private bool[,] playerTargetBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.

        //Npc
        private bool[,] npcShipBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.
        private bool[,] npcTargetBoard = new bool[10, 10]; //Creates a 10x10 2d array with default false values.

        #region get set
        public bool[,] PlayerShipsBoard
        {
            get { return playerShipsBoard; }
            set { playerShipsBoard = value; }
        }
        public bool[,] PlayerTargetBoard
        {
            get { return playerTargetBoard; }
            set { playerTargetBoard = value; }
        }

        public bool[,] NpcShipBoard
        {
            get { return npcShipBoard; }
            set { npcShipBoard = value; }
        }
        public bool[,] NpcTargetBoard
        {
            get { return npcTargetBoard; }
            set { npcTargetBoard = value; }
        }
        #endregion

        #region game function methods
        #region create ships
        public Carrier CreateCarrier()
        {
            Carrier carrier = new Carrier();
            return carrier;
        }

        public Battleship CreateBattleship()
        {
            Battleship battleship = new Battleship();
            return battleship;
        }

        public Cruiser CreateCruiser()
        {
            Cruiser cruiser = new Cruiser();
            return cruiser;
        }

        public Submarine CreateSubmarine()
        {
            Submarine submarine = new Submarine();
            return submarine;
        }

        public Destroyer CreateDestroyer()
        {
            Destroyer destroyer = new Destroyer();
            return destroyer;
        }

        public void PlayerShipCreater()
        {
            playerShips.Add(CreateCarrier());
            playerShips.Add(CreateBattleship());
            playerShips.Add(CreateCruiser());
            playerShips.Add(CreateSubmarine());
            playerShips.Add(CreateDestroyer());
        }

        public void NpcShipCreater()
        {
            npcShips.Add(CreateCarrier());
            npcShips.Add(CreateBattleship());
            npcShips.Add(CreateCruiser());
            npcShips.Add(CreateSubmarine());
            npcShips.Add(CreateDestroyer());
        }
        #endregion
        #endregion

        #region Player functions
        #region Player place ship
        public void PlaceShips(int x, int y, string horizontalOrVertical, int shipToPlacelength)
        {
            Ship ship = new Ship();
            Program program = new Program();

            bool cellIsTaken = true;
            int tempX = x;
            int tempY = y;
            string tempHV = horizontalOrVertical;

            int shipslength = shipToPlacelength; //Sets the int to the current ships length.

            cellIsTaken = CheckCells(tempX, tempY, shipslength, tempHV, PlayerShipsBoard); //If cell isn't taken (return value is false)

            while (cellIsTaken) //Runs if the cellIsTaken statement is true
            {
                program.ShipPlacementGui();
            }

            if (cellIsTaken == false)
            {
                if (tempHV == "h")
                {
                    for (int i = 0; i < shipslength; i++)
                    {
                        playerShipsBoard[tempX, tempY + i] = true;
                    }
                }

                else if (tempHV == "v")
                {
                    for (int j = 0; j < shipslength; j++)
                    {
                        playerShipsBoard[tempX + j, tempY] = true;
                    }
                }
            }
        }
        private bool CheckCells(int x, int y, int shiplength, string direction, bool[,] PlayerShipBoards)
        {
            if (direction.ToLower() == "v") //Checks Vertical
            {
                if (y + shiplength - 1 > 9)
                {
                    Console.WriteLine("The ship is out of the grid! Try Again!");
                    return true;
                }
                for (int i = y; i < shiplength + y; i++)
                {
                    if (PlayerShipBoards[x, i] != false)
                    {
                        Console.WriteLine("The ship could not be place here, since theres a ship already, try again");
                        return true;
                    }
                }
                return false;
            }
            else //Checks Horizontal
            {
                if (x + shiplength - 1 > 9)
                {
                    Console.WriteLine("The ship is out of the grid! Try Again!");
                    return true;
                }
                for (int i = x; i < shiplength + x; i++)
                {
                    if (PlayerShipBoards[i, y] != false)
                    {
                        Console.WriteLine("The ship could not be place here, since theres a ship already, try again");
                        return true;
                    }
                }
                return false;
            }
        }

        #endregion
        #region Player Shoot
        public string PlayerShoot(int xTargetPosition, int yTargetPosition)
        {
            NPC npc = new NPC();
            int targetX = xTargetPosition;
            int targetY = yTargetPosition;

            PlayerTargetBoard[targetX, targetY] = true;

            if (npc.NpcShipBoard[targetX, targetY] == true)
            {
                return "SHIP HIT";
            }
            else
            {
                return "SPLASH!";

            }
        }
        #endregion
        #endregion

        #region Npc functions
        #region Npc place ships
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

            if (tempX + thisShipsLength <= 9 && tempY + thisShipsLength <= 9)
            {
                if (hv == "h")
                {
                    for (int i = 0; i < thisShipsLength; i++)
                    {
                        if (true)
                        {

                        }
                        NpcShipBoard[tempX, tempY + i] = true; //Skal finde en måde at få Y værdien calculated med ind i. Acceptere kun 2 values pt.         
                    }
                }
                else if (hv == "v")
                {
                    for (int j = 0; j < thisShipsLength; j++)
                    {
                        NpcShipBoard[tempX + j, tempY] = true;//Skal finde en måde at få X værdien calculated med ind i. Acceptere kun 2 values pt.
                    }
                }
            }
        }
        #endregion
        #endregion
    }
}
