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
    public partial class frmCategories : Form
    {
        public frmCategories()
        {
            InitializeComponent();
        }
        categoriesBLL c = new categoriesBLL();
        categoriesDAL dal = new categoriesDAL();
        
        userDAL udal = new userDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get the values from category form
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;

            //Getting ID
            string loggedUser = frmLogin.loggedusername;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            c.added_by = usr.id;

            bool success = dal.Insert(c);

            if (success == true)
            {
                MessageBox.Show("New Category Added");
                clear();
                //Refesh Data Grid view
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed in adding a new category");
            }
        }
        public void clear()
        {
            txtCategoryID.Text = "";
            txtTitle.Text = "";
            txtDescription.Text = "";
            txtSearch.Text = "";
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            //Displaying all the categories
            DataTable dt = dal.Select();
            dgvCategories.DataSource = dt;

        }

        private void dgvCategories_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int RowIndex = e.RowIndex;
            txtCategoryID.Text = dgvCategories.Rows[RowIndex].Cells[0].Value.ToString();
            txtTitle.Text = dgvCategories.Rows[RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[RowIndex].Cells[2].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Get the values from the category form
            c.id = int.Parse(txtCategoryID.Text);
            c.title = txtTitle.Text;
            c.description = txtDescription.Text;
            c.added_date = DateTime.Now;
            //Getting ID
            string loggedUser = frmLogin.loggedusername;
            userBLL usr = udal.GetIDFromUsername(loggedUser);

            c.added_by = usr.id;

            //create boolen variable to check the updation is successful
            bool success = dal.Update(c);
            if (success == true)
            {
                MessageBox.Show("Category Updation Successful");
                clear();
                //Displaying all the categories
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
             }
            else
            {
                MessageBox.Show("Failed in updating the category");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the values from the category form
            c.id = int.Parse(txtCategoryID.Text);
            bool success = dal.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Category deletion Successful");
                clear();
                //Displaying all the categories
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Failed in deleting the category");
            }
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
                dgvCategories.DataSource = dt;

            }
            else
            {
                //show all users
                DataTable dt = dal.Select();
                dgvCategories.DataSource = dt;
            }
        }
    }
}
