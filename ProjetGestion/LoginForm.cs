using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            VerifyInformation_And_ManageStuff IfEmpty = new VerifyInformation_And_ManageStuff();

            if (!IfEmpty.IsLoginTextfieldEmpty(UserNameTextbox.Text, PasswordTextbox.Text))
            {
                return;
            }

            data.VerifyCredentialsInformation(UserNameTextbox.Text, PasswordTextbox.Text);


        }
        public void HideThis()

        {
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
