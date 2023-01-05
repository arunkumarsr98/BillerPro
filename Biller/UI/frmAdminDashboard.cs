using Biller.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biller
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void lblFooter_Click(object sender, EventArgs e)
        {

        }

        private void lblLoggedInUser_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers user = new frmUsers();
            user.Show();
        }

        private void frmAdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmAdminDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedusername;
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategories category = new frmCategories();
            category.Show();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            products.Show();
        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDealCust DeaCust = new frmDealCust();
            DeaCust.Show();
        }

        private void transcationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransactions transactions = new frmTransactions();
            transactions.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();

        }
    }
} 
