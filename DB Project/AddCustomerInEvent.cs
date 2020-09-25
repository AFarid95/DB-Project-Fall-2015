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
    public partial class AddCustomerInEvent : Form
    {
        Controller controllerObj;
        public AddCustomerInEvent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("fill all textboxes");
            }
            else
            {
                int result = controllerObj.AddCustomerInEvent(int.Parse(textBox1.Text), textBox2.Text);
                if (result == 0)
                {
                    MessageBox.Show("The insertion is failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully");
                }
            }
        }

        private void addinevent_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
    }
}
