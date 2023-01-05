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
    public partial class frmDealCust : Form
    {
        public frmDealCust()
        {
            InitializeComponent();
        }

        private void lblTop_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        DealCustBLL dc = new DealCustBLL();
        DealCustDAL dcDal = new DealCustDAL();
        userDAL uDal = new userDAL();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dc.type = cmbDealCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;
            //Getting the ID of the current login user
            string loggedUser = frmLogin.loggedusername;
            userBLL usr = uDal.GetIDFromUsername(loggedUser);
            dc.added_by = usr.id;
            bool success = dcDal.Insert(dc);
            if (success == true)
            {
                MessageBox.Show("New Dealer/Customer Added Successfully");
                clear();
                //Refresh Data Grid view
                DataTable dt = dcDal.Select();
                dgvDealCust.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed in adding a new Dealer/Customer");
            }


        }
        public void clear()
        {
            txtDealCustID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtSearch.Text = "";
        }

        private void frmDealCust_Load(object sender, EventArgs e)
        {
            //Refresh Data Grid view
            DataTable dt = dcDal.Select();
            dgvDealCust.DataSource = dt;
        }

        private void dgvDealCust_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtDealCustID.Text = dgvDealCust.Rows[rowIndex].Cells[0].Value.ToString();
            cmbDealCust.Text = dgvDealCust.Rows[rowIndex].Cells[1].Value.ToString();
            txtName.Text = dgvDealCust.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDealCust.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDealCust.Rows[rowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dgvDealCust.Rows[rowIndex].Cells[5].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtDealCustID.Text);
            dc.type = cmbDealCust.Text;
            dc.name = txtName.Text;
            dc.email = txtEmail.Text;
            dc.contact = txtContact.Text;
            dc.address = txtAddress.Text;
            dc.added_date = DateTime.Now;
            //Getting the ID of the current login user
            string loggedUser = frmLogin.loggedusername;
            userBLL usr = uDal.GetIDFromUsername(loggedUser);
            dc.added_by = usr.id;

            bool success = dcDal.Update(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer/Customer updated Successfully");
                clear();
                //Refresh Data Grid view
                DataTable dt = dcDal.Select();
                dgvDealCust.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed in updating a new Dealer/Customer");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dc.id = int.Parse(txtDealCustID.Text);
            bool success = dcDal.Delete(dc);
            if (success == true)
            {
                MessageBox.Show("Dealer/Customer Deleted Successfully");
                clear();
                //Refresh Data Grid view
                DataTable dt = dcDal.Select();
                dgvDealCust.DataSource = dt;

            }
            else
            {
                MessageBox.Show("Failed in deleting the Dealer/Customer");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keywords object
            string keyword = txtSearch.Text;
            if (keyword != null)
            {
                //Search the data typed in the search text box
                DataTable dt = dcDal.Search(keyword);
                dgvDealCust.DataSource = dt;
            }
            else
            {
                DataTable dt = dcDal.Select();
                dgvDealCust.DataSource = dt;

            }

        }
    }
}
