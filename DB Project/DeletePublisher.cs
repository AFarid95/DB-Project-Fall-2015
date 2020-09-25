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
    public partial class DeletePublisher : Form
    {
        Controller controllerObj;
        public DeletePublisher()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.DeletePublisher(textBox1.Text);
            if (result == 0)
            {
                MessageBox.Show("The deletion has failed");
            }
            else
            {
                MessageBox.Show("The row was deleted successfully");
            }

        }
    }
}
