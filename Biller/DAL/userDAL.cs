using Biller.BLL;
//V6
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
    class userDAL
    {
        static string myconstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region select Data from Database
        public DataTable Select()
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconstring);
            //to hold the data from the database
            DataTable dt = new DataTable();
            try
            {
                //selection query
                String sql = "SELECT * FROM tbl_users";
                //execution of sql command
                SqlCommand cmd = new SqlCommand(sql,conn);
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
            //return the value in datatable
            return dt;
        }
        #endregion
        #region Insert data in database
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconstring); 
            try
            {
                String sql = "INSERT INTO tbl_users (first_name,last_name,email,username,password,contact,address,gender,user_type,added_date,added_by) VALUES (@first_name,@last_name,@email,@username,@password,@contact,@address,@gender,@user_type,@added_date,@added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query is executed then the value to rows will be >0 
                //else it'll be 0
                if (rows > 0)
                {
                    //query executed
                    isSuccess = true;
                }
                else
                {
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
        #region Update data in database
        public bool Update(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                String sql = "UPDATE tbl_users SET first_name=@first_name ,last_name=@last_name ,email=@email,username=@username,password=@password,contact=@contact,address=@address,gender=@gender,user_type=@user_type,added_date=@added_date,added_by=added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by); 
                cmd.Parameters.AddWithValue("@id", u.id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //If query exceuted
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
            

        }
        #endregion
        #region Deleting data from the database
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                string sql = "DELETE FROM tbl_users WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", u.id);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }
        #endregion
        #region Search user on DB using keywords
        public DataTable Search(string keywords)
        {
            //static method to connect database
            SqlConnection conn = new SqlConnection(myconstring);
            //to hold the data from the database
            DataTable dt = new DataTable();
            try
            {
                //selection query
                 String sql = "SELECT * from tbl_users where id like '%" +keywords+"%' OR first_name like '%"+keywords+"%' OR last_name like '%"+keywords+"%' OR email like '%"+keywords+"%' OR username like '%"+keywords+"%'";
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
            //return the value in datatable
            return dt;
        }
        #endregion
        #region Getting user ID from username
        public userBLL GetIDFromUsername(string username)
        {
            userBLL u = new userBLL();
            SqlConnection conn = new SqlConnection(myconstring);
            DataTable dt = new DataTable();
            try
            {
                string sql="select id from tbl_users where username='"+username+"'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());

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
            return u;

        }
        
#endregion
    }
}
