using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeDB2.Content;
using System.Windows.Forms;
using System.Data.Entity;

namespace HomeDB2.Controller
{
    class ControllerForm1
    {
        CommonDB dbContent;
        public ControllerForm1()
        {
            this.dbContent = new CommonDB();
        }
        public IList<Employee> GetEmployee()
        {
            dbContent.Employees.Include(x => x.ID).Load();
            return dbContent.Employees.Local.ToBindingList();
        }
        public IList<Department> GetDepartment()
        {
            dbContent.Departments.Include(x => x.ID).Load();
            return dbContent.Departments.Local.ToBindingList();
        }
        public void Add()
        {

        }
        public void Delete()
        {

        }
        public void DeleteAll()
        {

        }
    }
}
