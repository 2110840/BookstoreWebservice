using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace BookstoreWebservice
{
    [ServiceContract]
    public interface IServiceBookstore
    {

        // AUTHENTICATION
        [WebInvoke(Method = "POST", UriTemplate = "/signup?token={token}")]
        [OperationContract]
        void SignUp(User user, string token); // admin only

        [WebInvoke(Method = "POST", UriTemplate = "/login?username={username}&password={password}")]
        [OperationContract]
        string LogIn(string username, string password);

        [WebInvoke(Method = "POST", UriTemplate = "/logout")]
        [OperationContract]
        void LogOut(string token);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/isadmin?token={token}")]
        bool IsAdmin(string token);

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/isloggedin?token={token}")]
        bool IsLoggedIn(string token);

        // GET BOOKS

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/books?token={token}")]
        List<Book> GetBooks(string token);

        [OperationContract(Name = "GetBooksByCategory")]
        [WebInvoke(Method = "GET", UriTemplate = "/books/{category}?token={token}")]
        List<Book> GetBooks(string category, string token);

        [OperationContract(Name = "GetBookByTitle")]
        [WebInvoke(Method = "GET", UriTemplate = "/book/{title}?token={token}")]
        Book GetBook(string title, string token);

        // ADD BOOKS

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/book?token={token}")]
        void AddBook(Book book, string token); // admin only

        // DELETE BOOKS

        [OperationContract(Name = "DeleteBookByTitle")]
        [WebInvoke(Method = "DELETE", UriTemplate = "/book/{title}?token={token}")]
        void DeleteBook(string title, string token); // admin only


    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Book
    {
        string _title;
        string _author;
        int _year;
        double _price;
        string _category;

        public Book(string title, string author, int year, double price, string category)
        {
            this._title = title;
            this._author = author;
            this._year = year;
            this._price = price;
            this._category = category;
        }

        [DataMember]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [DataMember]
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        [DataMember]
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        [DataMember]
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        [DataMember]
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }



        public override string ToString()
        {
            string res = String.Empty;
            res += "Title: " + _title + Environment.NewLine;
            res += "Author: " + _author + Environment.NewLine;
            res += "Year: " + _year + Environment.NewLine;
            res += "Price: " + _price + Environment.NewLine;
            res += "Category: " + _category + Environment.NewLine;
            return res;
        }

    }
    [DataContract]
    public class User
    {
        private string username;
        private string password;
        private bool admin;

        public User(string username, string password, bool admin)
        {
            this.admin = admin;
            this.username = username;
            this.password = password;
        }

        [DataMember]
        public bool Admin
        {
            get { return admin; }
            set { admin = value; }
        }

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }

        }

        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }

    

}
