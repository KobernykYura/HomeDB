using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using FormClient.localhost;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClient
{
    public partial class FormSours : Form
    {
        localhost.WebServiceAccessSoapClient cl;
        public FormSours()
        {
            InitializeComponent();
            cl = new WebServiceAccessSoapClient();
        }

        private void FormSours_Load(object sender, EventArgs e)
        {
            dataGridEmployee.DataSource = cl.GetSoursEmp();
            dataGridDepartments.DataSource = cl.GetSoursDep();
        }

        private void Add_employee_Click(object sender, EventArgs e)
        {
            EmployeeAddC emplForm = new EmployeeAddC();
            if (emplForm.ShowDialog(this) == DialogResult.OK)
            {
                cl.GetEmpAdd(emplForm.empl);
                dataGridEmployee.Refresh();
            }
            dataGridEmployee.DataSource = cl.GetSoursEmp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartmentAddC depForm = new DepartmentAddC();
            if (depForm.ShowDialog(this) == DialogResult.OK)
            {
                cl.GetDepAdd(depForm.depar);
                dataGridDepartments.Refresh();
            }
            dataGridDepartments.DataSource = cl.GetSoursDep();
        }
    }
}
