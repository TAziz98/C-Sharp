using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Vector
    {
        private string position;
        private string direction;
        private string magnitude;

        public Vector(string _position, string _direction, string _magnitude)
        {
            position = _position;
            direction = _direction;
            magnitude = _magnitude;
        }
        public string Position
        {
            get
            {
                return position;
            }
          
        }
        public string Directiom
        {
            get
            {
                return direction;
            }
           
        }
        public string Magnitude
        {
            get
            {
                return magnitude;
            }
        }
    }
}
