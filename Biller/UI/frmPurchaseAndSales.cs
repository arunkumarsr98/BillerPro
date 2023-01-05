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
using System.Transactions;
using System.Windows.Forms;

namespace Biller.UI
{
    public partial class frmPurchaseAndSales : Form
    {
        public frmPurchaseAndSales()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {

        }

        private void frmPurchaseAndSales_Load(object sender, EventArgs e)
        {
            //Get the TranscationType value from  form :User_Dashboard.cs
            string type = frmUserDashboard.transactionType;
            //Set the value to lblTop
            lblTop.Text = type;

            //Specify columns for our TranscationDataTable
            transactionDT.Columns.Add("Product Name");
            transactionDT.Columns.Add("Rate");
            transactionDT.Columns.Add("Quantity");
            transactionDT.Columns.Add("Total");

        }
        DealCustDAL dcdal = new DealCustDAL();
        productsDAL pdal = new productsDAL();
        userDAL udal = new userDAL();
        transactionsDAL tdal = new transactionsDAL();
        transactionDetailDAL tddal = new transactionDetailDAL();



        DataTable transactionDT = new DataTable();


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Getting the keywords from the Search text box
            string keyword = txtSearch.Text;
            if (keyword == "")
            {
                //if the keywords are empty clear the text boxes
                txtName.Text = "";
                txtEmail.Text = "";
                txtContact.Text = "";
                txtAddress.Text = "";
                return;
            }
                DealCustBLL dc = dcdal.SearchDealerCustomerForTransaction(keyword);
            txtName.Text=dc.name;
            txtEmail.Text=dc.email;
            txtContact.Text=dc.contact;
            txtAddress.Text = dc.address;

           
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchProduct.Text;
            if (keyword == null)
            {
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQuantity.Text = "";
                return;
            }
            productsBLL p = pdal.GetProductsForTransaction(keyword);

            txtProductName.Text = p.name;
            txtInventory.Text = p.qty.ToString();
            txtRate.Text = p.rate.ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Get product name, rate , quantity from the product details
            string productName = txtProductName.Text;
            decimal Rate = decimal.Parse(txtRate.Text);
            decimal Qty = decimal.Parse(txtQuantity.Text);
            decimal Total = Rate * Qty;

            
            //Get subtotal
            decimal subTotal = decimal.Parse(txtSubTotal.Text);
            subTotal = subTotal + Total;

            

            //If empty item is tried to added, it's an error
            if (productName=="")
            {
                //Display error
                MessageBox.Show("Please select a valid product");       
            }
            else
            {
                //Add to Data grid View (CART)
                transactionDT.Rows.Add(productName,Rate,Qty,Total);
                
                //Display it in DGV
                dgvAddedProducts.DataSource = transactionDT;
                //Displaying the sub total in text box
                txtSubTotal.Text = subTotal.ToString();
                //clear the textboxes
                txtSearchProduct.Text = "";
                txtProductName.Text = "";
                txtInventory.Text = "";
                txtRate.Text = "";
                txtQuantity.Text = "";


            }

        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            //Getting the value from textbox
            string percentage = txtDiscount.Text;
            if (percentage == "")
            {
                //Display error if the percentage is empty
                MessageBox.Show("Enter a valid percentage value");
                
            }
            else
            {
                decimal subTotal=decimal.Parse(txtSubTotal.Text);
                //Get the discount in decimal value
                
                decimal discount = decimal.Parse(txtDiscount.Text);

                //Calculate grand total
                decimal grandTotal= ((100-discount)/100)*  subTotal;

                //Displaying the calculated amount in text box
                txtGrandTotal.Text = grandTotal.ToString();
            }

        }

        private void txtGST_TextChanged(object sender, EventArgs e)
        {
            //Check if the grand total has a value. If doesn't have value then calculate discout first
            string check = txtGrandTotal.Text;
            if (check == "")
            {
                //Display error
                MessageBox.Show("Enter the discount % ");
                txtGST.Text = "0";

                
                
            }
            else
            {
                //Calculate GST

                //Get the GST % from txt box
                decimal initialGT =decimal.Parse(txtGrandTotal.Text);
                decimal gst=decimal.Parse(txtGST.Text);
                decimal grandTotalWithGST=((100+gst)/100 * initialGT);
                
                //Display the grand total afer Discount % and GST %
                txtGrandTotal.Text = grandTotalWithGST.ToString();

            }
        }

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            decimal grandTotal = decimal.Parse(txtGrandTotal.Text);
            decimal paidAmount = decimal.Parse(txtPaidAmount.Text);

            decimal returnAmount = paidAmount - grandTotal;

            //Display the return Amount
            txtReturnAmount.Text = returnAmount.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get the values from the form
            transactionsBLL transaction = new transactionsBLL();

            transaction.type = lblTop.Text;

            //Getting the ID using the customer/Dealer's name
            string dealCustName = txtName.Text;
            DealCustBLL dc = dcdal.GetDealCustIDFromName(dealCustName);

            transaction.dea_cust_id = dc.id;
            transaction.grandTotal = Math.Round(decimal.Parse(txtGrandTotal.Text),2);
            transaction.transaction_date = DateTime.Now;
            transaction.tax = Decimal.Parse(txtGST.Text);
            transaction.discount = decimal.Parse(txtDiscount.Text);

            //Get the username
            string username = frmLogin.loggedusername;
            userBLL usr = udal.GetIDFromUsername(username);

            transaction.added_by = usr.id;
            transaction.transactionDetails = transactionDT;

            //Boolean variable to false
            bool success = false;
            //Code to insert Transcation details
            using (TransactionScope scope = new TransactionScope())
            {
                int transactionID = -1;
                //Boolean value to insert transcation
                bool w = tdal.Insert_Transaction(transaction, out transactionID);

                 //for loop to insert transcation details
                for (int i = 0; i < transactionDT.Rows.Count; i++)
                {
                    //Getting all the details of the products
                    transactionDetailBLL transactionDetail = new transactionDetailBLL();
                    //Getting the product name to converting id
                    string ProductName = transactionDT.Rows[i][0].ToString();
                    
                    productsBLL p = pdal.GetProductIDFromName(ProductName);

                    transactionDetail.product_id = p.id;
                    transactionDetail.rate = decimal.Parse(transactionDT.Rows[i][1].ToString());
                    transactionDetail.qty = decimal.Parse(transactionDT.Rows[i][2].ToString());
                    transactionDetail.total = Math.Round(decimal.Parse(transactionDT.Rows[i][3].ToString()),2);
                    transactionDetail.dea_cust_id = dc.id;
                    transactionDetail.added_date = DateTime.Now;
                    transactionDetail.added_by = usr.id;

                    //Incrementing or decrementing product quantity based on purchase or sales
                    string transactionType = lblTop.Text;
 
                    //Checking whether it is a purchase or sales.
                    bool x=false;
                    if (transactionType == "Purchase")
                    {
                        //Increase the product quantity
                        x = pdal.IncreaseProduct(transactionDetail.product_id, transactionDetail.qty);
                    }
                    else if (transactionType == "Sales")
                    {
                        //Decrease the product quantity
                         x = pdal.DecreaseProduct(transactionDetail.product_id, transactionDetail.qty);

                    }
                    //Insert the trans details into db
                    bool y = tddal.InsertTransactionDetail(transactionDetail);
                    success = w && x &&y;

                }
               
                if (success == true)
                {
                    //Transaction complete
                    scope.Complete();
                    MessageBox.Show("Transaction completed successfully");
                    //Clear DGV and textboxes
                    dgvAddedProducts.DataSource = null;
                    dgvAddedProducts.Rows.Clear();
                    txtSearch.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtContact.Text = "";
                    txtAddress.Text = "";
                    txtSearchProduct.Text = "";
                    txtProductName.Text = "";
                    txtInventory.Text = "0";
                    txtRate.Text = "0";
                    txtQuantity.Text = "0";
                    txtSubTotal.Text = "0";
                    txtDiscount.Text = "0";
                    txtGST.Text = "0";
                    txtGrandTotal.Text = "0";
                    txtPaidAmount.Text = "0";
                    txtReturnAmount.Text = "0";


                }
                else
                {
                    //Transcation faiuled
                    MessageBox.Show("Transaction Failed");

                }
            }

        }
    }
}
