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
    public partial class DeleteBook : Form
    {
        Controller controllerObj;
        public DeleteBook()
        {
            InitializeComponent();
            controllerObj=new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = controllerObj.DeleteBook(long.Parse(textBox1.Text));
            if (result == 0)
            {
                MessageBox.Show("Deletion has failed");
            }
            else
            {
                MessageBox.Show("The row was deleted successfully");
            }
        }
    }
}
