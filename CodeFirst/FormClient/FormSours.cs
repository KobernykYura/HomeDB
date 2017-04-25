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
            cl.GetSours(ee: dataGridEmployee, d: dataGridDepartments);
        }

        private void Add_employee_Click(object sender, EventArgs e)
        {
            EmployeeAddC emplForm = new EmployeeAddC();
            if (emplForm.ShowDialog(this) == DialogResult.OK)
            {
                EmpAdd(dataGridEmployee);
                //contrEmp.Insert(emplForm.empl);
                //dataGridEmpl.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepartmentAddC depForm = new DepartmentAddC();
            if (depForm.ShowDialog(this) == DialogResult.OK)
            {
                DepAdd(dataGridDepartments);
                //contrDep.Insert(depForm.depar);
                //dataGridDep.Refresh();
            }
        }
    }
}
