using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    class Battleship:Ship
    {
        #region private fields
        private bool cellOne;
        private bool cellTwo;
        private bool cellThree;
        private bool cellFour;
        #endregion

        #region propertys
        public bool CellOne
        {
            get { return cellOne; }
            set { cellOne = value; }
        }
        public bool CellTwo
        {
            get { return cellTwo; }
            set { cellTwo = value; }
        }
        public bool CellThree
        {
            get { return cellThree; }
            set { cellThree = value; }
        }
        public bool CellFour
        {
            get { return cellFour; }
            set { cellFour = value; }
        }
        #endregion

        #region constructor
        public Battleship()
        {
            Name = "Battleship";
            Length = 4;
            CellOne = true;
            CellTwo = true;
            CellThree = true;
            CellFour = true;
        }
        #endregion
    }
}
