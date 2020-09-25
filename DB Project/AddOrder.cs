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
    public partial class AddOrder : Form
    {
        Controller controllerObj;
        public AddOrder()
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectCustomerIDs();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "CustomerID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddOrder(int.Parse(comboBox1.Text));
            if (r > 0)
                MessageBox.Show("Insertion is successful");
            else
                MessageBox.Show("Insertion failed");
        }
    }
}
