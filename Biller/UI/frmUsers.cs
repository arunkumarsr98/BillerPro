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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        userBLL u= new userBLL();
        userDAL dal= new userDAL();
   

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }
        private void clear()
        {
            txtUserID.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtUsername.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbGender.Text = "";
            cmbUserType.Text = "";

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
           

            //Getting data from our UI
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            //Getting the logged in user details
            string loggedusername = frmLogin.loggedusername;
            userBLL usr = dal.GetIDFromUsername(loggedusername);

            u.added_by = usr.id;
            //Inserting data into database
            bool success = dal.Insert(u);
            //If the data is inserted successfullym  then the value of success will be true
            //else false
            if (success == true)
            {
                MessageBox.Show("New user is successfully created!");
                clear();
            }
            else
            {
                MessageBox.Show("Failed to add a new user");
            }
            //Refreshing data grid view
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;


        }

        private void dgvUsers_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of a particular row
            int rowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();
            txtContact.Text = dgvUsers.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[rowIndex].Cells[7].Value.ToString();
            cmbGender.Text = dgvUsers.Rows[rowIndex].Cells[8].Value.ToString();
            cmbUserType.Text = dgvUsers.Rows[rowIndex].Cells[9].Value.ToString();  
             

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            u.id = Convert.ToInt32(txtUserID.Text);
            u.first_name = txtFirstName.Text;
            u.last_name = txtLastName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.gender = cmbGender.Text;
            u.user_type = cmbUserType.Text;
            u.added_date = DateTime.Now;
            u.added_by = 1;

            //Updating data into database
            bool success = dal.Update(u);
            //If data is updated true is returned else false will be returned
            if (success == true)
            {
                MessageBox.Show("User successfully updated");
                clear(); 
            }
            else
            {
                MessageBox.Show("Failed in updating the data");

            }
            //Refreshing the data grid view
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Deleting a user
            //Get userID
            u.id = Convert.ToInt32(txtUserID.Text);
            bool success = dal.Delete(u);
            //If data is deleted then success will be true else false
            if (success == true)
            {
                MessageBox.Show("User Deleted");
                clear();

            }
            else
            {
                MessageBox.Show("Failed in deleting the user");    
            }
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Getting keyword from search txt box
            string keywords = txtSearch.Text;
            //Checking keywords has value or not
            if (keywords != null)
            {
                //show user based on entered keywords
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;

            }
            else
            {
                //show all users
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
