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
    public partial class AddEvent : Form
    {
        Controller controllerObj;
        public AddEvent()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = controllerObj.AddEvent(textBox1.Text,
                comboBox3.Text + '-' + comboBox2.Text + '-' + comboBox1.Text,
                comboBox4.Text + ':' + comboBox5.Text + ':' + comboBox6.Text,
                comboBox7.Text + ':' + comboBox8.Text + ':' + comboBox9.Text);
            if (r > 0)
                MessageBox.Show("Insertion is successful");
            else
                MessageBox.Show("Insertion failed");
        }
    }
}
