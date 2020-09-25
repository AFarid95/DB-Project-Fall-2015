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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "View Books Distributed By A Distributor":
                    BooksDistributed f1 = new BooksDistributed();
                    f1.Show();
                    break;
                case "View The Attendants of An Event":
                    EventInfo f2 = new EventInfo();
                    f2.Show();
                    break;
                case "View Bookstore Statistics":
                    Statistics f3 = new Statistics();
                    f3.Show();
                    break;
                case "Add Author In Event":
                    AddAuthorInEvent f4 = new AddAuthorInEvent();
                    f4.Show();
                    break;
                case "Add Customer In Event":
                    AddCustomerInEvent f5 = new AddCustomerInEvent();
                    f5.Show();
                    break;
                case "Add Distributor":
                    AddDistributor f6 = new AddDistributor();
                    f6.Show();
                    break;
                case "Add Distributor Address":
                    AddDistributorAddress f7 = new AddDistributorAddress();
                    f7.Show();
                    break;
                case "Add Event":
                    AddEvent f8 = new AddEvent();
                    f8.Show();
                    break;
                case "Add Publisher":
                    AddPublisher f9 = new AddPublisher();
                    f9.Show();
                    break;
                case "Add Publisher Address":
                    AddPublisherAddress f10 = new AddPublisherAddress();
                    f10.Show();
                    break;
                case "Add Section":
                    AddSection f11 = new AddSection();
                    f11.Show();
                    break;
                case "Books Distributed":
                    BooksDistributed f12 = new BooksDistributed();
                    f12.Show();
                    break;
                case "Delete Book":
                    DeleteBook f13 = new DeleteBook();
                    f13.Show();
                    break;
                case "Delete Book Series":
                    DeleteBookSeries f14 = new DeleteBookSeries();
                    f14.Show();
                    break;
                case "DeleteDistributor":
                    DeleteDistributor f15 = new DeleteDistributor();
                    f15.Show();
                    break;
                case "Delete Distributor Address":
                    DeleteDistributorAddress f16 = new DeleteDistributorAddress();
                    f16.Show();
                    break;
                case "Delete Publisher":
                    DeletePublisher f17 = new DeletePublisher();
                    f17.Show();
                    break;
                case "Delete Publisher Address":
                    DeletePublisherAddress f18 = new DeletePublisherAddress();
                    f18.Show();
                    break;
                case "Delete Section":
                    DeleteSection f19 = new DeleteSection();
                    f19.Show();
                    break;
                case "Edit Author Information":
                    EditAuthorInfo f20 = new EditAuthorInfo();
                    f20.Show();
                    break;
                case "Edit Distributor Information":
                    EditDistributorInfo f21 = new EditDistributorInfo();
                    f21.Show();
                    break;
                case "Edit Publisher Information":
                    EditPublisherInfo f22 = new EditPublisherInfo();
                    f22.Show();
                    break;
                case "View Events":
                    View_Events f23 = new View_Events();
                    f23.Show();
                    break;
                case "View Distributor Addresses":
                    ViewDistributorAddress f24 = new ViewDistributorAddress();
                    f24.Show();
                    break;
                case "View Distributors And Their Contact Info":
                    ViewDistributorsAndTheirContactInfo f25 = new ViewDistributorsAndTheirContactInfo();
                    f25.Show();
                    break;
                case "View Publisher Addresses":
                    ViewPublisherAddress f26 = new ViewPublisherAddress();
                    f26.Show();
                    break;
                case "View Publishers And Their Contact Info":
                    ViewPublishersAndTheirContactInfo f27 = new ViewPublishersAndTheirContactInfo();
                    f27.Show();
                    break;
            }
        }
    }
}
//View Books Distributed By A Distributor
//View The Attendants of An Event
//View Bookstore Statistics