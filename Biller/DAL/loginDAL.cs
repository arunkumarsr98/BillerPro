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
    class loginDAL
    {
        //static string to connect database
        static string myconstring = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        public bool loginCheck(loginBLL l)
        {
            //Creating a boolean variable and initalizing it as false and returning
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //sql query to check login
                string sql = "select * from tbl_users where username=@username and password=@password and user_type=@user_type";
                //create sql command to pass value
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
            //checking the rows in data table
                if (dt.Rows.Count > 0)
                {
                    //Login successful
                    isSuccess = true;
                }
                else
                {
                    //login failed
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
    }
}
