using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeEFCodeFirst.Entitys;
using System.Data.Entity;

namespace HomeEFCodeFirst.Controls
{
    class DepControl : BaseControl<Department>
    {
        public DepControl() : base()
        {
            dbAll.Departments.Load();
            this.source.DataSource = this.dbAll.Departments.Local.ToBindingList();
        }

        public override List<Department> GetList()
        {
            this.dbAll.Departments.Load();
            return this.dbAll.Departments.Local.ToList();
        }

        public override void Insert(Department obj)
        {
            this.dbAll.Departments.Add(obj);
            this.dbAll.SaveChanges();
        }

        public override void Update(Department obj)
        {
            Department dep = this.dbAll.Departments.Find(obj.Id);
            if (dep != null)
            {
                dep = obj;
                this.dbAll.SaveChanges();

                foreach (var entity in dbAll.ChangeTracker.Entries().Where(x => x.Entity == dep))
                {
                    entity.Reload();
                }

            }
        }
    }
}
