﻿using System;
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
    public partial class BooksByAuthor : Form
    {
        Controller controllerObj;
        public BooksByAuthor()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.BooksByAuthor(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }
    }
}
