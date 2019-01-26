using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class ShopArea
    {
        private Armor[] armor;
        private Weapon[] weapon;
        private Additionals[] additionals;
        private Vector location;

        public Armor[] Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }
        public Weapon[] Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public Additionals[] Additionals
        {
            get
            {
                return additionals;
            }
            set
            {
                additionals = value;
            }
        }
        public Vector Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public void execute()
        {

        }

        public void chooseOption()
        {

        }

        public void sell()
        {

        }
    }
}
