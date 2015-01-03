using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookStroreApplication.ServiceReferenceBookStoreAppHarbor;

namespace BookStroreApplication
{
    public partial class FormMain : Form
    {
        ServiceBookstoreClient client;

        string token;
        string user;

        public FormMain()
        {

            InitializeComponent();
            client = new ServiceBookstoreClient();

        }

        private void bt_LogIn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(token) && client.IsLoggedIn(token))
            {
                MessageBox.Show("A user already logged in: " + user + ". Please log out first.");
            }
            else
            {
                FormLogIn formAuth = new FormLogIn(client);
                DialogResult dialogResult = formAuth.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    token = formAuth.Token;
                    user = formAuth.User;
                    MessageBox.Show("LogIn successful: " + user);
                }
            }
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(token) || !client.IsLoggedIn(token))
                {
                    MessageBox.Show("User is not logged in");
                }
                else
                {
                    client.LogOut(token);
                    token = null;
                    user = null;
                    MessageBox.Show("LogOut successful.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void bt_SignUp_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(token) || !client.IsLoggedIn(token))
            {
                MessageBox.Show("User is not logged in.");
            }
            else if (!client.IsAdmin(token))
            {
                MessageBox.Show("User does not possess administration privileges.");
            }
            else
            {
                FormSignUp formSignUp = new FormSignUp(client, token);
                DialogResult dialogResult = formSignUp.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MessageBox.Show("SignUp successful.");
                }
            }
        }

        private void bt_Go_Click(object sender, EventArgs e)
        {
            txtBox_OutPut.Clear();
            try
            {
                if (String.IsNullOrEmpty(token) || !client.IsLoggedIn(token))
                {
                    MessageBox.Show("User is not logged in.");
                }
                else
                {
                    switch (cbox_Operation.Text)
                    {
                        case "Get Books":
                            Book[] books = client.GetBooks(token);
                            foreach (Book b in books)
                            {
                                txtBox_OutPut.Text += printBook(b) + Environment.NewLine;
                            }
                            break;
                        default:
                            MessageBox.Show("Operation not implemented.");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            client.Close();
        }

        private string printBook(Book book)
        {
            return "Title: " + book.Title + Environment.NewLine
+ "Author: " + book.Author + Environment.NewLine
+ "Year: " + book.Year + Environment.NewLine
+ "Price: " + book.Price + Environment.NewLine
+ "Category: " + book.Category + Environment.NewLine;
        }


    }
}
