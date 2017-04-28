using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WebService.Items;

namespace WebService.DataBase
{
    public class Data : DbContext
    {
        public Data() : base("name=Data")
        {
            //Database.SetInitializer(new StructureContextInitializer());
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }

    class StructureContextInitializer : DropCreateDatabaseIfModelChanges<Data>
    {
        protected override void Seed(Data context)
        {

            context.Departments.AddRange(new List<Department>()
            {
                new Department{ Name = "Отдел IT"},
                new Department{ Name = "Отдел продаж"},
                new Department{ Name = "Отдел рекламы"},
                new Department{ Name = "Канцелярия"},
            });

            context.SaveChanges();

            context.Employees.AddRange(new List<Employee>()
            {
                new Employee{Name = "Александр В", Age = 26, Salary = 45000m, Department = context.Departments.Where(x => x.Id == 1).FirstOrDefault()},
                new Employee{Name = "Игорь Б", Age = 31, Salary = 47000m, Department = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Employee{Name = "Сергей К", Age = 28, Salary = 31000m, Department = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Employee{Name = "Иван П", Age = 23, Salary = 35000m, Department = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Employee{Name = "Алексей Д", Age = 31, Salary = 35000m, Department = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Employee{Name = "Светлана И", Age = 26, Salary = 65000m, Department = context.Departments.Where(x => x.Id == 1).FirstOrDefault()},
                new Employee{Name = "Инна К", Age = 24, Salary = 50000m, Department = context.Departments.Where(x => x.Id == 4).FirstOrDefault()},
                new Employee{Name = "Антон Ж", Age = 29, Salary = 45000m, Department = context.Departments.Where(x => x.Id == 2).FirstOrDefault()},
                new Employee{Name = "Степан С", Age = 28, Salary = 43000m, Department = context.Departments.Where(x => x.Id == 3).FirstOrDefault()},
                new Employee{Name = "Кристина У", Age = 23, Salary = 32000m, Department = context.Departments.Where(x => x.Id == 4).FirstOrDefault()},
            });

            context.SaveChanges();



        }
    }
}