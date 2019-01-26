using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Player : Person
    {
        private int money;
        private Armor armor;
        private Weapon weapon;
        private double experience;
        private Inventory inventory;

        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
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

        public double Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }

        public Inventory Inventory
        {
            get
            {
                return inventory;
            }
            set
            {
                inventory = value;
            }
        }

        public Player(int level, string name, int attack, int health) : base(level,name,attack, health)
        {

        }

        public void open_Inventory()
        {

        }
        public override void jump()
        {
            throw new NotImplementedException();
        }

        public override Vector shoot()
        {
            throw new NotImplementedException();
        }

        public override void walk()
        {
            throw new NotImplementedException();
        }
        /*
                public override int getHealth()
                {
                    throw new NotImplementedException();
                }

                public override void setHealth(int newHealth)
                {
                    throw new NotImplementedException();
                }
                */


    }
}
