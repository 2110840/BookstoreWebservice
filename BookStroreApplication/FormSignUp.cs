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
    public partial class FormSignUp : Form
    {
        private ServiceBookstoreClient client;
        private string token;

        public FormSignUp(ServiceBookstoreClient client, string token)
        {
            InitializeComponent();

            this.client = client;
            this.token = token;
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User();
                user.Username = txt_user.Text;
                user.Password = txt_pass.Text;
                user.Admin = radioBt_Yes.Checked;
                client.SignUp(user, token);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
            this.Close();
        }
    }
}
