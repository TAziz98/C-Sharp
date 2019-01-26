
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Additionals:P_Object
    {
        private string type;
        private int attack;


        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }

        public Additionals(string name, double price, string level, string _type) :
            base(name, price, level)
        {
            type = _type;

        }

        public string getType()
        {
            return type;
        }


    }
}
