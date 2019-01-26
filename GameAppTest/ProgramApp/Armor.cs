using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Armor: P_Object
    {
        private string type;
        private int defence;

        public string Type
        {
            get
            {
                return type;
            }
        }

        public int Defence
        {
            get
            {
                return defence;
            }
        }

        public Armor(string name, double price, string level,string _type,int _defence) :
            base(name, price, level)
        {
            type = _type;
            defence = _defence;
        }
    }
}
