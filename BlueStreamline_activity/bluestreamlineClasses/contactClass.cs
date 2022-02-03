using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueStreamline_activity.bluestreamlineClasses
{
    class contactClass
    {
        //getter and setter properties
        //acts as data carrier in the app

        public string Nume { get; set; }

        public string Parola { get; set; }

        public int TotalTimp { get; set; }

        public int NrZile { get; set; }

        public int Status { get; set; }

        public int userID { get; set; }

        public int Ora { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //selectiong data from db
        public DataTable Select()
        {
            //Step 1: db connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //step 2: writing sql query
                string sql = "SELECT * FROM tbl_bluestreamline";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //creating data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //inserting data into db
        public bool Insert (contactClass c)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //step 1: connect db
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //step 2: sql query to insert data
                string sql = "INSERT INFO tbl_bluestreamline (Nume, Parola, TotalTimp, NrZile, Status, Ora) VALUES (@Nume, @Parola, @TotalTimp, @NrZile, @Status, @Ora)";
                //sql command using sql and cmd
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data
                cmd.Parameters.AddWithValue("@Nume", c.Nume);
                cmd.Parameters.AddWithValue("@Parola", c.Parola);
                cmd.Parameters.AddWithValue("@TotalTimp", c.TotalTimp);
                cmd.Parameters.AddWithValue("@NrZile", c.NrZile);
                cmd.Parameters.AddWithValue("@Status", c.Status);
                cmd.Parameters.AddWithValue("@Ora", c.Ora);

                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows will be greater than zero else will be xero
                if(rows>0)
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

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to update data in database
        public bool Update(contactClass c)
        {
            //create a default retun type and set its default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to update data in db
                string sql = "UPDATE tbl_bluestreamline SET Nume=@Nume, Parola=@Parola, TotalTimp=@TotalTimp, NrZile=@NrZile, Status=@Status, Ora=@Ora WHERE userID=@userID";

                //create sql command
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create parameters to add value
                cmd.Parameters.AddWithValue("@Nume", c.Nume);
                cmd.Parameters.AddWithValue("@Parola", c.Parola);
                cmd.Parameters.AddWithValue("@TotalTimp", c.TotalTimp);
                cmd.Parameters.AddWithValue("@NrZile", c.NrZile);
                cmd.Parameters.AddWithValue("@Status", c.Status);
                cmd.Parameters.AddWithValue("@Ora", c.Ora);
                cmd.Parameters.AddWithValue("@userID", c.userID);

                //open db connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value will be >0 else 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                    isSuccess = false;
            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //method to delete data from database
        public bool Delete(contactClass c)
        {
            //create a default return value and set its value to false
            bool isSuccess = false;
            //creaste sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to delete data
                string sql = "DELETE FROM tbl_bluestreamline WHERE userID=@userID";

                //creating sql command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", c.userID);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //if the query runs successfully then the value will be >0 else 0
                if (rows > 0)
                    isSuccess = true;
                else
                    isSuccess = false;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                //close connection
                conn.Close();
            }
            return isSuccess;
        }
    }
}
