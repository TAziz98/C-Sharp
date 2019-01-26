using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    abstract class Person
    {
        private int _level;
        private string _name;
        private int _attack;
        private int _health;

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

        public int  Level
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
        public int Attack
        {
            get
            {
                return _attack;
            }
            set
            {
                _attack = value;
            }
        }
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health= value;
            }
        }
        public Person(int level, string name, int attack, int health)
        {
            this.Level = level;
            this.Name = name;
            this.Attack = attack;
            this.Health = health;
            
        }

        public abstract void walk();
        public abstract Vector shoot();
        public abstract void jump();

        // unnecessary
        //    public abstract int getHealth();
        //    public abstract void setHealth(int newHealth);
    }
}
