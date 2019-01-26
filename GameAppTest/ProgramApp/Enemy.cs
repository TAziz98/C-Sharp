using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Enemy : Person
    {
        private double expForKill;
        private int moneyForKill;
        private P_Object item;

        public double ExpForKill
        {
            get
            {
                return expForKill;
            }
            set
            {
                expForKill = value;
            }
        }
        public int MoneyForKill
        {
            get
            {
                return moneyForKill;
            }
            set
            {
                moneyForKill = value;
            }
        }
        public  P_Object Item
        {
            get
            {
                return item;
            }
            set
            {
                item = value;
            }
        }
        public Enemy(int level, string name, int attack, int health) :
            base(level, name, attack, health)
        {

        }

        public void dropItem()
        {

        }
        public override Vector shoot()
        {
            throw new NotImplementedException();
        }

        public override void walk()
        {
            throw new NotImplementedException();
        }

        public override void jump()
        {
            throw new NotImplementedException();
        }
        /*
*   public override int getHealth()
{
   throw new NotImplementedException();
}

public override void jump()
{
   throw new NotImplementedException();
}

public override void setHealth(int newHealth)
{
   throw new NotImplementedException();
}*/
    }
}
