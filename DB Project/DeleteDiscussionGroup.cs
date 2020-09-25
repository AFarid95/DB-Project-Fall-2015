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
    public partial class DeleteDiscussionGroup : Form
    {
        Controller ControllerObj;
        public DeleteDiscussionGroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("fill the textbox");
            }
            else
            {
                int result = ControllerObj.DeleteDiscussionGroup(textBox1.Text);
                if (result == 0)
                {
                    MessageBox.Show("The insertion  failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully");
                }
            }
        }

        private void deletediscussiongroup_Load(object sender, EventArgs e)
        {
            ControllerObj = new Controller();
        }
    }
}
