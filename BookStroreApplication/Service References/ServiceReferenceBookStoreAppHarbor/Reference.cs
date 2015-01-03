﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStroreApplication.ServiceReferenceBookStoreAppHarbor {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/BookstoreWebservice")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Admin {
            get {
                return this.AdminField;
            }
            set {
                if ((this.AdminField.Equals(value) != true)) {
                    this.AdminField = value;
                    this.RaisePropertyChanged("Admin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/BookstoreWebservice")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int YearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Category {
            get {
                return this.CategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryField, value) != true)) {
                    this.CategoryField = value;
                    this.RaisePropertyChanged("Category");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceBookStoreAppHarbor.IServiceBookstore")]
    public interface IServiceBookstore {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/SignUp", ReplyAction="http://tempuri.org/IServiceBookstore/SignUpResponse")]
        void SignUp(BookStroreApplication.ServiceReferenceBookStoreAppHarbor.User user, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/SignUp", ReplyAction="http://tempuri.org/IServiceBookstore/SignUpResponse")]
        System.Threading.Tasks.Task SignUpAsync(BookStroreApplication.ServiceReferenceBookStoreAppHarbor.User user, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/LogIn", ReplyAction="http://tempuri.org/IServiceBookstore/LogInResponse")]
        string LogIn(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/LogIn", ReplyAction="http://tempuri.org/IServiceBookstore/LogInResponse")]
        System.Threading.Tasks.Task<string> LogInAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/LogOut", ReplyAction="http://tempuri.org/IServiceBookstore/LogOutResponse")]
        void LogOut(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/LogOut", ReplyAction="http://tempuri.org/IServiceBookstore/LogOutResponse")]
        System.Threading.Tasks.Task LogOutAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/IsAdmin", ReplyAction="http://tempuri.org/IServiceBookstore/IsAdminResponse")]
        bool IsAdmin(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/IsAdmin", ReplyAction="http://tempuri.org/IServiceBookstore/IsAdminResponse")]
        System.Threading.Tasks.Task<bool> IsAdminAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/IsLoggedIn", ReplyAction="http://tempuri.org/IServiceBookstore/IsLoggedInResponse")]
        bool IsLoggedIn(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/IsLoggedIn", ReplyAction="http://tempuri.org/IServiceBookstore/IsLoggedInResponse")]
        System.Threading.Tasks.Task<bool> IsLoggedInAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/GetBooks", ReplyAction="http://tempuri.org/IServiceBookstore/GetBooksResponse")]
        BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book[] GetBooks(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/GetBooks", ReplyAction="http://tempuri.org/IServiceBookstore/GetBooksResponse")]
        System.Threading.Tasks.Task<BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book[]> GetBooksAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/GetBooksByCategory", ReplyAction="http://tempuri.org/IServiceBookstore/GetBooksByCategoryResponse")]
        BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book[] GetBooksByCategory(string category, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/GetBooksByCategory", ReplyAction="http://tempuri.org/IServiceBookstore/GetBooksByCategoryResponse")]
        System.Threading.Tasks.Task<BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book[]> GetBooksByCategoryAsync(string category, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/GetBookByTitle", ReplyAction="http://tempuri.org/IServiceBookstore/GetBookByTitleResponse")]
        BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book GetBookByTitle(string title, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/GetBookByTitle", ReplyAction="http://tempuri.org/IServiceBookstore/GetBookByTitleResponse")]
        System.Threading.Tasks.Task<BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book> GetBookByTitleAsync(string title, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/AddBook", ReplyAction="http://tempuri.org/IServiceBookstore/AddBookResponse")]
        void AddBook(BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book book, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/AddBook", ReplyAction="http://tempuri.org/IServiceBookstore/AddBookResponse")]
        System.Threading.Tasks.Task AddBookAsync(BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book book, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/DeleteBookByTitle", ReplyAction="http://tempuri.org/IServiceBookstore/DeleteBookByTitleResponse")]
        void DeleteBookByTitle(string title, string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceBookstore/DeleteBookByTitle", ReplyAction="http://tempuri.org/IServiceBookstore/DeleteBookByTitleResponse")]
        System.Threading.Tasks.Task DeleteBookByTitleAsync(string title, string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceBookstoreChannel : BookStroreApplication.ServiceReferenceBookStoreAppHarbor.IServiceBookstore, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceBookstoreClient : System.ServiceModel.ClientBase<BookStroreApplication.ServiceReferenceBookStoreAppHarbor.IServiceBookstore>, BookStroreApplication.ServiceReferenceBookStoreAppHarbor.IServiceBookstore {
        
        public ServiceBookstoreClient() {
        }
        
        public ServiceBookstoreClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceBookstoreClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBookstoreClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceBookstoreClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SignUp(BookStroreApplication.ServiceReferenceBookStoreAppHarbor.User user, string token) {
            base.Channel.SignUp(user, token);
        }
        
        public System.Threading.Tasks.Task SignUpAsync(BookStroreApplication.ServiceReferenceBookStoreAppHarbor.User user, string token) {
            return base.Channel.SignUpAsync(user, token);
        }
        
        public string LogIn(string username, string password) {
            return base.Channel.LogIn(username, password);
        }
        
        public System.Threading.Tasks.Task<string> LogInAsync(string username, string password) {
            return base.Channel.LogInAsync(username, password);
        }
        
        public void LogOut(string token) {
            base.Channel.LogOut(token);
        }
        
        public System.Threading.Tasks.Task LogOutAsync(string token) {
            return base.Channel.LogOutAsync(token);
        }
        
        public bool IsAdmin(string token) {
            return base.Channel.IsAdmin(token);
        }
        
        public System.Threading.Tasks.Task<bool> IsAdminAsync(string token) {
            return base.Channel.IsAdminAsync(token);
        }
        
        public bool IsLoggedIn(string token) {
            return base.Channel.IsLoggedIn(token);
        }
        
        public System.Threading.Tasks.Task<bool> IsLoggedInAsync(string token) {
            return base.Channel.IsLoggedInAsync(token);
        }
        
        public BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book[] GetBooks(string token) {
            return base.Channel.GetBooks(token);
        }
        
        public System.Threading.Tasks.Task<BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book[]> GetBooksAsync(string token) {
            return base.Channel.GetBooksAsync(token);
        }
        
        public BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book[] GetBooksByCategory(string category, string token) {
            return base.Channel.GetBooksByCategory(category, token);
        }
        
        public System.Threading.Tasks.Task<BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book[]> GetBooksByCategoryAsync(string category, string token) {
            return base.Channel.GetBooksByCategoryAsync(category, token);
        }
        
        public BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book GetBookByTitle(string title, string token) {
            return base.Channel.GetBookByTitle(title, token);
        }
        
        public System.Threading.Tasks.Task<BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book> GetBookByTitleAsync(string title, string token) {
            return base.Channel.GetBookByTitleAsync(title, token);
        }
        
        public void AddBook(BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book book, string token) {
            base.Channel.AddBook(book, token);
        }
        
        public System.Threading.Tasks.Task AddBookAsync(BookStroreApplication.ServiceReferenceBookStoreAppHarbor.Book book, string token) {
            return base.Channel.AddBookAsync(book, token);
        }
        
        public void DeleteBookByTitle(string title, string token) {
            base.Channel.DeleteBookByTitle(title, token);
        }
        
        public System.Threading.Tasks.Task DeleteBookByTitleAsync(string title, string token) {
            return base.Channel.DeleteBookByTitleAsync(title, token);
        }
    }
}