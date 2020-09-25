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
    public partial class AddDistributorAddress : Form
    {
        Controller controllerObj;
        public AddDistributorAddress()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Fill all textboxes");
            }
            else
            {
                int result = controllerObj.AddDistributorAdress(textBox1.Text,int.Parse(textBox2.Text),textBox3.Text,textBox4.Text,textBox5.Text);
                if (result == 0)
                {
                    MessageBox.Show("No rows are updated");
                }
                else
                {
                    MessageBox.Show("The row is updated successfully");
                }
            }
        }

        private void adddistributoraddress_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
    }
}
