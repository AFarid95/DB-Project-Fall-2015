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
    public partial class EditBookInfo : Form
    {
        Controller controllerObj;
        public EditBookInfo()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r=controllerObj.EditBookInfo(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text,textBox5.Text,
                textBox6.Text,textBox7.Text,textBox8.Text);
            if (r > 0)
                MessageBox.Show("Edit is successful");
            else
                MessageBox.Show("Edit failed");
        }

    }
}
