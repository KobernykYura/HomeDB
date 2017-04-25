using HomeEFCodeFirst.Entitys;
using HomeEFCodeFirst.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeEFCodeFirst
{
    public partial class EmployeeAdd : Form
    {
        public Employee empl;

        public EmployeeAdd()
        {
            InitializeComponent();
        }

        private void EmployeeAdd_Load(object sender, EventArgs e)
        {
            var deps = new DepControl().GetList();

            // Заполняем список департаментов и привязываем поля
            comboBoxDepID.DataSource = deps;
            comboBoxDepID.DisplayMember = "Name";
            comboBoxDepID.ValueMember = "Id";
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int age = 0;
            decimal salary = 0;
            // Имя
            var name = textBoxName.Text.Trim();
            if (name == String.Empty)
            {
                MessageBox.Show("Введите Имя сотрудника!");
                textBoxName.Focus();
                return;
            }

            // Возраст
            if (!int.TryParse(textBoxAge.Text.Trim(), out age))
            {
                MessageBox.Show("Введите Возраст сотрудника!");
                textBoxAge.Focus();
                return;
            }

            // Зарплата
            if (!decimal.TryParse(textBoxSalary.Text.Trim(), out salary))
            {
                MessageBox.Show("Введите Зарплату сотрудника!");
                textBoxSalary.Focus();
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

            DialogResult = DialogResult.OK;
            
            Close();
        }

        
    }
}
