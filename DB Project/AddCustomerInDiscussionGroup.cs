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
    public partial class AddCustomerInDiscussionGroup : Form
    {
        Controller controllerObj;
        public AddCustomerInDiscussionGroup()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.AddCustomerInDiscussionGroup(Int32.Parse(textBox1.Text),textBox2.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion has failed");
            }
            else
            {
                MessageBox.Show("Customer was inserted in Discussion Group");
            }

        }
    }
}
