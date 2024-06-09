using Enolment;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment
{
    public partial class Registration : Form
    {

        private static SqlConnection? conn;

        public Registration()
        {
            InitializeComponent();
            database_connection();
        }

        private void database_connection()
        {
            string dburl = @"Data Source=DESKTOP-J25475E;
                            Initial Catalog=mydatabase;
                            User ID=admin;Password=1234";

            conn = new SqlConnection(dburl);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userlogin userlogin = new Userlogin();
            {
                userlogin.Show();
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uname = txt_username.Text;
                string upass = txt_password.Text;
                string fname = txt_firstname.Text;
                string mi = txt_mi.Text;
                string lname = txt_lastname.Text;
                Object role = cmb_role.SelectedItem;
                String sqlquery = "INSERT INTO userlogin (username,userpassword,user_firstname," +
                    "user_mi,user_lastname,user_role) VALUES (@param1,@param2,@param3,@param4," +
                    "@param5,@param6)";
                conn.Open();
                SqlCommand pst = new SqlCommand(sqlquery, conn);
                pst.Parameters.AddWithValue("@param1", uname);
                pst.Parameters.AddWithValue("@param2", upass);
                pst.Parameters.AddWithValue("@param3", fname);
                pst.Parameters.AddWithValue("@param4", mi);
                pst.Parameters.AddWithValue("@param5", lname);
                pst.Parameters.AddWithValue("@param6", role.ToString());
                pst.ExecuteNonQuery();
                MessageBox.Show("Registration Successful");
                txt_username.Text = "";
                txt_password.Text = "";
                txt_firstname.Text = "";
                txt_mi.Text = "";
                txt_lastname.Text = "";
                cmb_role.SelectedItem = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }




        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
