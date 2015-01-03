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
    public partial class FormLogIn : Form
    {
        ServiceBookstoreClient client;

        string token;
        string user;

        public FormLogIn(ServiceBookstoreClient client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                user = txt_user.Text;
                token = client.LogIn(txt_user.Text, txt_pass.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                txt_user.Clear();
                txt_pass.Clear();
                MessageBox.Show(ex.Message, "ERROR");
            }
            this.Close();
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {

        }

        public string Token
        {
            get
            {
                return token;
            }
        }
        public string User
        {
            get
            {
                return user;
            }
        }
    }
}
