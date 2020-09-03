﻿using System;

namespace Battleships
{
    class Program
    {
        static string MenuChoise(string correctkeys)    //Method to catch user press/keyinfo and returns the user choise as a string, secured for CAPS-lock.
        {
            string answer = ""; // Used to save user input
            do
            {
                ConsoleKeyInfo info = Console.ReadKey(); //Catches keyinfo and saves to info
                answer = Convert.ToString(info.KeyChar).ToLower(); //Converts to string, and secured for capital letters
                if (correctkeys.IndexOf(answer) < 0) // If user input is not of the given characters, IndexOf returns -1, and the statement is false!
                {
                    Console.Write(" Wrong input!");
                }
            }
            while (correctkeys.IndexOf(answer) < 0); //Runs until correct input.

            return answer; // Returns user choise
        }

        public string ShipPlacementGui()
        {
            Console.Write("Write the 'X' cordinate: ");
            int shipPlacementX = Convert.ToInt32(MenuChoise("0123456789"));
            Console.Write("\nWrite the 'Y' cordinate: ");
            int shipPlacementY = Convert.ToInt32(MenuChoise("0123456789"));
            Console.Write("\nWrite 'h' for horizontal, write 'v' for vertical: ");
            string directionChoice = MenuChoise("hv");

            string AllUserInputs = shipPlacementX + shipPlacementY + directionChoice;
            return AllUserInputs;
        }

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
                //User input
                int shipsLength = playerShip.Length;
                Console.WriteLine($"Place: {playerShip.Name}");
                
                Console.Write("Write the 'X' cordinate: ");
                int shipPlacementX = Convert.ToInt32(MenuChoise("0123456789"));

                Console.Write("\nWrite the 'Y' cordinate: ");
                int shipPlacementY = Convert.ToInt32(MenuChoise("0123456789"));

                Console.Write("\nWrite 'h' for horizontal, write 'v' for vertical: ");
                string directionChoice = MenuChoise("hv");

                Console.WriteLine("\n");

                //Placeship method
                gameController.PlaceShips(shipPlacementX, shipPlacementY, directionChoice, shipsLength); //Call our PlaceShip method and send the user inputted values as parameters.

                Console.WriteLine();

                Console.WriteLine("Your ships placement:");
                for (int i = 0; i < gameController.PlayerShipsBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < gameController.PlayerShipsBoard.GetLength(1); j++)
                    {
                        if (gameController.PlayerShipsBoard[i, j] == false)
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
            for (int i = 0; i < gameController.PlayerShipsBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameController.PlayerShipsBoard.GetLength(1); j++)
                {
                    if (gameController.PlayerShipsBoard[i, j] == false)
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
                int userTargetX = int.Parse(MenuChoise("0123456789"));

                Console.Write("Write the targeted 'Y' cordinate: ");
                int userTargetY = int.Parse(MenuChoise("0123456789"));

                player.PlayerShoot(userTargetX, userTargetY);

                Console.WriteLine("Your guesses has been placed as follows: ");
                for (int i = 0; i < gameController.PlayerShipsBoard.GetLength(0); i++)
                {
                    for (int j = 0; j < gameController.PlayerShipsBoard.GetLength(1); j++)
                    {
                        if (gameController.PlayerShipsBoard[i, j] == false)
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
