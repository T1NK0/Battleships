using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    class Submarine:Ship
    {
        #region private fields
        private bool cellOne;
        private bool cellTwo;
        private bool cellThree;
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
        #endregion

        #region constructor
        public Submarine()
        {
            Name = "Submarine";
            Length = 3;
            CellOne = true;
            CellTwo = true;
            CellThree = true;
        }
        #endregion
    }
}
