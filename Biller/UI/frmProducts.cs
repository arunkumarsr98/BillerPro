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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();
        productsBLL p = new productsBLL();
        userDAL udal = new userDAL();

        private void frmProducts_Load(object sender, EventArgs e)
        {
            //Create data table to hold the categoris from db
            DataTable categoriesDT = cdal.Select();
            //Specify DataSource for category combo box
            cmbCategory.DataSource = categoriesDT;
            //Specifying Display member and member value for combo box
            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //load all the produts in DGV
            DataTable dt = pdal.Select();
            dgvProducts.DataSource = dt;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get all the values from the Product Form
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;
            
            //p.id getter from login
            string loggeduser = frmLogin.loggedusername;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            p.added_by = usr.id;

            bool success = pdal.Insert(p);
            if (success == true)
            {
                MessageBox.Show("New Product Added Successfully");
                clear();
                //Refresh Data Grid view
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed in adding a new Product");
            }


        }
        public void clear()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            txtRate.Text = "";
            txtSearch.Text = "";

            
        }

        private void dgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //To display the values on their respective fields when clicking on the items in datagridview
            int rowIndex = e.RowIndex;
            txtID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            cmbCategory.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            txtDescription.Text = dgvProducts.Rows[rowIndex].Cells[3].Value.ToString();
            txtRate.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            p.id = int.Parse(txtID.Text);
            p.name = txtName.Text;
            p.category = cmbCategory.Text;
            p.description = txtDescription.Text;
            p.rate = decimal.Parse(txtRate.Text);
            
            p.added_date = DateTime.Now;

            //p.id getter from login
            string loggeduser = frmLogin.loggedusername;
            userBLL usr = udal.GetIDFromUsername(loggeduser);
            p.added_by = usr.id;

            //Acknowledgement of updation
            bool success = pdal.Update(p);
            if (success == true)
            {
                MessageBox.Show("Product Updated Successfully");
                clear();
                //Refresh Data Grid view
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed in updating the Product");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Get the data to delete
            p.id = int.Parse(txtID.Text);
            //Acknowledgement of updation
            bool success = pdal.Delete(p);
            if (success == true)
            {
                MessageBox.Show("Product Deleted Successfully");
                clear();
                //Refresh Data Grid view
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed in deleting the Product");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                //Search the product
                DataTable dt = pdal.Search(keywords);
                dgvProducts.DataSource = dt;
            }
            else
            {
                //Display all the products
                DataTable dt = pdal.Select();
                dgvProducts.DataSource = dt; 
            }
        }
    }
}
