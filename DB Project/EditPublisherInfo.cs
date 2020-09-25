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
    public partial class EditPublisherInfo : Form
    {
        Controller controllerObj;
        public EditPublisherInfo()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.EditPublisherInfo(textBox2.Text, (Int32.Parse(textBox3.Text)), textBox1.Text);
            if (result == 0)
            {
                MessageBox.Show("The update has failed");
            }
            else
            {
                MessageBox.Show("The row was updated successfully");
            }
        }
    }
}
