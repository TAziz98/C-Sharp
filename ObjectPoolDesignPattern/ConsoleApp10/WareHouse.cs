using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class WareHouse
    {
        public enum Electronics { Computer, WorkPhone, Printer, Scanner }
        public enum Furniture { Table, Chair, Shelf, StandForComputer }
        private Electronics electronic;
        private Furniture furnitur;
        public static List<Furniture> furnituresList { get; set; }
        public static List<Electronics> electronicsList { get; set; }


        public Electronics Electronic
        {
            get
            {
                return electronic;
            }
            set
            {
                electronic = value;
            }
        }
        public Furniture furniture
        {
            get
            {
                return furnitur;
            }
            set
            {
                furnitur = value;
            }
        }
        public WareHouse()
        {
            electronicsList = new List<Electronics> { Electronics.Computer,Electronics.Computer,Electronics.Computer, Electronics.Printer };
            furnituresList = new List<Furniture> { Furniture.Table, Furniture.StandForComputer,Furniture.Chair ,Furniture.Chair,Furniture.Table};

        }

        public static void deliverElectronics(Electronics electronicsParam)
        {
                WorkSpace.receiveElectronicsFromWareHouse(electronicsParam);
            electronicsList.Remove(electronicsParam);
            Console.WriteLine("Was taken from WareHouse");
        }
        public static void deliverFurniture(Furniture furnitureParam)
        {
            WorkSpace.receiveFurnituresFromWareHouse(furnitureParam);
           furnituresList.Remove(furnitureParam);

          
        }
        public static void receiveElectronicsBack(List<Electronics> electronics, List<Store.Electronics> electronic)
        {
            foreach (Electronics electro in electronics)
                electronicsList.Add(electro);

            foreach (Electronics electron in electronic)
                electronicsList.Add(electron);
        }
        public static void receiveFurnituresBack(List<Furniture> furnitures, List<Store.Furniture> furniture)
        {
            foreach (Furniture furnitur in furnitures)
                furnituresList.Add(furnitur);

            foreach (Furniture furnit in furniture)
                furnituresList.Add(furnit);
        }
        public static void representation()
        {
            Console.WriteLine("YYYY");
            foreach (WareHouse.Electronics list in electronicsList)
                Console.WriteLine(list);
            foreach (WareHouse.Furniture list in furnituresList)
                Console.WriteLine(list);

        }
    }
}
