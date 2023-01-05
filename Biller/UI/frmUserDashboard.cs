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
    public partial class frmUserDashboard : Form
    {
        public frmUserDashboard()
        {
            InitializeComponent();
        }
        // Set a public method to find whether it is a purchase or sale
        public static string transactionType;


        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set the TranscationType value to purchase
            transactionType = "Purchase";
            frmPurchaseAndSales purchase = new frmPurchaseAndSales();
            purchase.Show();
        }

        private void frmUserDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmUserDashboard_Load(object sender, EventArgs e)
        {
            lblLoggedInUser.Text = frmLogin.loggedusername; 
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void dealerAndCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDealCust DeaCust = new frmDealCust();
            DeaCust.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set the TranscationType value to sale
            transactionType = "Sales";
            frmPurchaseAndSales sales = new frmPurchaseAndSales();
            sales.Show();
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventory inventory = new frmInventory();
            inventory.Show();
        }
    }
}
