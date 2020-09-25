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
    public partial class AddBookToBookSeries : Form
    {
        Controller controllerObj;
        public AddBookToBookSeries()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.SelectBookNames();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "Name";
            DataTable dt2 = controllerObj.SelectBookSeries();
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "Name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddBookToBookSeries(comboBox1.Text, comboBox2.Text);
            if (r > 0)
                MessageBox.Show("Insertion is successful");
            else
                MessageBox.Show("Insertion failed");
        }
    }
}
