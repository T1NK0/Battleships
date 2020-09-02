using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    class Destroyer:Ship
    {
        #region private fields
        private bool cellOne;
        private bool cellTwo;
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
        #endregion

        #region constructor
        public Destroyer()
        {
            Name = "Destroyer";
            Length = 2;
            CellOne = true;
            CellTwo = true;
        }
        #endregion
    }
}
