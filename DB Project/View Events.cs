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
    public partial class View_Events : Form
    {
        Controller controllerObj;
        public View_Events()
        {
            InitializeComponent();
            controllerObj=new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = comboBox2.SelectedIndex + 1;
            string Date = comboBox3.Text + "-" + month + "-" + comboBox1.Text;
            DataTable dt = controllerObj.EventsOnDate(Date);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.PastEvents();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.FutureEvents();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.EventsToday();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
