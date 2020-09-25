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
    public partial class AddAuthorInEvent : Form
    {
        Controller controllerObj;
        public AddAuthorInEvent()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.AddAuthorInEvent(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            if (result == 0)
            {
                MessageBox.Show("The insertion has failed");
            }
            else
            {
                MessageBox.Show("Author was added in event");
            }
        }
    }
}
