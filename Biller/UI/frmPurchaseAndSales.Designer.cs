namespace Biller.UI
{
    partial class frmPurchaseAndSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPurchaseAndSales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.pnlDealCust = new System.Windows.Forms.Panel();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblBilldate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblDealCustTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtInventory = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblInventory = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductSearch = new System.Windows.Forms.Label();
            this.lblProductTitle = new System.Windows.Forms.Label();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.dgvAddedProducts = new System.Windows.Forms.DataGridView();
            this.lblDGVTitle = new System.Windows.Forms.Label();
            this.pnlCalculation = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtReturnAmount = new System.Windows.Forms.TextBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblReturnAmount = new System.Windows.Forms.Label();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblGST = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblCalculation = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDealCust.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).BeginInit();
            this.pnlCalculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 34);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1260, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(582, 9);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(171, 20);
            this.lblTop.TabIndex = 0;
            this.lblTop.Text = "PURCHASE and SALES";
            // 
            // pnlDealCust
            // 
            this.pnlDealCust.BackColor = System.Drawing.Color.DarkKhaki;
            this.pnlDealCust.Controls.Add(this.dtpBillDate);
            this.pnlDealCust.Controls.Add(this.txtAddress);
            this.pnlDealCust.Controls.Add(this.txtContact);
            this.pnlDealCust.Controls.Add(this.txtEmail);
            this.pnlDealCust.Controls.Add(this.txtName);
            this.pnlDealCust.Controls.Add(this.txtSearch);
            this.pnlDealCust.Controls.Add(this.lblBilldate);
            this.pnlDealCust.Controls.Add(this.lblAddress);
            this.pnlDealCust.Controls.Add(this.lblContact);
            this.pnlDealCust.Controls.Add(this.lblEmail);
            this.pnlDealCust.Controls.Add(this.lblName);
            this.pnlDealCust.Controls.Add(this.lblSearch);
            this.pnlDealCust.Controls.Add(this.lblDealCustTitle);
            this.pnlDealCust.Location = new System.Drawing.Point(12, 40);
            this.pnlDealCust.Name = "pnlDealCust";
            this.pnlDealCust.Size = new System.Drawing.Size(1272, 137);
            this.pnlDealCust.TabIndex = 4;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.CalendarFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBillDate.Location = new System.Drawing.Point(1036, 41);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(200, 23);
            this.dtpBillDate.TabIndex = 29;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(699, 41);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(184, 56);
            this.txtAddress.TabIndex = 28;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.Location = new System.Drawing.Point(441, 98);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(149, 27);
            this.txtContact.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(441, 36);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 27);
            this.txtEmail.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(76, 98);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 27);
            this.txtName.TabIndex = 26;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(76, 41);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 27);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblBilldate
            // 
            this.lblBilldate.AutoSize = true;
            this.lblBilldate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilldate.Location = new System.Drawing.Point(941, 44);
            this.lblBilldate.Name = "lblBilldate";
            this.lblBilldate.Size = new System.Drawing.Size(65, 19);
            this.lblBilldate.TabIndex = 6;
            this.lblBilldate.Text = "Bill Date";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(632, 44);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 19);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(376, 101);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(59, 19);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(376, 39);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 19);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(3, 44);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(52, 19);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lblDealCustTitle
            // 
            this.lblDealCustTitle.AutoSize = true;
            this.lblDealCustTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealCustTitle.Location = new System.Drawing.Point(581, -3);
            this.lblDealCustTitle.Name = "lblDealCustTitle";
            this.lblDealCustTitle.Size = new System.Drawing.Size(174, 19);
            this.lblDealCustTitle.TabIndex = 0;
            this.lblDealCustTitle.Text = "Dealer/Customer details";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Thistle;
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.txtRate);
            this.panel2.Controls.Add(this.txtInventory);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtSearchProduct);
            this.panel2.Controls.Add(this.lblQuantity);
            this.panel2.Controls.Add(this.lblRate);
            this.panel2.Controls.Add(this.lblInventory);
            this.panel2.Controls.Add(this.lblProductName);
            this.panel2.Controls.Add(this.lblProductSearch);
            this.panel2.Controls.Add(this.lblProductTitle);
            this.panel2.Location = new System.Drawing.Point(12, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 134);
            this.panel2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(459, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(318, 32);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add to Cart";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(1142, 41);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(130, 27);
            this.txtQuantity.TabIndex = 38;
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(905, 36);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(101, 27);
            this.txtRate.TabIndex = 37;
            // 
            // txtInventory
            // 
            this.txtInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInventory.Location = new System.Drawing.Point(676, 36);
            this.txtInventory.Name = "txtInventory";
            this.txtInventory.Size = new System.Drawing.Size(101, 27);
            this.txtInventory.TabIndex = 36;
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(380, 41);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(165, 27);
            this.txtProductName.TabIndex = 35;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(76, 36);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(165, 27);
            this.txtSearchProduct.TabIndex = 30;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(1058, 44);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 19);
            this.lblQuantity.TabIndex = 34;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(814, 39);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(39, 19);
            this.lblRate.TabIndex = 33;
            this.lblRate.Text = "Rate";
            // 
            // lblInventory
            // 
            this.lblInventory.AutoSize = true;
            this.lblInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.Location = new System.Drawing.Point(581, 39);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(69, 19);
            this.lblInventory.TabIndex = 32;
            this.lblInventory.Text = "Inventory";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(309, 39);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(47, 19);
            this.lblProductName.TabIndex = 31;
            this.lblProductName.Text = "Name";
            // 
            // lblProductSearch
            // 
            this.lblProductSearch.AutoSize = true;
            this.lblProductSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductSearch.Location = new System.Drawing.Point(3, 39);
            this.lblProductSearch.Name = "lblProductSearch";
            this.lblProductSearch.Size = new System.Drawing.Size(52, 19);
            this.lblProductSearch.TabIndex = 30;
            this.lblProductSearch.Text = "Search";
            // 
            // lblProductTitle
            // 
            this.lblProductTitle.AutoSize = true;
            this.lblProductTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTitle.Location = new System.Drawing.Point(607, 0);
            this.lblProductTitle.Name = "lblProductTitle";
            this.lblProductTitle.Size = new System.Drawing.Size(114, 19);
            this.lblProductTitle.TabIndex = 30;
            this.lblProductTitle.Text = "Product Details";
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.BackColor = System.Drawing.Color.LightCyan;
            this.pnlDataGridView.Controls.Add(this.dgvAddedProducts);
            this.pnlDataGridView.Controls.Add(this.lblDGVTitle);
            this.pnlDataGridView.Location = new System.Drawing.Point(10, 332);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(637, 312);
            this.pnlDataGridView.TabIndex = 6;
            // 
            // dgvAddedProducts
            // 
            this.dgvAddedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddedProducts.Location = new System.Drawing.Point(9, 22);
            this.dgvAddedProducts.Name = "dgvAddedProducts";
            this.dgvAddedProducts.Size = new System.Drawing.Size(610, 287);
            this.dgvAddedProducts.TabIndex = 40;
            // 
            // lblDGVTitle
            // 
            this.lblDGVTitle.AutoSize = true;
            this.lblDGVTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDGVTitle.Location = new System.Drawing.Point(267, 0);
            this.lblDGVTitle.Name = "lblDGVTitle";
            this.lblDGVTitle.Size = new System.Drawing.Size(161, 19);
            this.lblDGVTitle.TabIndex = 39;
            this.lblDGVTitle.Text = "Cart (Added Products)";
            // 
            // pnlCalculation
            // 
            this.pnlCalculation.BackColor = System.Drawing.Color.Ivory;
            this.pnlCalculation.Controls.Add(this.btnSave);
            this.pnlCalculation.Controls.Add(this.txtReturnAmount);
            this.pnlCalculation.Controls.Add(this.txtPaidAmount);
            this.pnlCalculation.Controls.Add(this.txtGrandTotal);
            this.pnlCalculation.Controls.Add(this.txtGST);
            this.pnlCalculation.Controls.Add(this.txtDiscount);
            this.pnlCalculation.Controls.Add(this.txtSubTotal);
            this.pnlCalculation.Controls.Add(this.lblReturnAmount);
            this.pnlCalculation.Controls.Add(this.lblPaidAmount);
            this.pnlCalculation.Controls.Add(this.lblGrandTotal);
            this.pnlCalculation.Controls.Add(this.lblGST);
            this.pnlCalculation.Controls.Add(this.lblDiscount);
            this.pnlCalculation.Controls.Add(this.lblSubTotal);
            this.pnlCalculation.Controls.Add(this.lblCalculation);
            this.pnlCalculation.Location = new System.Drawing.Point(674, 332);
            this.pnlCalculation.Name = "pnlCalculation";
            this.pnlCalculation.Size = new System.Drawing.Size(582, 299);
            this.pnlCalculation.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightPink;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(400, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 40);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "CONFIRM";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtReturnAmount
            // 
            this.txtReturnAmount.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnAmount.Location = new System.Drawing.Point(170, 260);
            this.txtReturnAmount.Name = "txtReturnAmount";
            this.txtReturnAmount.ReadOnly = true;
            this.txtReturnAmount.Size = new System.Drawing.Size(165, 37);
            this.txtReturnAmount.TabIndex = 49;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(170, 219);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(165, 27);
            this.txtPaidAmount.TabIndex = 48;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(170, 177);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(165, 27);
            this.txtGrandTotal.TabIndex = 47;
            // 
            // txtGST
            // 
            this.txtGST.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGST.Location = new System.Drawing.Point(170, 136);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(165, 27);
            this.txtGST.TabIndex = 46;
            this.txtGST.TextChanged += new System.EventHandler(this.txtGST_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(170, 88);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(165, 27);
            this.txtDiscount.TabIndex = 45;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(170, 38);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(165, 27);
            this.txtSubTotal.TabIndex = 30;
            this.txtSubTotal.Text = "0";
            // 
            // lblReturnAmount
            // 
            this.lblReturnAmount.AutoSize = true;
            this.lblReturnAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnAmount.Location = new System.Drawing.Point(10, 260);
            this.lblReturnAmount.Name = "lblReturnAmount";
            this.lblReturnAmount.Size = new System.Drawing.Size(151, 19);
            this.lblReturnAmount.TabIndex = 44;
            this.lblReturnAmount.Text = "Amout to be Returned";
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.Location = new System.Drawing.Point(11, 221);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(91, 19);
            this.lblPaidAmount.TabIndex = 43;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.Location = new System.Drawing.Point(10, 184);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(84, 19);
            this.lblGrandTotal.TabIndex = 42;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGST.Location = new System.Drawing.Point(11, 138);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(59, 19);
            this.lblGST.TabIndex = 41;
            this.lblGST.Text = "GST (%)";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(11, 90);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(91, 19);
            this.lblDiscount.TabIndex = 40;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(11, 40);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(68, 19);
            this.lblSubTotal.TabIndex = 39;
            this.lblSubTotal.Text = "Sub Total";
            // 
            // lblCalculation
            // 
            this.lblCalculation.AutoSize = true;
            this.lblCalculation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculation.Location = new System.Drawing.Point(227, 0);
            this.lblCalculation.Name = "lblCalculation";
            this.lblCalculation.Size = new System.Drawing.Size(134, 19);
            this.lblCalculation.TabIndex = 39;
            this.lblCalculation.Text = "Calculation Details";
            // 
            // frmPurchaseAndSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1296, 675);
            this.Controls.Add(this.pnlCalculation);
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDealCust);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPurchaseAndSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PURCHASE and SALES";
            this.Load += new System.EventHandler(this.frmPurchaseAndSales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDealCust.ResumeLayout(false);
            this.pnlDealCust.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDataGridView.ResumeLayout(false);
            this.pnlDataGridView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddedProducts)).EndInit();
            this.pnlCalculation.ResumeLayout(false);
            this.pnlCalculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Panel pnlDealCust;
        private System.Windows.Forms.Label lblBilldate;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblDealCustTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductSearch;
        private System.Windows.Forms.Label lblProductTitle;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtInventory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.DataGridView dgvAddedProducts;
        private System.Windows.Forms.Label lblDGVTitle;
        private System.Windows.Forms.Panel pnlCalculation;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblCalculation;
        private System.Windows.Forms.TextBox txtReturnAmount;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblReturnAmount;
        private System.Windows.Forms.Button btnSave;
    }
}