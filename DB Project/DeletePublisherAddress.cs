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
    public partial class DeletePublisherAddress : Form
    {
      Controller  controllerObj;
        public DeletePublisherAddress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text==""|| textBox3.Text == "" || textBox4.Text == ""||textBox5.Text=="")
            {
                MessageBox.Show("fill all textboxes");
            }
            else
            {
                int result = controllerObj.DeletePublisherAddress(int.Parse(textBox2.Text), textBox3.Text, textBox5.Text,
                    textBox4.Text, textBox1.Text);
                if (result == 0)
                {
                    MessageBox.Show("The insertion is failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully");
                }
            }
        }

        private void deletepublisheraddress_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
    }
}
