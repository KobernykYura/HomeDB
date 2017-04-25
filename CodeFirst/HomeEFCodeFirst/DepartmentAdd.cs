using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using HomeEFCodeFirst.Entitys;
using System.Windows.Forms;

namespace HomeEFCodeFirst
{
    public partial class DepartmentAdd : Form
    {
        public Department depar;

        public DepartmentAdd()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
          var depName = textBoxName.Text.Trim();
          var depID = textBoxID.Text.Trim();

            if (depName == String.Empty)
            {
                MessageBox.Show("Введите название департамента!");
                textBoxName.Focus();
                return;
            }
            if (depID == String.Empty)
            {
                MessageBox.Show("Введите ID департамента!");
                textBoxName.Focus();
                return;
            }

            // Если Департамент есть, то обновляем его
            if (depar != null)
            {
                int dep = Convert.ToInt32(depID);
                depar.Name = depName;
                depar.Id = dep;
            }
            // Если департамента нет, то добавляем новый
            else
            {
                depar = new Department{ Name = depName };
            }

            DialogResult = DialogResult.OK;

            Close();
        }

        private void DepartmentAdd_Load(object sender, EventArgs e)
        {
            
        }
    }
}
