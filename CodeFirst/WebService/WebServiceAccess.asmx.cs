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
        public List<Employee> GetSoursEmp()
        {
            contrEmp = new EmpControl();
            return contrEmp.GetList();
        }

        [WebMethod]
        public List<Department> GetSoursDep()
        {
            contrDep = new DepControl();
            return contrDep.GetList();
        }

        [WebMethod]
        public void GetEmpAdd(Employee e)
        {
            contrEmp = new EmpControl();
            contrEmp.Insert(e);
        }
        [WebMethod]
        public void GetDepAdd(Department d)
        {
            contrDep = new DepControl();
            contrDep.Insert(d);
        }

        [WebMethod]
        public Department GetFormDAdd(string depName)
        {
            //depar = new Department();
            if (depName == String.Empty)
            {
                MessageBox.Show("Введите название департамента!");
                //name.Focus();
                return depar;
            }

            // Если Департамент есть, то обновляем его
            if (depar != null)
            {
                depar.Name = depName;
                return depar;
            }
            // Если департамента нет, то добавляем новый
            else
            {
                return depar = new Department { Name = depName };
            }
            
        }

        [WebMethod]
        public List<Department> GetFormELoad()
        {
            var deps = new DepControl().GetList();
            return deps;
        }

        [WebMethod]
        public Employee GetFormEAdd(string nameE, string ageE, string salaryE , int comboBoxDepID)
        {
            int age = 0;
            decimal salary = 0;
            // Имя
            //var name = textBoxName.Text.Trim();
            if (nameE == String.Empty)
            {
                MessageBox.Show("Введите Имя сотрудника!");
                //textBoxName.Focus();
                return empl;
            }

            // Возраст
            if (!int.TryParse(ageE.Trim(), out age))
            {
                MessageBox.Show("Введите Возраст сотрудника!");
                //textBoxAge.Focus();
                return empl;
            }

            // Зарплата
            if (!decimal.TryParse(salaryE.Trim(), out salary))
            {
                MessageBox.Show("Введите Зарплату сотрудника!");
                //textBoxSalary.Focus();
                return empl;
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
                return empl;
            }
            // Если нет, до добавляем нового
            else
            {
                return empl = new Employee { Name = nameE, Age = age, Salary = salary, DepartmentId = dep };
            }
        }


    }
}
