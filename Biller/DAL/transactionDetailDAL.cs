using Biller.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biller.DAL
{
    class transactionDetailDAL
    {
        //DB Connection
        static string myconstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Insert method for TRANSCATION_DETAIL
        public bool InsertTransactionDetail(transactionDetailBLL td)
        {
            //bool variable set as false
            bool isSuccess = false;
            //Connecting to DB
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL query to insert
                string sql = "insert into tbl_transaction_detail (product_id, rate,qty,total,dea_cust_id,added_date,added_by) values (@product_id, @rate,@qty,@total,@dea_cust_id,@added_date,@added_by)";
                //create SQL command to pass the above query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter
                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);
                conn.Open();
                //int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                //if query is success then its value will be >0 else <0
                if (rows > 0)
                {
                    //successful
                    isSuccess = true;
                }
                else
                {
                    //Query Failed
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}
