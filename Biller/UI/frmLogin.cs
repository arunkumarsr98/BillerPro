using Biller.BLL;
using Biller.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biller.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedusername;


        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtUsername.Text.Trim();
            l.password = txtPassword.Text.Trim();
            l.user_type = cmbUserType.Text.Trim();

            //checking the login credentials
            bool success = dal.loginCheck(l);
            if (success == true)
            {
                //login successful
                MessageBox.Show("Login Successful");
                loggedusername = l.username;
                 
                //on logging in successfully, need to open the respective dashboaard(admin or user)
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //Go to admin dashboard
                            frmAdminDashboard admin = new frmAdminDashboard();
                            admin.Show();
                            this.Hide();

                        }
                        break;
                    case "User":
                        {
                            //Go to user dashboard
                            frmUserDashboard user = new frmUserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;

                    default:
                        {
                            //If neither user nor admin
                            MessageBox.Show("Invalid User type");
                        }
                        break;
                }
            }
            else
            {
                //login failed
                MessageBox.Show("Login failed!. Please check your credentials :-)");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
