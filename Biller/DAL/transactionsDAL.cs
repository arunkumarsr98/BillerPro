using Biller.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biller.DAL
{
    class transactionsDAL
    {
        //DB Connection
        
        static string myconstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Insert method for TRANSACTION
        public bool Insert_Transaction(transactionsBLL t, out int transactionID)
        {
            //bool variable set as false
            bool isSuccess = false;
            transactionID = -1;
            //Connecting to DB
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL query to insert
                string sql = "insert into tbl_transactions (type, dea_cust_id,grandTotal,transaction_date,tax,discount,added_by) values (@type, @dea_cust_id,@grandTotal,@transaction_date,@tax,@discount,@added_by); select @@IDENTITY";
                //create SQL command to pass the above query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter
                cmd.Parameters.AddWithValue("@type", t.type);
                cmd.Parameters.AddWithValue("@dea_cust_id", t.dea_cust_id);
                cmd.Parameters.AddWithValue("@grandTotal", t.grandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", t.transaction_date);
                cmd.Parameters.AddWithValue("@tax", t.tax);
                cmd.Parameters.AddWithValue("@discount", t.discount);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);
                conn.Open();
                //int variable to execute query
                object o = cmd.ExecuteScalar();

                //if query is success then its value will not be NULL else it'll be NULL
                if (o!= null)
                {
                    //successful
                    transactionID = int.Parse(o.ToString());
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
        #region Method to diplay all the transactions
        public DataTable DisplayAllTransactions()
        {
            //Connecting to DB
            SqlConnection conn = new SqlConnection(myconstring);

            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from tbl_transactions";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open DB COnnection
                conn.Open();
                //Add the value from adpater to Data table (dt)
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Method to display transaction based on transaction type
        public DataTable DisplayTransactionByType(string type)
        {
            //Connecting to DB
            SqlConnection conn = new SqlConnection(myconstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from tbl_transactions where type='"+type+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open DB COnnection
                conn.Open();
                //Add the value from adpater to Data table (dt)
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
    }
}
