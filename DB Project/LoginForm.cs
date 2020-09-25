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
    public partial class LoginForm : Form
    {
        Controller controllerObj;
        public LoginForm()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Please insert both username and password");
            else
            {
                int UserType = controllerObj.UserLogin(textBox1.Text, textBox2.Text);
                switch(UserType)
                {
                    case 0:
                        MessageBox.Show("Username and/or password is incorrect. Try again");
                        break;
                    case 1:
                        Customer f1 = new Customer();
                        f1.Show();
                        break;
                    case 2:
                        Cashier f2 = new Cashier();
                        f2.Show();
                        break;
                    case 3:
                        Manager f3 = new Manager();
                        f3.Show();
                        break;
                }
            }
        }
    }
}
