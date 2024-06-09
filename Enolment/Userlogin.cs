using Enrolment;
using System.Data.SqlClient;

namespace Enolment
{
    public partial class Userlogin : Form
    {
        private static SqlConnection conn = default!;
        public Userlogin()
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

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login_Click(sender, e, conn);
        }

        private void btn_login_Click(object sender, EventArgs e, SqlConnection? conn)
        {
            try
            {
                string uname = txt_username.Text;
                string upass = txt_password.Text;
                if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(upass))
                {
                    MessageBox.Show("All Textfields should not be blank!");
                }
                else
                {
                    string sqlquery = "SELECT * FROM userlogin " +
                        "WHERE username = '" + uname + "' AND userpassword = '" + upass + "'";
                    conn.Open();
                    SqlCommand pst = new SqlCommand(sqlquery, conn);
                    SqlDataReader rs = pst.ExecuteReader();
                    if (rs.Read())
                    {
                        MessageBox.Show("Login Successful");
                        conn.Close();
                        this.Hide();
                        Form2 form2 = new Form2();
                        {
                            form2.ShowDialog();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                        txt_username.Text = "";
                        txt_password.Text = "";
                    }
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string uname = txt_username.Text;
                string upass = txt_password.Text;
                if (string.IsNullOrEmpty(uname) || string.IsNullOrEmpty(upass))
                {
                    MessageBox.Show("All Textfields should not be blank!");
                }
                else
                {
                    conn.Open();
                    string sqlquery = "SELECT * FROM userlogin " +
                        "WHERE username = '" + uname + "' AND userpassword = '" + upass + "'";
                    SqlCommand pst = new SqlCommand(sqlquery, conn);
                    SqlDataReader rs = pst.ExecuteReader();
                    if (rs.Read())
                    {
                        MessageBox.Show("Login Successful");
                        conn.Close();
                        this.Hide();
                        Form2 form2 = new Form2();
                        {
                            form2.ShowDialog();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                        txt_username.Text = "";
                        txt_password.Text = "";
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            {
                reg.Show();
            }
            this.Hide();
        }

        private void Userlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}