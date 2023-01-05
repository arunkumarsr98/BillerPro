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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }
        categoriesDAL cdal = new categoriesDAL();
        productsDAL pdal = new productsDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            //Display the categories in Combobox
            DataTable cdt = cdal.Select();
            cmbCategory.DataSource = cdt;

            cmbCategory.DisplayMember = "title";
            cmbCategory.ValueMember = "title";

            //Display all the products in DGV
            DataTable pdt = pdal.Select();
            dgvInventory.DataSource = pdt;


        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = cmbCategory.Text;
            DataTable dt = pdal.DisplayProductsByCategory(category);
            dgvInventory.DataSource = dt;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //Display all the products in DGV
            DataTable pdt = pdal.Select();
            dgvInventory.DataSource = pdt;
            cmbCategory.Text = "";
        }
    } 
}
