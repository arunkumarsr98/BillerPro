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
    class DealCustDAL
    {
        //DB Connection
        static string myconstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select method
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconstring);
            DataTable dt = new DataTable();
            try
            {
                //SQL query to get the data from DB
                string sql = "Select * from tbl_dea_cust";
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
        #region Insert method
        public bool Insert(DealCustBLL dc)
        {
            //bool variable set as false
            bool isSuccess = false;
            //Connecting to DB
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL query to add new category
                string sql = "insert into tbl_dea_cust (type, name, email,contact,address,added_date,added_by) values (@type, @name,@email,@contact,@address,@added_date,@added_by)";
                //create SQL command to pass the above query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
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
        #region Update method
        public bool Update(DealCustBLL dc)
        {
            //bool variable set as false
            bool isSuccess = false;
            //Connecting to DB
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL query to add new category
                string sql = "update tbl_dea_cust SET type=@type,name= @name,email=@email,contact=@contact,address=@address,added_date=@added_date,added_by=@added_by where id=@id";
                //create SQL command to pass the above query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);
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
        #region Delete Method
        public bool Delete(DealCustBLL dc)
        {
            bool isSuccess = false;

            //Create SQL connection
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                string sql = "delete from tbl_dea_cust where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter

                cmd.Parameters.AddWithValue("@id", dc.id);
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
        #region Search method
        public DataTable Search(string keywords)
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconstring);
            //to hold the data from the database
            DataTable dt = new DataTable();
            try
            {
                //selection query
                String sql = "SELECT * from tbl_dea_cust where id like '%" + keywords + "%' OR name like '%" + keywords + "%' OR email like '%" + keywords + "%' OR contact like '%" + keywords + "%' OR address like '%" + keywords + "%'";
                //execution of sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting the data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //opening the database connection
                conn.Open();
                //Fill the data in our data table
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                //if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return dt;
        }
        #endregion
        #region Method to search DEALER or CUSTOMER for TRANSCATION MODULE
        public DealCustBLL SearchDealerCustomerForTransaction(string keyword)
        {
            //Create an object for DeaCustBLL class
            DealCustBLL dc = new DealCustBLL();
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconstring);
            //to hold the data from the database
            DataTable dt = new DataTable();
            try
            {
                string sql = "select name,email,contact,address from tbl_dea_cust where id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                //execution of sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting the data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //opening the database connection
                conn.Open();
                //Fill the data in our data table
                adapter.Fill(dt);

                //If value matches in dt we need to show it in dealercustomerBLL
                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();
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

            return dc;

        }

        #endregion
        #region Get method to get the ID of dealer/Customer using their name
        public DealCustBLL GetDealCustIDFromName(string name)
        {
            DealCustBLL dc = new DealCustBLL();

            SqlConnection conn = new SqlConnection(myconstring);
            DataTable dt = new DataTable();

            try
            {
                //SQL query to get the data from DB
                string sql = "select id from tbl_dea_cust where name='"+name+"'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open DB COnnection
                conn.Open();
                //Add the value from adpater to Data table (dt)
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dc.id=int.Parse(dt.Rows[0]["id"].ToString());
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
            return dc;
        }
        #endregion
    }
}
