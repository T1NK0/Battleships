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
            //foreach (Ship ship in gameController.playerShips)
            //{
            //    int shipsLength = ship.Length;
            //    Console.WriteLine($"Place: {ship.Name}");
            //    Console.Write("Write the 'X' cordinate: ");
            //    int x = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Write the 'Y' cordinate: ");
            //    int y = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Write 'h' for horizontal, write 'v' for vertical: ");
            //    string directionChoice = Console.ReadLine().ToLower();
            //    player.PlaceShips(x, y, directionChoice, shipsLength); //Call our PlaceShip method and send the user inputted values as parameters.

            //    Console.WriteLine();

            //    Console.WriteLine("Your ships placement:");
            //    for (int i = 0; i < player.playerShipsBoard.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < player.playerShipsBoard.GetLength(1); j++)
            //        {
            //            if (player.playerShipsBoard[i, j] == false)
            //            {
            //                Console.Write("[ ]");
            //            }
            //            else
            //            {
            //                Console.Write("[O]");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region playerboard with ships
            //Console.WriteLine("Your ships has been placed as follows: ");
            //for (int i = 0; i < player.playerShipsBoard.GetLength(0); i++)
            //{
            //    for (int j = 0; j < player.playerShipsBoard.GetLength(1); j++)
            //    {
            //        if (player.playerShipsBoard[i, j] == false)
            //        {
            //            Console.Write("[ ]");
            //        }
            //        else
            //        {
            //            Console.Write("[O]");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region npc place ships
            Console.WriteLine(npc.NpcPlaceShips());
            #endregion
            Console.ReadLine();
        }
    }
}
