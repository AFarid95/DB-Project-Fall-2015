using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DB_Project
{
    class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public DataTable SelectBookNames()
        {
            String StoredProcedureName = StoredProcedures.SelectBookNames;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectBookSeries()
        {
            String StoredProcedureName = StoredProcedures.SelectBookSeries;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectCustomerIDs()
        {
            String StoredProcedureName = StoredProcedures.SelectCustomerIDs;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int InsertBook(Int64 ISBN, string Name, string AFirstName, string AMinit, string ALastName,
            string YearOfPublication, string NumberOfPages, Int16 Stock, float Price, string SectionName,
            string SeriesName, string PublisherName, string DistributorName)
        {
            string StoredProcedureName = StoredProcedures.InsertBook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BISBN", ISBN);
            Parameters.Add("@BNAME", Name);
            Parameters.Add("@AFName", AFirstName);
            Parameters.Add("@AMinit", AMinit);
            Parameters.Add("@ALName", ALastName);
            Int16 YOP;
            if(Int16.TryParse(YearOfPublication, out YOP))
                Parameters.Add("@YPUB", YOP);
            else
                Parameters.Add("@YPUB", DBNull.Value);
            Int16 NOP;
            if (Int16.TryParse(NumberOfPages, out NOP))
                Parameters.Add("@NumOfPages", NumberOfPages);
            else
                Parameters.Add("@NumOfPages", DBNull.Value);
            Parameters.Add("@BStock", Stock);
            Parameters.Add("@BPrice", Price);
            if(SectionName!="")
                Parameters.Add("@BSECTIONNAME", SectionName);
            else
                Parameters.Add("@BSECTIONNAME", DBNull.Value);
            if (SeriesName != "")
                Parameters.Add("@BseriesName", SeriesName);
            else
                Parameters.Add("@BseriesName", DBNull.Value);
            if (PublisherName != "")
                Parameters.Add("@BPNAME", PublisherName);
            else
                Parameters.Add("@BPNAME", DBNull.Value);
            if (DistributorName != "")
                Parameters.Add("@BDIST", DistributorName);
            else
                Parameters.Add("@BDIST", DBNull.Value);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable CustomersInEvent(string EventName)
        {
            String StoredProcedureName = StoredProcedures.CustomersInEvent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EventName", EventName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable AuthorsInEvent(string EventName)
        {
            String StoredProcedureName = StoredProcedures.AuthorsInEvent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EventName", EventName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable BooksByAuthor(string FName, string Minit, string LName)
        {
            String StoredProcedureName = StoredProcedures.BooksByAuthor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AFirstName", FName);
            Parameters.Add("@AMinit", Minit);
            Parameters.Add("@ALastName", LName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable BooksDistributed(string DistName)
        {
            String StoredProcedureName = StoredProcedures.BooksDistributed;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Distname", DistName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int InsertCustomer(string name, Int16 age, string gender, string nath)
        {
            string StoredProcedureName = StoredProcedures.InsertCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@age", age);
            Parameters.Add("@gender", gender);
            Parameters.Add("@nath", nath);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable BooksInOrder(Int16 orderid)
        {
            string StoredProcedureName = StoredProcedures.BooksInOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderid", orderid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable BookSeriesByAuthor(string AuthorFname, char AuthorMinit, string AuthorLname)
        {
            string StoredProcedureName = StoredProcedures.BookSeriesByAuthor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@AuthorFname", AuthorFname);
            Parameters.Add("@AuthorMinit", AuthorMinit);
            Parameters.Add("@AuthorLname", AuthorLname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CustomersInDiscussionGroup(string DiscussionGroupName)
        {
            String StoredProcedureName = StoredProcedures.CustomersInDiscussionGroup;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DiscussionGroupName", DiscussionGroupName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable BooksInDiscussionGroup(string DiscussionGroupName)
        {
            String StoredProcedureName = StoredProcedures.BooksInDiscussionGroup;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DiscussionGroupName", DiscussionGroupName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int UserLogin(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.UserLogin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@username", Username);
            Parameters.Add("@password", Password);
            return (int) dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int AddBookToBookSeries(string BookName, string BookSeriesName)
        {
            string StoredProcedureName = StoredProcedures.AddBookToBookSeries;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BookName", BookName);
            Parameters.Add("@BookSeriesName", BookSeriesName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddOrder(int CID)
        {
            string StoredProcedureName = StoredProcedures.AddOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", CID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable OrdersByCustomer(int CID)
        {
            string StoredProcedureName = StoredProcedures.OrdersByCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", CID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddBookToOrder(string BName, Int16 OrderID)
        {
            string StoredProcedureName = StoredProcedures.AddBookToOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BName", BName);
            Parameters.Add("@OrderID", OrderID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable EventsOnDate(string Date)
        {
            string StoredProcedureName = StoredProcedures.EventsOnDate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Date", Date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable PastEvents()
        {
            string StoredProcedureName = StoredProcedures.PastEvents;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable FutureEvents()
        {
            string StoredProcedureName = StoredProcedures.FutureEvents;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable EventsToday()
        {
            string StoredProcedureName = StoredProcedures.EventsToday;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable ViewBooksOrdered(int att, int ordering)
        {
            string StoredProcedureName = StoredProcedures.ViewBooksOrdered;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@attribute", att);
            Parameters.Add("@order", ordering);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddPublisherAddress(string name, Int16 buildingNo, string street, string city, string country)
        {
            string StoredProcedureName = StoredProcedures.AddPublisherAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@buildingNo", buildingNo);
            Parameters.Add("@street", street);
            Parameters.Add("@city", city);
            Parameters.Add("@country", country);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddSection(string name)
        {
            string StoredProcedureName = StoredProcedures.AddSection;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddBookInDiscussionGroup(string BName, string DGName)
        {
            string StoredProcedureName = StoredProcedures.AddBookInDiscussionGroup;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BName", BName);
            Parameters.Add("@DGName", DGName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewDistributorAddresses(string DName)
        {
            String StoredProcedureName = StoredProcedures.ViewDistributorAddresses;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DName", DName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int EditDistributorInfo(string email, string tele, string name)
        {
            string StoredProcedureName = StoredProcedures.EditDistributorInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            if(email!="")
                Parameters.Add("@email", email);
            else
                Parameters.Add("@email", DBNull.Value);
            if(tele!="")
                Parameters.Add("@tele", int.Parse(tele));
            else
                Parameters.Add("@tele", DBNull.Value);
            Parameters.Add("@name", name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int EditBookInfo(string Bname, string BYearOfPublication, string BNumberOfPages, string BStock, string BPrice,
            string BSectionName, string BSeriesName, string BPName)
        {
            string StoredProcedureName = StoredProcedures.EditBookInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Bname", Bname);
            if(BYearOfPublication!="")
                Parameters.Add("@BYearOfPublication", Int16.Parse(BYearOfPublication));
            else
                Parameters.Add("@BYearOfPublication", DBNull.Value);
            if(BNumberOfPages!="")
                Parameters.Add("@BNumberOfPages", Int16.Parse(BNumberOfPages));
            else
                Parameters.Add("@BNumberOfPages", DBNull.Value);
            if (BStock != "")
                Parameters.Add("@BStock", Int16.Parse(BStock));
            else
                Parameters.Add("@BStock", DBNull.Value);
            if (BPrice != "")
                Parameters.Add("@BPrice", float.Parse(BPrice));
            else
                Parameters.Add("@BPrice", DBNull.Value);
            if (BSectionName != "")
                Parameters.Add("@BSectionName", BSectionName);
            else
                Parameters.Add("@BSectionName", DBNull.Value);
            if (BSeriesName != "")
                Parameters.Add("@BSeriesName", BSeriesName);
            else
                Parameters.Add("@BSeriesName", DBNull.Value);
            if (BPName != "")
                Parameters.Add("@BPName", BPName);
            else
                Parameters.Add("@BPName", DBNull.Value);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteDistributor(string dname)
        {
            string StoredProcedureName = StoredProcedures.DeleteDistributor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@dName", dname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteSection(string sname)
        {
            string StoredProcedureName = StoredProcedures.DeleteSection;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@sName", sname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertDistributor(string name, string email, int telephone)
        {
            string StoredProcedureName = StoredProcedures.AddDistributor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@email", email);
            Parameters.Add("@tele", telephone);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewPublisherAddress(string PName)
        {
            string StoredProcedureName = StoredProcedures.ViewPublisherAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PName", PName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable ViewDistributorsAndTheirContactInfo()
        {
            string StoredProcedureName = StoredProcedures.ViewDistributorsAndTheirContactInfo;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int AddEvent(string ename, string date, string starttime, string endtime)
        {
            string StoredProcedureName = StoredProcedures.AddEvent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ename", ename);
            Parameters.Add("@date", date);
            Parameters.Add("@starttime", starttime);
            Parameters.Add("@endtime", endtime);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddCustomerInDiscussionGroup(int cid, string dgname)
        {
            string StoredProcedureName = StoredProcedures.AddCustomerInDiscussionGroup;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@cid", cid);
            Parameters.Add("@dgname", dgname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddAuthorInEvent(string fname, string minit, string lname, string ename)
        {
            string StoredProcedureName = StoredProcedures.AddAuthorInEvent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@fname", fname);
            Parameters.Add("@minit", minit);
            Parameters.Add("@lname", lname);
            Parameters.Add("@ename", ename);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int EditPublisherInfo(string email, int telephone, string name)
        {
            string StoredProcedureName = StoredProcedures.EditPublisherInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@email", email);
            Parameters.Add("@tele", telephone);
            Parameters.Add("@name", name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeletePublisher(string name)
        {
            string StoredProcedureName = StoredProcedures.EditPublisherInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteDistributorAddress(string name, Int16 buildingno, string street, string city, string country)
        {
            string StoredProcedureName = StoredProcedures.EditPublisherInfo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@buildingno", buildingno);
            Parameters.Add("@street", street);
            Parameters.Add("@city", city);
            Parameters.Add("@country", country);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteBookSeries(string name)
        {
            string StoredProcedureName = StoredProcedures.DeleteBookSeries;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable ViewAllBooksThatStartWithACertainString(string str)
        {
            string StoredProcedureName = StoredProcedures.ViewAllBooksThatStartWithACertainString;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@string", str);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddCustomerInEvent(int CustID, string eventname)
        {
            string StoredProcedureName = StoredProcedures.AddCustomerInEvent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CustID  ", CustID);
            Parameters.Add("@eventname", eventname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeletePublisherAddress(int build, string street, string country, string city, string Name)
        {
            string StoredProcedureName = StoredProcedures.DeletePublisherAddress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@build  ", build);
            Parameters.Add("@city", city);
            Parameters.Add("@country", country);
            Parameters.Add("@street", street);
            Parameters.Add("@Name", Name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteDiscussionGroup(string Name)
        {
            string StoredProcedureName = StoredProcedures.DeleteDiscussionGroup;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddDiscussionGroup(string DName)
        {
            string StoredProcedureName = StoredProcedures.AddDiscussionGroup;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DName", DName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable CustomerAndBooksInOrder(int ID)
        {
            string StoredProcedureName = StoredProcedures.CustomerAndBooksInOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CustomerInOrder(int ID)
        {
            string StoredProcedureName = StoredProcedures.CustomerInOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderid", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable BooksInOrder(int ID)
        {
            string StoredProcedureName = StoredProcedures.BooksInOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@orderid", ID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable ViewPublishersAndTheirContactInfo()
        {
            string StoredProcedureName = StoredProcedures.ViewPublishersAndTheirContactInfo;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int AddPublisher(string PName, int Pnumber, string pemail)
        {
            string StoredProcedureName = StoredProcedures.AddPublisher;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PName", PName);
            Parameters.Add("@Pnumber  ", Pnumber);
            Parameters.Add("@pemail", pemail);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AddDistributorAdress(string DName, int Dbuild, string dstreet, string dcity, string dcountry)
        {
            string StoredProcedureName = StoredProcedures.AddDistributorAdress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DName", DName);
            Parameters.Add("@Dbuild", Dbuild);
            Parameters.Add("@dstreet  ", dstreet);
            Parameters.Add("@dcity", dcity);
            Parameters.Add("@dcountry", dcountry);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int EditAuthorInfo(string fname, string minit, string lname, string gender, string bdate, string nationality)
        {
            string StoredProcedureName = StoredProcedures.AddDistributorAdress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            if(gender!="")
                Parameters.Add("@gender", gender);
            else
                Parameters.Add("@gender", DBNull.Value);
            if (bdate != "")
                Parameters.Add("@bdate", bdate);
            else
                Parameters.Add("@bdate", DBNull.Value);
            if (nationality != "")
                Parameters.Add("@nationality", nationality);
            else
                Parameters.Add("@nationality", DBNull.Value);
            Parameters.Add("@bdate  ", bdate);
            Parameters.Add("@nationality", nationality);
            Parameters.Add("@fname", fname);
            Parameters.Add("@minit", minit);
            Parameters.Add("@lname", lname);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteBook(long ISBN)
        {
            string StoredProcedureName = StoredProcedures.DeleteBook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ISBN", ISBN);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Counting()
        {
            string StoredProcedureName = StoredProcedures.Counting;
            return (int)dbMan.ExecuteScalar(StoredProcedureName,null);
        }

        public int CalcMaxPrice()
        {
            string StoredProcedureName = StoredProcedures.CalcMaxPrice;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int AverageBooksPrice()
        {
            string StoredProcedureName = StoredProcedures.AverageBooksPrice;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public int CalcAvgAgeOfCust()
        {
            string StoredProcedureName = StoredProcedures.CalcAvgAgeOfCust;
            return (int)dbMan.ExecuteScalar(StoredProcedureName, null);
        }

        public DataTable MostBookOrdered()
        {
            string StoredProcedureName = StoredProcedures.MostBookOrdered;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable MostAuthorInOrders()
        {
            string StoredProcedureName = StoredProcedures.MostAuthorInOrders;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable MostPublisherForBooks()
        {
            string StoredProcedureName = StoredProcedures.MostPublisherForBooks;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable MostDistributorForBooks()
        {
            string StoredProcedureName = StoredProcedures.MostDistributorForBooks;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

    }
}
