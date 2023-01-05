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
    class productsDAL
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
                string sql = "Select * from tbl_products";
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
        public bool Insert(productsBLL p)
        {
            //bool variable set as false
            bool isSuccess = false;
            //Connecting to DB
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL query to add new category
                string sql = "insert into tbl_products (name, category,description,rate,qty,added_date,added_by) values (@name, @category,@description,@rate,@qty,@added_date,@added_by)";
                //create SQL command to pass the above query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
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
        public bool Update(productsBLL p)
        {
            bool isSuccess = false;

            //Create SQL connection
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                string sql="update tbl_products SET name=@name,category=@category,description=@description,rate=@rate,added_date=@added_date,added_by=@added_by where id=@id";                
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@id", p.id);
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
        public bool Delete(productsBLL p)
        {
            bool isSuccess = false;

            //Create SQL connection
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                string sql = "delete from tbl_products where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter

                cmd.Parameters.AddWithValue("@id", p.id);
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
                String sql = "SELECT * from tbl_products where id like '%" + keywords + "%' OR name like '%" + keywords + "%' OR category like '%" + keywords + "%'";
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
        #region Search method for TRANSACTION MODULE
        public productsBLL GetProductsForTransaction(string keyword)
        {
            productsBLL p = new productsBLL();
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconstring);
            //to hold the data from the database
            DataTable dt = new DataTable();
            try
            {
                string sql = "select name, rate, qty from tbl_products where id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";
                //execution of sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //getting the data
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //opening the database connection
                conn.Open();
                //Fill the data in our data table
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());
                    p.qty = decimal.Parse(dt.Rows[0]["qty"].ToString());

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
            return p;
        }
        #endregion
        #region Method to get product ID based on product's name
        public productsBLL GetProductIDFromName(string ProductName)
        {
            productsBLL p = new productsBLL();

            SqlConnection conn = new SqlConnection(myconstring);
            DataTable dt = new DataTable();

            try
            {
                //SQL query to get the data from DB
                string sql = "select id from tbl_products where name='" + ProductName + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open DB COnnection
                conn.Open();
                //Add the value from adpater to Data table (dt)
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    p.id = int.Parse(dt.Rows[0]["id"].ToString());
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
            return p;
        }
        #endregion
        #region Method to get the current quantity based on the product ID from DB
        public decimal GetProductQty(int ProductID)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            decimal qty = 0;

            //Create Data Table to save the data from DB Temporarily
            DataTable dt = new DataTable();

            try
            {
                string sql = "Select qty from tbl_products where id = " + ProductID;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open DB COnnection
                conn.Open();
                //Add the value from adpater to Data table (dt)
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    qty=decimal.Parse(dt.Rows[0]["qty"].ToString());

                }

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return qty;
        }
        #endregion
        #region Method to get the updated quantity 
        public bool UpdateQuantity(int ProductID, decimal Qty)
        {
            bool success = false;
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL query to get the data from DB
                string sql = "update tbl_products set qty=@qty where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@qty", Qty);
                cmd.Parameters.AddWithValue("@id", ProductID);
               
                //Open DB COnnection
                conn.Open();
                //int variable to execute query
                int rows = cmd.ExecuteNonQuery();

                //if query is success then its value will be >0 else <0
                if (rows > 0)
                {
                    //successful
                    success = true;
                }
                else
                {
                    //Query Failed
                    success = false;
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

            return success;
        }
        #endregion
        #region Method to increment the product
        public bool IncreaseProduct(int ProductID, decimal IncreaseQty)
        {
            bool success = false;
            //Create SQL connection
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //Getting the current qty
                decimal currentQty = GetProductQty(ProductID);
                
                // Increasing the current quantity by the qty purchased from Dealer
                decimal NewQty = currentQty + IncreaseQty;

                //Updating the prdt qty 
                success = UpdateQuantity(ProductID, NewQty);

                //Open DB COnnection
                conn.Open();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return success;
        }
        #endregion
        #region Method to decrement the product
        public bool DecreaseProduct(int ProductID, decimal Qty)
        {
            bool success = false;
            //Create SQL connection
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //Getting the current qty
                decimal currentQty = GetProductQty(ProductID);
                // Increasing the current quantity by the qty purchased from Dealer
                decimal NewQty = currentQty - Qty;
                //Updating the prdt qty 
                success = UpdateQuantity(ProductID, NewQty);

                //Open DB COnnection
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { 
                conn.Close();
            }

            return success;

        }

        #endregion
        #region Method to display the products based on the categories (Inventory form)
        public DataTable DisplayProductsByCategory(string category)
        {
            SqlConnection conn = new SqlConnection(myconstring);
            DataTable dt = new DataTable();
            try
            {
                //SQL query to get the data from DB
                string sql = "Select * from tbl_products where category='"+category+"' ";
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

