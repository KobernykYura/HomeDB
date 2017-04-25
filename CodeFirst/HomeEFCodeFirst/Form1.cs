using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using HomeEFCodeFirst.Controls;
using HomeEFCodeFirst.Entitys;
using System.Windows.Forms;

namespace HomeEFCodeFirst
{
    public partial class Form1 : Form
    {
        BaseControl<Employee> contrEmp;
        BaseControl<Department> contrDep;

        public Form1()
        {
            InitializeComponent();
            contrDep = new DepControl();
            contrEmp = new EmpControl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridDep.DataSource = contrDep.GetSource();
            dataGridEmpl.DataSource = contrEmp.GetSource();
        }

        private void addEmp_Click(object sender, EventArgs e)
        {
            EmployeeAdd emplForm = new EmployeeAdd();
            if (emplForm.ShowDialog(this) == DialogResult.OK)
            {
                contrEmp.Insert(emplForm.empl);
                dataGridEmpl.Refresh();
            }
        }

        private void addDep_Click(object sender, EventArgs e)
        {
            DepartmentAdd depForm = new DepartmentAdd();
            if (depForm.ShowDialog(this) == DialogResult.OK)
            {
                contrDep.Insert(depForm.depar);
                dataGridDep.Refresh();
            }
        }

    }
}
