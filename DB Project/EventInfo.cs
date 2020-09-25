using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class EventInfo : Form
    {
        Controller controllerObj;
        public EventInfo()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.CustomersInEvent(textBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dt = controllerObj.AuthorsInEvent(textBox1.Text);
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }
    }
}
