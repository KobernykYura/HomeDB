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
    public partial class DepartmentAddC : Form
    {
        public DepartmentAddC()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            FormDAdd(textBoxDNmae);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
