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
    public partial class InsertCustomer : Form
    {
        Controller controllerObj;
        public InsertCustomer()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertCustomer(textBox1.Text, Int16.Parse(textBox2.Text), textBox3.Text, textBox4.Text);
            if (result == 0)
            {
                MessageBox.Show("Insertion failed");
            }
            else
            {
                MessageBox.Show("The row was inserted successfully");
            }
        }
    }
}
