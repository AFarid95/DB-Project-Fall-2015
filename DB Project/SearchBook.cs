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
    public partial class SearchBook : Form
    {
        Controller controllerObj;
        public SearchBook()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ViewAllBooksThatStartWithACertainString(textBox1.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
