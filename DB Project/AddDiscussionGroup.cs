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
    public partial class AddDiscussionGroup : Form
    {
        Controller ControllerObj;
        public AddDiscussionGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("fill the textbox");
            }
            else
            {
                int result = ControllerObj.AddDiscussionGroup(textBox1.Text);
                if (result == 0)
                {
                    MessageBox.Show("Insertion failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully");
                }
            }
        }

        private void adddiscussiongroup_Load(object sender, EventArgs e)
        {
            ControllerObj = new Controller();
        }
    }
}
