using BlueStreamline_activity.bluestreamlineClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueStreamline_activity
{
    public partial class BlueStreamline : Form
    {
        public BlueStreamline()
        {
            InitializeComponent();
        }

        contactClass c = new contactClass();
        
        DateTime currentDateTime = DateTime.Now;
        private void BlueStreamline_Load(object sender, EventArgs e)
        {

        }
        private int calculateTime(string oldTime, string newTime)
        {
            long minutes = 0;
            long time1 = long.Parse(oldTime);
            long time2 = long.Parse(newTime);
            long minute1 = time1 % 100;
            long minute2 = time2 % 100;
            time1 /= 100;
            time2 /= 100;
            long hour1 = time1 % 100 * 60;
            long hour2 = time2 % 100 * 60;
            time1 /= 100;
            time2 /= 100;
            long day1 = time1 % 100 * 1440;
            long day2 = time2 % 100 * 1440;
            time1 /= 100;
            time2 /= 100;
            long month1 = time1 % 100 * 44640;
            long month2 = time1 % 100 * 44640;

            minutes = month2 - month1 + day2 - day1 + hour2 - hour1 + minute2 - minute1;

            int v = (int)minutes;
            return v;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            c.Nume = textboxNume.Text;
            c.Parola = textBoxParola.Text;
            //var con = ConfigurationManager.ConnectionStrings[myconnstr].ToString();

            //creating aux to extract data from db
            contactClass m = new contactClass();
            using (SqlConnection myConnection = new SqlConnection(myconnstr))
            {
                string oString = "SELECT * FROM tbl_bluestreamline WHERE Nume=@Nume";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Nume", c.Nume);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        m.Nume = oReader["Nume"].ToString();
                        m.Parola = oReader["Parola"].ToString();
                        m.NrZile = int.Parse(oReader["NrZile"].ToString());
                        m.Status = int.Parse(oReader["Status"].ToString());
                        m.TotalTimp = int.Parse(oReader["TotalTimp"].ToString());
                        m.Ora = oReader["Ora"].ToString();
                    }

                    myConnection.Close();
                }
            }
            c.NrZile = m.NrZile;
            c.Status = 1;
            c.TotalTimp = m.TotalTimp;
            c.Ora = currentDateTime.ToString("yyMMddHHmm");

            //update in db
            bool success = c.Update(c);
            if(success==true)
            {
                //updated successfully
                MessageBox.Show("User has been successfully Updated");

            }
            else
                MessageBox.Show("User failed to update");

            /*c.NrZile++;
            c.Status = 1;
            c.TotalTimp = c.TotalTimp + calculateTime(c.Ora, currentDateTime.ToString("yyMMddHHmm"));
            c.Ora = currentDateTime.ToString("yyMMddHHmm");*/
        }
        private void button2_Click(object sender, EventArgs e)
        {
            c.Nume = textboxNume.Text;
            c.Parola = textBoxParola.Text;
           // var con = ConfigurationManager.ConnectionStrings[myconnstr].ToString();

            //creating aux to extract data from db
            contactClass m = new contactClass();
            using (SqlConnection myConnection = new SqlConnection(myconnstr))
            {
                string oString = "SELECT * FROM tbl_bluestreamline WHERE Nume=@Nume";
                SqlCommand oCmd = new SqlCommand(oString, myConnection);
                oCmd.Parameters.AddWithValue("@Nume", c.Nume);
                myConnection.Open();
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        m.Nume = oReader["Nume"].ToString();
                        m.Parola = oReader["Parola"].ToString();
                        m.NrZile = int.Parse(oReader["NrZile"].ToString());
                        m.Status = int.Parse(oReader["Status"].ToString());
                        m.TotalTimp = int.Parse(oReader["TotalTimp"].ToString());
                        m.Ora = oReader["Ora"].ToString();
                    }

                    myConnection.Close();
                }
            }
            c.NrZile = m.NrZile + 1;
            c.Status = 0;
            c.TotalTimp = m.TotalTimp + calculateTime(c.Ora, currentDateTime.ToString("yyMMddHHmm"));
            c.Ora = currentDateTime.ToString("yyMMddHHmm");

            //update in db
            bool success = c.Update(c);
            if (success == true)
            {
                //updated successfully
                MessageBox.Show("User has been successfully Updated");

            }
            else
                MessageBox.Show("User failed to update");

        }
        private void button3_Click(object sender, EventArgs e)
        {
            //add button
            //get the value from the input fields 
            c.Nume = textboxNume.Text;
            c.Parola = textBoxParola.Text;
            c.NrZile = 
            c.Status = 1;
            c.TotalTimp = 0;
            c.Ora = currentDateTime.ToString("yyMMddHHmm");

            //inserting to db
            bool success = c.Insert(c);
            if(success == true)
            {
                //successfully inserted
                MessageBox.Show("New user inserted successfully");
                //clear fields
                Clear();
            }
            else
            {
                //failed to add user
                MessageBox.Show("Failed to add user");
            }
            //load on gridview
            DataTable dt = c.Select();
            dgvUser.DataSource = dt;


        }

        private void User_Load(object sender, EventArgs e)
        {
            //load on gridview
            DataTable dt = c.Select();
            dgvUser.DataSource = dt;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //x button
            this.Close();
        }

        //method to clear fields
        public void Clear()
        {
            textboxNume.Text = "";
            textBoxParola.Text = "";
        }

        static string myconnstr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = textBoxSearch.Text;

            SqlConnection conn = new SqlConnection(myconnstr);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_bluestreamline WHERE Nume LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvUser.DataSource = dt;
        }

        private void dgvUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from gridview to textbox
            int rowIndex = e.RowIndex;
            textBox1.Text = dgvUser.Rows[rowIndex].Cells[0].Value.ToString();
            textBox2.Text = dgvUser.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
