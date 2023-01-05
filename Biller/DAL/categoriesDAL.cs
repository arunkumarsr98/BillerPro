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
    class categoriesDAL
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
                string sql = "Select * from tbl_categories";
                SqlCommand cmd = new SqlCommand(sql,conn);
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
        #region Insert new category
        public bool Insert(categoriesBLL c)
        {
             //bool variable set as false
            bool isSuccess = false;
            //Connecting to DB
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL query to add new category
                string sql = "insert into tbl_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by)";

                //create SQL command to pass the above query
                SqlCommand cmd = new SqlCommand(sql,conn);
                //Passing values through paramter
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description",c.description);
                cmd.Parameters.AddWithValue("@added_date",c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

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
        #region Update existing category
        public bool Update(categoriesBLL c)
        {
            bool isSuccess = false;

            //Create SQL connection
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                string sql = "update tbl_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";
                //create SQL command to pass the above query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id", c.id);
                conn.Open(); //DB open
                int rows = cmd.ExecuteNonQuery();
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
        #region Delete existing category
        public bool Delete(categoriesBLL c)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                string sql = "delete from tbl_categories WHERE id=@id";
                //create SQL command to pass the above query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing values through paramter
                
                cmd.Parameters.AddWithValue("@id", c.id);
                conn.Open(); //DB open
                int rows = cmd.ExecuteNonQuery();
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
        #region Searching the category
        public DataTable Search(string keywords)
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconstring);
            //to hold the data from the database
            DataTable dt = new DataTable();
            try
            {
                //selection query
                String sql = "SELECT * from tbl_categories where id like '%" + keywords + "%' OR title like '%" + keywords + "%' OR description like '%" + keywords + "%'";
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

    }
}
