using System;

namespace Battleships
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Constructor calls
            GameController gameController = new GameController();
            Player player = new Player();
            NPC npc = new NPC();
            #endregion

            #region Welcome Text
            Console.WriteLine("WELCOME TO BATTLESHIPS");

            Console.WriteLine();
            #endregion

            #region CreateShips
            gameController.PlayerShipCreater();
            gameController.NpcShipCreater();
            #endregion

            #region PlaceShips
            foreach (Ship playerShip in gameController.playerShips)
            {
                int shipsLength = playerShip.Length;
                Console.WriteLine($"Place: {playerShip.Name}");
                Console.Write("Write the 'X' cordinate: ");
                int shipPlacementX = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write the 'Y' cordinate: ");
                int shipPlacementY = Convert.ToInt32(Console.ReadLine());
                Console.Write("Write 'h' for horizontal, write 'v' for vertical: ");
                string directionChoice = Console.ReadLine().ToLower();
                player.PlaceShips(shipPlacementX, shipPlacementY, directionChoice, shipsLength); //Call our PlaceShip method and send the user inputted values as parameters.

                Console.WriteLine();

                Console.WriteLine("Your ships placement:");
                for (int i = 0; i < player.playerShipsBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < player.playerShipsBoard.GetLength(1); j++)
                    {
                        if (player.playerShipsBoard[i, j] == false)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[ ]");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("[O]");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            #endregion

            Console.Clear();

            #region playerboard with ships
            Console.WriteLine("Your ships has been placed as follows: ");
            for (int i = 0; i < player.playerShipsBoard.GetLength(0); i++)
            {
                for (int j = 0; j < player.playerShipsBoard.GetLength(1); j++)
                {
                    if (player.playerShipsBoard[i, j] == false)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[O]");
                    }
                }
                Console.WriteLine();
            }
            #endregion

            #region npc place ships
            //foreach (Ship npcShip in gameController.npcShips)
            //{
            //    int npcShipLength = npcShip.Length;
            //    npc.NpcPlaceShips(npcShipLength);
            //}
            #endregion

            bool shipsPlacedConfirmed = true;

            do
            {
                //Player turn
                Console.Write("Write the targeted 'X' cordinate: ");
                int userTargetX = int.Parse(Console.ReadLine());

                Console.Write("Write the targeted 'Y' cordinate: ");
                int userTargetY = int.Parse(Console.ReadLine());

                player.PlayerShoot(userTargetX, userTargetY);

                Console.WriteLine("Your guesses has been placed as follows: ");
                for (int i = 0; i < player.playerShipsBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < player.playerShipsBoard.GetLength(1); j++)
                    {
                        if (player.playerShipsBoard[i, j] == false)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write("[X]");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("[0]");
                        }
                    }
                    Console.WriteLine();
                }

                //Npc Turn


            } while (shipsPlacedConfirmed == true);
            #region Player Targeting

            #endregion

            Console.ReadLine();
        }
    }
}
