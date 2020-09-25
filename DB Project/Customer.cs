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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "View The Books of An Author":
                    BooksByAuthor f1 = new BooksByAuthor();
                    f1.Show();
                    break;
                case "View The Book Series of An Author":
                    BookSeriesByAuthor f2 = new BookSeriesByAuthor();
                    f2.Show();
                    break;
                case "View The Customers And Books In A Discussion Group":
                    DiscussionGroupInformation f3 = new DiscussionGroupInformation();
                    f3.Show();
                    break;
                case "AddBookInDiscussionGroup":
                    AddBookInDiscussionGroup f4 = new AddBookInDiscussionGroup();
                    f4.Show();
                    break;
                case "Add Customer In Discussion Group":
                    AddCustomerInDiscussionGroup f5 = new AddCustomerInDiscussionGroup();
                    f5.Show();
                    break;
                case "AddDiscussionGroup":
                    AddDiscussionGroup f6 = new AddDiscussionGroup();
                    f6.Show();
                    break;
                case "AddOrder":
                    AddOrder f7 = new AddOrder();
                    f7.Show();
                    break;
                case "Books By Author":
                    BooksByAuthor f8 = new BooksByAuthor();
                    f8.Show();
                    break;
                case "BookSeriesByAuthor":
                    BookSeriesByAuthor f9 = new BookSeriesByAuthor();
                    f9.Show();
                    break;
                case "Delete Discussion Group":
                    DeleteDiscussionGroup f10 = new DeleteDiscussionGroup();
                    f10.Show();
                    break;
                case "View Discussion Group Information":
                    DiscussionGroupInformation f11 = new DiscussionGroupInformation();
                    f11.Show();
                    break;
                case "View Event Information":
                    EventInfo f12 = new EventInfo();
                    f12.Show();
                    break;
                case "Search For Books":
                    SearchBook f13 = new SearchBook();
                    f13.Show();
                    break;
                case "View Books":
                    ViewBooks f14 = new ViewBooks();
                    f14.Show();
                    break;
            }
        }
    }
}