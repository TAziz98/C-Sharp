using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Inventory
    {
        private P_Object[] objectsInventory;
        private Armor armor;
        private Weapon weapon;
        private Additionals additionals;

        public Armor Armor
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
        public Weapon Weapon
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
        public Additionals Additionals
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

        public Inventory(P_Object[] _objectsInventory)
        {
            objectsInventory = _objectsInventory;
        }

        public P_Object[] getObjects()
        {
            return objectsInventory;
        }
    }
}
