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
    public partial class EditDistributorInfo : Form
    {
        Controller controllerObj;
        public EditDistributorInfo()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.EditDistributorInfo(textBox1.Text,textBox2.Text,textBox3.Text);
            if (r > 0)
                MessageBox.Show("Edit is successful");
            else
                MessageBox.Show("Edit failed");
        }
    }
}
