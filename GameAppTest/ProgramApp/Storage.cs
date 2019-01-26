using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    class Storage
    {
        private static Armor[] armor;
        private static Weapon[] weapon;
        private static Additionals[] additionals;

    public Storage(Armor[] _armor, Weapon[] _weapon, Additionals[] _additionals)
        {
            armor = _armor;
            weapon = _weapon;
            additionals = _additionals;
        }

        public static Weapon[] getWeaponByAttack()
        {
            return weapon;
        }

        public static Armor[] getArmorByDefence()
        {
            return armor;
        }

        public static Additionals[] getAdditionals()
        {
            return additionals;
        }
    }
}
