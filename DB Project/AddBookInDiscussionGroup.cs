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
    public partial class AddBookInDiscussionGroup : Form
    {
        Controller controllerObj;
        public AddBookInDiscussionGroup()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddBookInDiscussionGroup(textBox1.Text,textBox2.Text);
            if (r > 0)
                MessageBox.Show("Insertion is successful");
            else
                MessageBox.Show("Insertion failed");
        }
    }
}
