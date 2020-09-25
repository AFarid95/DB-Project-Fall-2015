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
    public partial class InsertBook : Form
    {
        Controller controllerObj;
        public InsertBook()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==""||textBox2.Text==""||textBox3.Text==""||textBox4.Text==""
                ||textBox5.Text==""||textBox8.Text==""||textBox9.Text=="")
                MessageBox.Show("Please, insert all required values");
            else
            {
                int result = controllerObj.InsertBook(long.Parse(textBox5.Text), textBox1.Text, textBox2.Text,
                    textBox3.Text, textBox4.Text, textBox6.Text, textBox7.Text, short.Parse(textBox8.Text),
                    float.Parse(textBox9.Text), textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text);
                if (result == 0)
                {
                    MessageBox.Show("Insertion failed");
                }
                else
                {
                    MessageBox.Show("The row was inserted successfully");
                }
            }
        }
    }
}
