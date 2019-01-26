using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    [TestFixture]
    class StorageNUnitTest
    {
        /// <summary>
        /// Storage contains 400 Items
        /// </summary>

        [SetUp]
        public void Init()
        {
            Armor[] armors = new Armor[150];
            Armor armorHenry = new Armor("Armor of Henry II", 200.5, "Weak", "Rigid", 53);
            Armor armorSejudo = new Armor("Armor of Sejudo I", 300.2, "Strong", "Disruptive", 76);
            armors[0] = armorHenry; armors[1] = armorSejudo;
            Weapon[] weapons = new Weapon[150];
            Weapon sword = new Weapon("Sword", 300.4, "Medium");
            sword.Attack = 36; sword.Distance = 2;
            Weapon AK47 = new Weapon("AK-47", 1000.4, "Very-Strong");
            AK47.Attack = 91; AK47.Distance = 1046;
            weapons[0] = sword; weapons[1] = AK47;
            Additionals[] additionals = new Additionals[100];
            Additionals knife = new Additionals("King Arthur's Knife", 97.0, "Very-Weak", "Spear Point");
            knife.Attack = 17;
            Additionals granade = new Additionals("Russian Granade", 179.0, "Strong", "Explosive");
            granade.Attack = 86;
            additionals[0] = knife; additionals[1] = granade;
            Storage storage = new Storage(armors, weapons, additionals);
        }
        [TestCase]
        public void getWeaponByAttack()
        {

            Assert.AreEqual("Very-Strong", Storage.getWeaponByAttack()[1].Level);
            Assert.AreEqual(36, Storage.getWeaponByAttack()[0].Attack);
            Assert.AreEqual("Sword", Storage.getWeaponByAttack()[0].Name);
            Assert.AreEqual(1046, Storage.getWeaponByAttack()[1].Distance);

        }
        [TestCase]
        public void getArmorByDefence()
        {
            Assert.AreEqual("Armor of Henry II", Storage.getArmorByDefence()[0].Name);
            Assert.AreEqual(300.2, Storage.getArmorByDefence()[1].Price);
            Assert.AreEqual("Rigid", Storage.getArmorByDefence()[0].Type);
            Assert.AreEqual(76, Storage.getArmorByDefence()[1].Defence);

        }

        [TestCase]
        public void getAdditionals()
        {
             Assert.AreEqual("Explosive", Storage.getAdditionals()[1].getType());

            Assert.AreEqual("King Arthur's Knife", Storage.getAdditionals()[0].Name);
            Assert.AreEqual(179.0, Storage.getAdditionals()[1].Price);
            Assert.AreEqual("Very-Weak", Storage.getAdditionals()[0].Level);
            Assert.AreEqual(86, Storage.getAdditionals()[1].Attack);

        }
    }
}
