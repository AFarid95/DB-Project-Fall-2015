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
    public partial class CustomerAndBooksInOrder : Form
    {
        Controller controllerObj;
        public CustomerAndBooksInOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.CustomerInOrder(int.Parse(textBox1.Text));
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dt = controllerObj.BooksInOrder(int.Parse(textBox1.Text));
            dataGridView2.DataSource = dt;
            dataGridView2.Refresh();
        }

        private void getcustomersandbooksinorder_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
    }
}
