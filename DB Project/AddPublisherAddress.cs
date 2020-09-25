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
    public partial class AddPublisherAddress : Form
    {
        Controller controllerObj;
        public AddPublisherAddress()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Fill all textboxes");
            }
            else
            {
                int r = controllerObj.AddPublisherAddress(textBox1.Text, Int16.Parse(textBox2.Text), textBox3.Text,
                    textBox4.Text, textBox5.Text);
                if (r > 0)
                    MessageBox.Show("Insertion is successful");
                else
                    MessageBox.Show("Insertion failed");
            }
        }
    }
}
