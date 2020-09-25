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
    public partial class DeleteDistributor : Form
    {
        Controller controllerObj;
        public DeleteDistributor()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.DeleteDistributor(textBox1.Text);
            if (r > 0)
                MessageBox.Show("Deletion is successful");
            else
                MessageBox.Show("Deletion failed");
        }
    }
}
