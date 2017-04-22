namespace HomeDB2.Content
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;

    public class CommonDB : DbContext
    {

        public CommonDB()
            : base("name=CommonDB")
        {
            Database.SetInitializer(new DBIntializer());
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }

    public class DBIntializer : DropCreateDatabaseAlways<CommonDB>
    {
        protected override void Seed(CommonDB context)
        {
            context.Departments.AddRange(new List<Department>
            {
                new Department {  NameDep = "Root", ID = 1 },
                new Department {  NameDep = "Press", ID = 2 },
                new Department {  NameDep = "User", ID = 3 }
            });

            context.SaveChanges();

            context.Employees.AddRange(new List<Employee>
            {
                new Employee { NameEmp = "Simon", ID = 1, Salary = 100},
                new Employee { NameEmp = "Bart", ID = 2, Salary = 200},
                new Employee { NameEmp = "Liza", ID = 2, Salary = 200},
                new Employee { NameEmp = "Nick", ID = 2, Salary = 200},
                new Employee { NameEmp = "Lois 3", ID = 3, Salary = 300}
            });

            context.SaveChanges();

        }
    }
}