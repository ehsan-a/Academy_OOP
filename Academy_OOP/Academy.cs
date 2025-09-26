using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy_OOP
{
    internal class Academy
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public List<MainBootCamp> MainBootCamps { get; private set; }
        public Academy(string name, string address, string description)
        {
            MainBootCamps = new List<MainBootCamp>();
            Name = name;
            Address = address;
            Description = description;
        }
        public void GetInfo()
        {
            Console.WriteLine("Academy Name: " + Name);
            Console.WriteLine("Description: " + Description);
            Console.WriteLine("Address: " + Address);
        }
        public void GetMainBootCamp()
        {
            foreach (MainBootCamp item in MainBootCamps)
            {
                Console.WriteLine($"Code[{item.Type}] - {item.Name} => {item.Description} - Available[{item.BootCamps.Count}] ");
            }
        }
        public void GetBootCamp(MainBootCamp mainBootCamp)
        {
            foreach (BootCamp item in mainBootCamp.BootCamps)
            {
                Console.WriteLine($"{mainBootCamp.Name} Code[{item.Type}] Teacher[{item.Employee.LastName}] Class[{item.Room.Name}] Start Date: {item.StartDate} - Students[{item.Students.Count}]");
            }
        }
        public void GetStudent(MainBootCamp mainBootCamp)
        {
            foreach (BootCamp b in mainBootCamp.BootCamps)
            {
                foreach (Student item in b.Students)
                {
                    Console.WriteLine($"BootCamp[{mainBootCamp.Name}] First Name: {item.FirstName} - Last Name: {item.LastName} - ID Number: {item.IdNumber}");
                }
            }
        }
        public void AddMainBootCamp(MainBootCamp mainBootCamp)
        {
            this.MainBootCamps.Add(mainBootCamp);
        }
        public void AddBootCamp(BootCamp bootCamp, MainBootCamp MainBootCamp)
        {
            MainBootCamp.BootCamps.Add(bootCamp);
        }
        public void AddStudent(Student student, BootCamp bootCamp)
        {
            bootCamp.Students.Add(student);
        }
        public void AddEmployee(Employee employee, BootCamp bootCamp)
        {
            bootCamp.Employee = employee;
        }
        public void AddRoom(Room room, BootCamp bootCamp)
        {
            bootCamp.Room = room;
        }
    }
}
