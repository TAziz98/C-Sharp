using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramApp
{
    public enum Option { NewGame, LoadGame, Player, Level };

    class Level
    {
    
        private Mapa map;
        private List<Enemy> enemies;
        private ShopArea shop_area;

        public Mapa Map
        {
            get
            {
                return map;
            }
            set
            {
                map = value;
            }
        }

        public List<Enemy> Enemies
        {
            get
            {
                return enemies;
            }
            set
            {
                enemies = value;
            }
        }

        public ShopArea ShopArea
        {
            get
            {
                return shop_area;
            }
            set
            {
                shop_area= value;
            }
        }


        public void Reload()
        {

        }

        public void setEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void setShop()
        {


        }
    }
}
