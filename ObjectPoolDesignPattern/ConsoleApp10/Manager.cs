using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Manager : Person

    {
        private Dictionary<String, Employee> subordinates { get; set; }
        public Manager(string name, string lastname, int age, string Qualification, Dictionary<String, Employee> subordinates) : base(name, lastname, age, Qualification)
        {
            this.subordinates = subordinates;
        }

        public void AddSubordinatesUnderManager(Employee employee)
        {
            subordinates.Add(employee.LastName, employee);
        }
        public void fillWithElectronics()
        {
            //will search for shorter way of Implemenataion
            WareHouse wareHouse = new WareHouse();
            var enumSize = WareHouse.electronicsList.Count();
            int j = 0;
            while (j < WareHouse.electronicsList.Count())
            {
                if (WareHouse.Electronics.WorkPhone == WareHouse.electronicsList[j])
                {
                    WareHouse.deliverElectronics(WareHouse.electronicsList[j]);
                    break;
                    
                }
                j++;
            }
            if (enumSize == WareHouse.electronicsList.Count())
            {
                Store.orderNewElectronics(Store.Electronics.WorkPhone);
            }

            //--------------------------------------
            int i = 0;
            var enumSize2 = WareHouse.electronicsList.Count();
            while (i < WareHouse.electronicsList.Count())
            {
                if (WareHouse.Electronics.Computer == WareHouse.electronicsList[i]) { 
                    WareHouse.deliverElectronics(WareHouse.electronicsList[i]);
                break; }
                i++;
             
            }
            if (enumSize2 == WareHouse.electronicsList.Count())
            {
                Store.orderNewElectronics(Store.Electronics.Computer);
            }
            //---------------------------------------
            int c = 0;
            var enumSize3 = WareHouse.electronicsList.Count();
            while (c < WareHouse.electronicsList.Count())
            {
                if (WareHouse.Electronics.Printer == WareHouse.electronicsList[c])
                {
                    WareHouse.deliverElectronics(WareHouse.electronicsList[c]);
                    break;
                }
                c++;
               
            }
            if (enumSize3 == WareHouse.electronicsList.Count())
            {
                Store.orderNewElectronics(Store.Electronics.Printer);
            }
            //--------------------------------------
            int d = 0;
            var enumSize4 = WareHouse.electronicsList.Count();
            while (d < WareHouse.electronicsList.Count())
            {
                if (WareHouse.Electronics.Scanner == WareHouse.electronicsList[d])
                {
                    WareHouse.deliverElectronics(WareHouse.electronicsList[d]);
                    break;
                }
                d++;
                
            }
            if (enumSize4 == WareHouse.electronicsList.Count())
            {
                Store.orderNewElectronics(Store.Electronics.Scanner);
            }
            var enumSize5 = WareHouse.furnituresList.Count();

            //    for(int j=0; j < WareHouse.furnituresList.Count();j++)
            int k = 0;
            while (k < WareHouse.furnituresList.Count())
            {
                if (WareHouse.Furniture.Table == WareHouse.furnituresList[k])
                {
                    WareHouse.deliverFurniture(WareHouse.furnituresList[k]);
                    break;
                }
                k++;
            }
            if (enumSize5 == WareHouse.furnituresList.Count())
            {
                Store.orderNewFurnitures(Store.Furniture.Table);
            }
            var enumSize6 = WareHouse.furnituresList.Count();
            for (int l = 0; l < WareHouse.furnituresList.Count(); l++)
            {
                if (WareHouse.Furniture.Chair == WareHouse.furnituresList[l])
                {
                    WareHouse.deliverFurniture(WareHouse.furnituresList[l]);
                    break;
                }
            }

            if (enumSize6 == WareHouse.furnituresList.Count())
            {
                Store.orderNewFurnitures(Store.Furniture.Chair);
            }
            int m= 0;
            var enumSize7 = WareHouse.furnituresList.Count();
            while (m < WareHouse.furnituresList.Count())
            {
                if (WareHouse.Furniture.Shelf == WareHouse.furnituresList[m])
                {
                    WareHouse.deliverFurniture(WareHouse.furnituresList[m]);

                    break;
                }

                m++;

            }

            if (enumSize7 == WareHouse.furnituresList.Count())
            {
                Store.orderNewFurnitures(Store.Furniture.Shelf);
            }

            int n = 0;
            var enumSize8 = WareHouse.furnituresList.Count();
            while (n < WareHouse.furnituresList.Count())
            {
                if (WareHouse.Furniture.StandForComputer == WareHouse.furnituresList[n])
                {
                    WareHouse.deliverFurniture(WareHouse.furnituresList[n]);
                    break;
                }

                n++;

            }

            if (enumSize8 == WareHouse.furnituresList.Count())
            {
                Store.orderNewFurnitures(Store.Furniture.StandForComputer);
            }
        }

       public void fireEmployee(Employee employee)
        {
            subordinates.Remove(employee.LastName);
        }
    
    }
    }

