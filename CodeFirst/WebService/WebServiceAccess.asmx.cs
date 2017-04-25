using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Web.Services;
using WebService.Controls;
using WebService.Items;

namespace WebService
{
    /// <summary>
    /// Сводное описание для WebServiceAccess
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAccess : System.Web.Services.WebService
    {
        BaseControl<Employee> contrEmp;
        BaseControl<Department> contrDep;
        public Department depar;
        public Employee empl;

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }

        [WebMethod]
        public BindingSource GetSoursEmp()
        {
            contrEmp = new EmpControl();
            return contrEmp.GetSource();
        }

        [WebMethod]
        public BindingSource GetSoursDep()
        {
            contrDep = new DepControl();
            return contrDep.GetSource();
        }

        [WebMethod]
        public void GetEmpAdd(Employee e)
        {
            contrEmp.Insert(e);
        }
        [WebMethod]
        public void GetDepAdd(Department d)
        {
            contrDep.Insert(d);
        }

        [WebMethod]
        public void GetFormDAdd(string depName)
        {
            if (depName == String.Empty)
            {
                MessageBox.Show("Введите название департамента!");
                //name.Focus();
                return;
            }

            // Если Департамент есть, то обновляем его
            if (depar != null)
            {
                depar.Name = depName;
            }
            // Если департамента нет, то добавляем новый
            else
            {
                depar = new Department { Name = depName };
            }
            
        }

        [WebMethod]
        public List<Department> GetFormELoad()
        {
            var deps = new DepControl().GetList();
            return deps;
        }

        [WebMethod]
        public void GetFormEAdd(string nameE, string ageE, string salaryE , int comboBoxDepID)
        {
            int age = 0;
            decimal salary = 0;
            // Имя
            //var name = textBoxName.Text.Trim();
            if (nameE == String.Empty)
            {
                MessageBox.Show("Введите Имя сотрудника!");
                //textBoxName.Focus();
                return;
            }

            // Возраст
            if (!int.TryParse(ageE.Trim(), out age))
            {
                MessageBox.Show("Введите Возраст сотрудника!");
                //textBoxAge.Focus();
                return;
            }

            // Зарплата
            if (!decimal.TryParse(salaryE.Trim(), out salary))
            {
                MessageBox.Show("Введите Зарплату сотрудника!");
                //textBoxSalary.Focus();
                return;
            }

            // Департамент
            int dep = comboBoxDepID;

            // Если Сотрудник есть, то обновляем
            if (empl != null)
            {
                empl.Name = nameE;
                empl.Age = age;
                empl.Salary = salary;
                empl.DepartmentId = dep;
            }
            // Если нет, до добавляем нового
            else
            {
                empl = new Employee { Name = nameE, Age = age, Salary = salary, DepartmentId = dep };
            }
        }


    }
}
