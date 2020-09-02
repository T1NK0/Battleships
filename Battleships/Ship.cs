using System;
using System.Collections.Generic;
using System.Text;

namespace Battleships
{
    //public enum Direction
    //{
    //    horizontal, //Predefined to value 0
    //    vertical, //Predefined to value 1
    //}
    public abstract class Ship
    {
        #region private fields
        private string name;
        private int length;
        //private Direction direction;
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
        //public Direction Direction
        //{
        //    get { return direction; }
        //    set { direction = value; }
        //}
        #endregion

        #region constructors
        public Ship()
        {

        }
        #endregion
    }
}
