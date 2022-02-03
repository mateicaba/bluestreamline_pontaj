using BlueStreamline_activity.bluestreamlineClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private void BlueStreamline_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add button
            //get the value from the input fields 
            c.Nume = textboxNume.Text;
            c.Parola = textBoxParola.Text;
            c.NrZile = 0;
            c.Status = 1;
            c.TotalTimp = 0;
            c.Ora = 0; //de facut

            //inserting to db
            bool success = c.Insert(c);
            if(success == true)
            {
                //successfully inserted
                MessageBox.Show("New user inserted successfully");
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
    }
}
