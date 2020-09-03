using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    public class Ship
    {
        #region private fields
        private string name;
        private int length;
        #endregion

        #region get/sets
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        #endregion

        #region constructors
        public Ship()
        {

        }
        #endregion
    }
}
