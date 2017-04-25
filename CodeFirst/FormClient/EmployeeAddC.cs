using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClient
{
    public partial class EmployeeAddC : Form
    {
        public EmployeeAddC()
        {
            InitializeComponent();
        }

        private void EmployeeAddC_Load(object sender, EventArgs e)
        {
            GetFormELoad(comboBoxDepID: comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetFormEAdd(nameE: textBoxName, ageE: textBoxAge, salaryE: textBoxSalary, comboBoxDepID: comboBox1);
            DialogResult = DialogResult.OK;

            Close();
        }
    }
}
