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
    public partial class AddPublisher : Form
    {
        Controller controllerObj;
        public AddPublisher()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||textBox3.Text==""|| textBox2.Text == "" )
            {
                MessageBox.Show("fill all textboxes");
            }
            else
            {
                int result = controllerObj.AddPublisher(textBox1.Text, int.Parse(textBox3.Text), textBox2.Text);
                if (result == 0)
                {
                    MessageBox.Show("Insertion has failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully");
                }
            }
        }
    }
}
