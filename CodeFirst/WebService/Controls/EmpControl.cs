using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using WebService.Items;

namespace WebService.Controls
{
    class EmpControl : BaseControl<Employee>
    {
        public EmpControl() : base()
        {
            this.dbAll.Employees.Include(x => x.Department).Load();
            this.source.DataSource = this.dbAll.Employees.Local.ToBindingList();
        }

        public override List<Employee> GetList()
        {
            this.dbAll.Employees.Include(x => x.Department).Load();
            return this.dbAll.Employees.Local.ToList();
        }

        public override void Insert(Employee obj)
        {
            this.dbAll.Employees.Add(obj);
            this.dbAll.SaveChanges();
        }

        public override void Update(Employee obj)
        {
            Employee empl = this.dbAll.Employees.Find(obj.Id);
            if (empl != null)
            {
                empl = obj;
                this.dbAll.SaveChanges();
            }
            UpdateSource();
        }
    }
}
