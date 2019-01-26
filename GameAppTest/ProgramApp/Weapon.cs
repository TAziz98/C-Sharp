using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Weapon: P_Object
    {
        private int attack;
        private double distance;
        private int recoil;
        private double reload;
        private int magazine;

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
        public double Distance
        {
            get
            {
                return distance;
            }
            set
            {
                distance = value;
            }
        }

        public int Recoil
        {
            get
            {
                return recoil;
            }
            set
            {
                recoil = value;
            }
        }

        public double Reload
        {
            get
            {
                return reload;
            }
            set
            {
                reload = value;
            }
        }


        public int Magazine
        {
            get
            {
                return magazine;
            }
            set
            {
                magazine = value;
            }
        }
        public Weapon(string name, double price, string level) : base(name, price, level)
        {
        }
    }
}
