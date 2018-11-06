using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Employee> m = new Dictionary<string, Employee>();
            Store store = new Store();
            WareHouse wareHouse = new WareHouse();
            Employee newHiredEmployee = new Employee("Ikrom", "Ashuraliev", 24, "IT", 5400);
            m.Add(newHiredEmployee.LastName, newHiredEmployee);
            Manager manager = new Manager("Aziz","Tashpulatov",20,"IT",m);
            WorkSpace workSpace = new WorkSpace();
            workSpace.representation();
            manager.fillWithElectronics();
       //     manager.fillWithFurnitures();
            
            Console.WriteLine("--------------");
            WareHouse.representation();
            manager.fireEmployee(newHiredEmployee);
          
            Console.WriteLine("--------------");
            workSpace.representation();
            Console.WriteLine("--------------");
            WorkSpace.releaseEquipments();
            WareHouse.representation();
            Employee newHiredEmployee2 = new Employee("Orif", "Bobohonov", 22, "IT", 5400);
            manager.AddSubordinatesUnderManager(newHiredEmployee2);
            Employee newHiredEmployee3 = new Employee("Mumin", "Salomov", 19, "IT", 4300);
            manager.AddSubordinatesUnderManager(newHiredEmployee3);
            WorkSpace workSpace2 = new WorkSpace(newHiredEmployee2);
               manager.fillWithElectronics();
            WorkSpace workSpace3 = new WorkSpace(newHiredEmployee3);
                manager.fillWithElectronics();
            WareHouse.representation();
        }
    }
}
