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
    public partial class AddBooksToOrder : Form
    {
        Controller controllerObj;
        public AddBooksToOrder()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt1 = controllerObj.SelectCustomerIDs();
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "CustomerID";
            DataTable dt3 = controllerObj.SelectBookNames();
            comboBox3.DataSource = dt3;
            comboBox3.DisplayMember = "Name";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt2 = controllerObj.OrdersByCustomer(int.Parse(comboBox1.Text));
            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "OrderID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddBookToOrder(comboBox3.Text, Int16.Parse(comboBox2.Text));
            if (r > 0)
                MessageBox.Show("Insertion Successful");
            else
                MessageBox.Show("Insertion Failed");
            //hanzawed 7etet abdelmegid bta3et el orders
        }
    }
}
