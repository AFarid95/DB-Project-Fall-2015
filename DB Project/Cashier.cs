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
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.Text)
            {
                case "Add A New Customer":
                    InsertCustomer f1 = new InsertCustomer();
                    f1.Show();
                    break;
                case "Add A New Book":
                    InsertBook f2 = new InsertBook();
                    f2.Show();
                    break;
                case "Add Books To Order":
                    AddBooksToOrder f3 = new AddBooksToOrder();
                    f3.Show();
                    break;
                case "Add Book To Book Series":
                    AddBookToBookSeries f4 = new AddBookToBookSeries();
                    f4.Show();
                    break;
                case "View Customer And Books In Order":
                    CustomerAndBooksInOrder f5 = new CustomerAndBooksInOrder();
                    f5.Show();
                    break;
                case "Edit Book Info":
                    EditBookInfo f6 = new EditBookInfo();
                    f6.Show();
                    break;
                case "Insert Book":
                    InsertBook f7 = new InsertBook();
                    f7.Show();
                    break;
                case "Insert Customer":
                    InsertCustomer f8 = new InsertCustomer();
                    f8.Show();
                    break;
            }
        }
    }
}