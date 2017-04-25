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
        public void GetSours(DataGridView ee, DataGridView d)
        {
            contrDep = new DepControl();
            contrEmp = new EmpControl();
            ee.DataSource = contrEmp.GetSource();
            d.DataSource = contrDep.GetSource();
        }

        [WebMethod]
        public void GetEmpAdd(DataGridView e)
        {
            //contrEmp.Insert(e.empl);
            //e.Refresh();
        }
        [WebMethod]
        public void GetDepAdd(DataGridView d)
        {
            //contrDep.Insert(d.depar);
            //dataGridDep.Refresh();
        }

        [WebMethod]
        public void GetFormDAdd(TextBox name)
        {
            var depName = name.Text.Trim();

            if (depName == String.Empty)
            {
                MessageBox.Show("Введите название департамента!");
                name.Focus();
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
        public void GetFormELoad(ComboBox comboBoxDepID)
        {
            var deps = new DepControl().GetList();

            // Заполняем список департаментов и привязываем поля
            comboBoxDepID.DataSource = deps;
            comboBoxDepID.DisplayMember = "Name";
            comboBoxDepID.ValueMember = "Id";
        }

        [WebMethod]
        public void GetFormEAdd(TextBox nameE, TextBox ageE, TextBox salaryE , ComboBox comboBoxDepID)
        {
            int age = 0;
            decimal salary = 0;
            // Имя
            var name = nameE.Text.Trim();
            if (name == String.Empty)
            {
                MessageBox.Show("Введите Имя сотрудника!");
                nameE.Focus();
                return;
            }

            // Возраст
            if (!int.TryParse(ageE.Text.Trim(), out age))
            {
                MessageBox.Show("Введите Возраст сотрудника!");
                ageE.Focus();
                return;
            }

            // Зарплата
            if (!decimal.TryParse(salaryE.Text.Trim(), out salary))
            {
                MessageBox.Show("Введите Зарплату сотрудника!");
                salaryE.Focus();
                return;
            }

            // Департамент
            int dep = (int)comboBoxDepID.SelectedValue;

            // Если Сотрудник есть, то обновляем
            if (empl != null)
            {
                empl.Name = name;
                empl.Age = age;
                empl.Salary = salary;
                empl.DepartmentId = dep;
            }
            // Если нет, до добавляем нового
            else
            {
                empl = new Employee { Name = name, Age = age, Salary = salary, DepartmentId = dep };
            }
        }


    }
}
