using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    class GameController
    {
        public List<Ship> playerShips = new List<Ship>();
        public List<Ship> npcShips = new List<Ship>();

        #region game function methods
        //Create ships
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

        //Target hit method.
        //Ship sunk method.
        //if invalid ship placement
        //if invalid cordinates, tell user to rewrite cordinates, and try again.
        #endregion
    }
}
