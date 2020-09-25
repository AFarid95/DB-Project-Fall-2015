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
    public partial class ViewBooks : Form
    {
        Controller controllerObj;
        public ViewBooks()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int att, ordering;
            if (radioButton1.Checked)
                att = 0;
            else if (radioButton2.Checked)
                att = 1;
            else if (radioButton3.Checked)
                att = 2;
            else
                att = 3;
            if (radioButton5.Checked)
                ordering = 0;
            else
                ordering = 1;
            DataTable dt = controllerObj.ViewBooksOrdered(att,ordering);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
