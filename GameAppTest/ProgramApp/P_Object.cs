using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
   abstract class P_Object
    {
        private string _name;
        private double _price;
        private string _level;


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        public P_Object(string name,double price,string level)
        {
            Name = name;
            Price = price;
            Level = level;
        }
        

        
    }
}
