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
    public partial class Statistics : Form
    {
        Controller controllerObj;
        public Statistics()
        {
            InitializeComponent();
            controllerObj = new Controller();
            textBox1.Text = controllerObj.Counting().ToString();
            textBox2.Text = controllerObj.CalcMaxPrice().ToString();
            textBox3.Text = controllerObj.AverageBooksPrice().ToString();
            textBox4.Text = controllerObj.CalcAvgAgeOfCust().ToString();
        }
    }
}
