using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Select();
            Add();
            Update();
            Remove();
            Console.ReadLine();
        }

        private static void Remove()
        {
            NorthwindEntities db = new NorthwindEntities();
            Employee emp = db.Employees.First(x => x.FirstName == "John" && x.LastName == "Doe");
            db.Employees.Remove(emp);
            db.SaveChanges();
        }

        private static void Update()
        {
            NorthwindEntities db = new NorthwindEntities();
            Employee emp = db.Employees.First(x => x.FirstName == "John" && x.LastName == "Doe");
            emp.FirstName = "John Update";
            emp.LastName = "Doe Update";
            db.SaveChanges();
            Select();
        }

        private static void Add()
        {
            NorthwindEntities db = new NorthwindEntities();
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "John";
            newEmployee.LastName = "Doe";
            db.Employees.Add(newEmployee);
            db.SaveChanges();
            Select();
        }

        private static void Select()
        {
            NorthwindEntities db = new NorthwindEntities();
            var employees = db.Employees.ToList();
            foreach (var emp in employees)
            {
                Console.WriteLine($"ID : {emp.EmployeeID} - Name : {emp.FirstName} " +
                    $"{emp.LastName}");
            }
        }
    }
}
