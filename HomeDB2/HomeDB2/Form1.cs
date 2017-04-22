using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeDB2.Controller;
using HomeDB2.Content;

namespace HomeDB2
{
    public partial class Form1 : Form
    {
        ControllerForm1 controlApp;
        public Form1()
        {
            InitializeComponent();
            controlApp = new ControllerForm1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controlApp.GetEmployee();
            dataGridView2.DataSource = controlApp.GetDepartment();
        }
    }
}
