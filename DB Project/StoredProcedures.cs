using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DB_Project
{
    class StoredProcedures
    {
        public static string SelectBookNames = "SelectBookNames";
        public static string SelectBookSeries = "SelectBookSeries";
        public static string SelectCustomerIDs = "SelectCustomerIDs";
        public static string InsertBook = "InsertBook";
        public static string InsertCustomer = "InsertCustomer";
        public static string BooksByAuthor = "BooksByAuthor";
        public static string BooksDistributed = "BooksDistributed";
        public static string DiscussionGroupInfo = "DiscussionGroupInfo";
        public static string CustomersAndAuthorsInEvent = "CustomersAndAuthorsInEvent";
        public static string BookSeriesByAuthor = "BookSeriesByAuthor";
        public static string CustomersInDiscussionGroup = "CustomersInDiscussionGroup";
        public static string BooksInDiscussionGroup = "BooksInDiscussionGroup";
        public static string CustomersInEvent = "CustomersInEvent";
        public static string AuthorsInEvent = "AuthorsInEvent";
        public static string UserLogin = "UserLogin";
        public static string AddBookToBookSeries = "AddBookToBookSeries";
        public static string AddOrder = "AddOrder";
        public static string AddBookToOrder = "AddBookToOrder";
        public static string OrdersByCustomer = "OrdersByCustomer";
        public static string EventsOnDate = "EventsOnDate";
        public static string PastEvents = "PastEvents";
        public static string FutureEvents = "FutureEvents";
        public static string EventsToday = "EventsToday";
        public static string ViewBooksOrdered = "ViewBooksOrdered";
        public static string AddPublisherAddress= "AddPublisherAddress";
        public static string ViewDistributorAddresses="ViewDistributorAddresses";
        public static string AddSection="AddSection";
        public static string AddBookInDiscussionGroup="AddBookInDiscussionGroup";
        public static string EditDistributorInfo="EditDistributorInfo";
        public static string EditBookInfo="EditBookInfo";
        public static string DeleteDistributor="DeleteDistributor";
        public static string DeleteSection = "DeleteSection";
        public static string AddDistributor = "AddDistributor";
        public static string ViewPublisherAddress = "ViewPublisherAddress";
        public static string ViewDistributorsAndTheirContactInfo = "ViewDistributorsAndTheirContactInfo";
        public static string AddEvent = "AddEvent";
        public static string AddCustomerInDiscussionGroup = "AddCustomerInDiscussionGroup";
        public static string AddAuthorInEvent = "AddAuthorInEvent";
        public static string EditPublisherInfo = "EditPublisherInfo";
        public static string DeletePublisher = "DeletePublisher";
        public static string DeleteBookSeries = "DeleteBookSeries";
        public static string ViewAllBooksThatStartWithACertainString = "ViewAllBooksThatStartWithACertainString";
        public static string EditAuthorInfo = "EditAuthorInfo";
        public static string AddCustomerInEvent = "AddCustomerInEvent";
        public static string CustomerAndBooksInOrder = "CustomerAndBooksInOrder";
        public static string CustomerInOrder = "CustomerInOrder";
        public static string BooksInOrder = "BooksInOrder";
        public static string DeletePublisherAddress = "DeletePublisherAddress";
        public static string DeleteDiscussionGroup = "DeleteDiscussionGroup";
        public static string AddPublisher = "AddPublisher";
        public static string AddDistributorAdress = "AddDistributorAdress";
        public static string AddDiscussionGroup = "AddDiscussionGroup";
        public static string ViewPublishersAndTheirContactInfo = "ViewPublishersAndTheirContactInfo";
        public static string DeleteBook = "DeleteBook";
        public static string AverageBooksPrice = "AverageBooksPrice";
        public static string CalcAvgAgeOfCust = "CalcAvgAgeOfCust";
        public static string CalcMaxPrice = "CalcMaxPrice";
        public static string Counting = "Counting";
        public static string MostAuthorInOrders = "MostAuthorInOrders";
        public static string MostBookOrdered = "MostBookOrdered";
        public static string MostDistributorForBooks = "MostDistributorForBooks";
        public static string MostPublisherForBooks = "MostPublisherForBooks";
    }
}