using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using FormClient.localhost;
using System.Windows.Forms;

namespace FormClient
{
    public partial class EmployeeAddC : Form
    {
        public Employee empl;
        localhost.WebServiceAccessSoapClient cl;

        public EmployeeAddC()
        {
            InitializeComponent();
            cl = new WebServiceAccessSoapClient();
        }

        private void EmployeeAddC_Load(object sender, EventArgs e)
        {
            
            var deps = cl.GetFormELoad();

            // Заполняем список департаментов и привязываем поля
            comboBox1.DataSource = deps;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBoxName.Text.Trim();
            var age = textBoxAge.Text.Trim();
            var ID = (int)comboBox1.SelectedValue;
            var sal = textBoxSalary.Text.Trim();
            cl.GetFormEAdd(nameE: name, ageE: age, salaryE: sal, comboBoxDepID: ID);

            DialogResult = DialogResult.OK;

            Close();

            //GetFormEAdd(nameE: textBoxName, ageE: textBoxAge, salaryE: textBoxSalary, comboBoxDepID: comboBox1);
            //DialogResult = DialogResult.OK;

            //Close();
        }
    }
}
