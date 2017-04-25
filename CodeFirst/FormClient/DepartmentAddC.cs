using System;
using FormClient.localhost;
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
        public Department depar;
        localhost.WebServiceAccessSoapClient cl;

        public DepartmentAddC()
        {
            InitializeComponent();
            cl = new WebServiceAccessSoapClient();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var depName = textBoxDNmae.Text.Trim();
            cl.GetFormDAdd(depName);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
