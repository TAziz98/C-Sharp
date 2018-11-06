using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Store
    {
        public enum Electronics { Computer, WorkPhone, Printer, Scanner }
        public enum Furniture { Table, Chair, Shelf, StandForComputer }
        private Electronics electronic;
        private Furniture furnitur;
        public static List<Furniture> furnituresList;
        public static List<Electronics> electronicsList;

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
        public Store()
        {
            electronicsList=new List<Electronics> {Electronics.Computer,Electronics.Printer,Electronics.Scanner,Electronics.WorkPhone };
            furnituresList=new List<Furniture> {Furniture.Table,Furniture.StandForComputer,Furniture.Shelf,Furniture.Chair };

        }
        public static void orderNewElectronics(Electronics electronicsParam)
        {
            WorkSpace.receiveElectronicsFromStore(electronicsParam);
            electronicsList.Remove(electronicsParam);
            Console.WriteLine("Was bought from Store");
        }
        public static void orderNewFurnitures(Furniture furnitureParam)
        {
            WorkSpace.receiveFurnituresFromStore(furnitureParam);
            furnituresList.Remove(furnitureParam);
          
        }
    }
}
