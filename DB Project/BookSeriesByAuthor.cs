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
    public partial class BookSeriesByAuthor : Form
    {
        Controller controllerObj;
        public BookSeriesByAuthor()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.BookSeriesByAuthor(textBox2.Text, Char.Parse(textBox3.Text), textBox4.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void BookSeriesByAuthor_Load(object sender, EventArgs e)
        {
            
        }
    }
}
