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
    public partial class AddDistributor : Form
    {
        Controller controllerObj;
        public AddDistributor()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.InsertDistributor(NameBox.Text, EmailBox.Text, Int32.Parse(TeleBox.Text));
            if (result == 0)
            {
                MessageBox.Show("The insertion has failed");
            }
            else
            {
                MessageBox.Show("The row was inserted successfully");
            }
        }
    }
}
