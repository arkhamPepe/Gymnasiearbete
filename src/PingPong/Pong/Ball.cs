using System;
using System.Collections.Generic;
using System.Text;

namespace Pong
{
    class Ball
    {
        public bool direction = true; // Two states, right or left; true or false.
        public float speed; // Number of pixels per 
        public int size; // Width and height of ball, presumably they have the same value.
        public int _x; // X-coordinate in gameboard
        public int _y; // Y-coordinate in gameboard
        
        public Ball(bool d, float sp, int si, int x, int y) // d for direction, sp for speed, si for size.
        {
            direction = d;
            speed = sp;
            size = si;
            _x = x;
            _y = x;
        }

        /// <summary>
        /// Change current direction, horizontally.
        /// </summary>
        public void Turn()
        {
            if (direction)
                direction = false;
            else
                direction = true;
        }
    }
}
