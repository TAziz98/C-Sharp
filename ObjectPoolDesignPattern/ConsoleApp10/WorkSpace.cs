using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class WorkSpace
    {
     public static List<WareHouse.Electronics> ListOfElectronics { get; set;}
     public static List<Store.Electronics> ListOfElectronic { get; set; }
     public static List<WareHouse.Furniture> ListOfFurnitures { get; set; }
     public static List<Store.Furniture> ListOfFurniture { get; set; }
        public Employee employee;
        public WorkSpace()
        {
            ListOfElectronics = new List<WareHouse.Electronics>();
            ListOfElectronic = new List<Store.Electronics>();
            ListOfFurnitures = new List<WareHouse.Furniture>();
            ListOfFurniture = new List<Store.Furniture>();
        }
        public WorkSpace(Employee employee)
        {
            this.employee = employee;
        }

        public static void receiveElectronicsFromWareHouse(WareHouse.Electronics electronics)
        {
            ListOfElectronics.Add(electronics);
        }
        public static void receiveElectronicsFromStore(Store.Electronics electronics)
        {
            ListOfElectronic.Add(electronics);
        }
        public static void receiveFurnituresFromWareHouse(WareHouse.Furniture furnitures)
        {
            ListOfFurnitures.Add(furnitures);
        }
        public static void receiveFurnituresFromStore(Store.Furniture furnitures)
        {
            ListOfFurniture.Add(furnitures);
        }
        public static void releaseEquipments()
        {

            WareHouse.receiveElectronicsBack(ListOfElectronics, ListOfElectronic);
            WareHouse.receiveFurnituresBack(ListOfFurnitures, ListOfFurniture);
            ListOfElectronics.Clear();
            Console.WriteLine("Work Space destructed");

        }
        public void representation()
        {
            Console.WriteLine("Electronics were delivered to Work Space :");
            foreach(WareHouse.Electronics list in ListOfElectronics)
            Console.WriteLine(list);
            foreach (Store.Electronics list in ListOfElectronic)
                Console.WriteLine(list);
            Console.WriteLine("Furnitures were delivered to Work Space :");
            foreach (WareHouse.Furniture list in ListOfFurnitures)
                Console.WriteLine(list);
            foreach (Store.Furniture list in ListOfFurniture)
                Console.WriteLine(list);
           
        }
    }
}
