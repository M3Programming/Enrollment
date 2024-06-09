using NetVips.Extensions;
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

    public partial class Enrollment_Form : Form
    {
        private static SqlConnection conn = default!;
        OpenFileDialog file = new OpenFileDialog();


        public Enrollment_Form()
        {
            InitializeComponent();
            database_connection();
            populate_region();
            Table_Data();
        }

        private void database_connection()
        {
            string dburl = @"Data Source=DESKTOP-J25475E;
                            Initial Catalog=mydatabase;
                            User ID=admin;Password=1234";

            conn = new SqlConnection(dburl);
        }

        private void Table_Data()
        {
            try
            {
                String sqlquery = "SELECT * FROM StudentInformation";
                DataTable table = new DataTable("Student_Info");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlquery, conn);
                adapter.Fill(table);
                table_data.DataSource = table;


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

        private void populate_region()
        {
            try
            {
                cmb_brgy.ResetText();
                cmb_brgy.Items.Clear();
                cmb_prov.ResetText();
                cmb_prov.Items.Clear();
                cmb_city.ResetText();
                cmb_city.Items.Clear();
                String sqlquery = "SELECT regDesc FROM add_region";
                conn.Open();
                SqlCommand pst = new SqlCommand(sqlquery, conn);
                SqlDataReader rs = pst.ExecuteReader();
                while (rs.Read())
                {
                    cmb_region.Items.Add(rs[0]);

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
        }

        private void Enrollment_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void cmb_region_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_prov.ResetText();
                cmb_prov.Items.Clear();
                cmb_brgy.ResetText();
                cmb_brgy.Items.Clear();
                cmb_city.ResetText();
                cmb_city.Items.Clear();
                conn.Open();
                Object region = cmb_region.SelectedItem;
                String sqlquery = "SELECT add_province.provDesc " +
                    "FROM add_province " +
                    "INNER JOIN add_region " +
                    "ON add_province.regCode = add_region.regCode " +
                    "WHERE add_region.regDesc = '" + region.ToString() + "'";
                SqlCommand pst = new SqlCommand(sqlquery, conn);
                SqlDataReader rs = pst.ExecuteReader();
                while (rs.Read())
                {
                    cmb_prov.Items.Add(rs.GetString(0));
                }
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

        private void cmb_cit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_brgy.ResetText();
                cmb_brgy.Items.Clear();
                conn.Open();
                Object city = cmb_city.SelectedItem;
                String sqlquery = "SELECT add_barangay.brgyDesc " +
                    "FROM add_barangay " +
                    "INNER JOIN add_city " +
                    "ON add_barangay.citymunCode = add_city.citymunCode " +
                    "WHERE add_city.citymunDesc = '" + city.ToString() + "'";
                SqlCommand pst = new SqlCommand(sqlquery, conn);
                SqlDataReader rs = pst.ExecuteReader();
                while (rs.Read())
                {
                    cmb_brgy.Items.Add(rs.GetString(0));
                }
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

        private void cmb_prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_city.ResetText();
                cmb_city.Items.Clear();
                cmb_brgy.ResetText();
                cmb_brgy.Items.Clear();

                conn.Open();
                Object province = cmb_prov.SelectedItem;
                String sqlquery = "SELECT add_city.citymunDesc " +
                    "FROM add_city " +
                    "INNER JOIN add_province " +
                    "ON add_city.provCode = add_province.provCode " +
                    "WHERE add_province.provDesc = '" + province.ToString() + "'";
                SqlCommand pst = new SqlCommand(sqlquery, conn);
                SqlDataReader rs = pst.ExecuteReader();
                while (rs.Read())
                {
                    cmb_city.Items.Add(rs.GetString(0));
                }
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

        private void cmb_level_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_course.ResetText();
                cmb_course.Items.Clear();

                conn.Open();
                String sqlquery = "SELECT * FROM Course";
                SqlCommand pst = new SqlCommand(sqlquery, conn);
                SqlDataReader rs = pst.ExecuteReader();
                while (rs.Read())
                {
                    cmb_course.Items.Add(rs.GetString(1).Trim());
                }
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

        private void cmb_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string course = cmb_course.SelectedItem.ToString() ?? "";

                conn.Open();
                String sqlquery = "SELECT * FROM Course WHERE Course_Code = '" + course.TrimEnd() + "'";
                SqlCommand pst = new SqlCommand(sqlquery, conn);
                SqlDataReader rs = pst.ExecuteReader();
                if (rs.Read())
                {
                    lbl_desc.Text = rs.GetString(2);
                }
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

        private void button1_Click(object sender, EventArgs e)
        {
            file.Filter = "Image Files(*.jpg;*.png;*.bmp|*.jpg;*.jpeg;)";
            if (file.ShowDialog() == DialogResult.OK)
            {
                lbl_picture.Text = "";
                NetVips.Image img = NetVips.Image.Thumbnail(file.FileName, lbl_picture.Width, lbl_picture.Height);
                Image image = img.ToBitmap();
                lbl_picture.Image = image;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;
            SqlCommand pst;
            string id = txt_id.Text;
            string lname = txt_lname.Text;
            string fname = txt_fname.Text;
            string mname = txt_mi.Text;
            string father = txt_father.Text;
            string mother = txt_mother.Text;
            DateTime dt = date_birth.Value.Date;
            string gender = cmb_gender.Text;
            string add_region = cmb_region.SelectedItem.ToString() ?? "";
            string add_province = cmb_prov.SelectedItem.ToString() ?? "";
            string add_city = cmb_city.SelectedItem.ToString() ?? "";
            string add_brgy = cmb_brgy.SelectedItem.ToString() ?? "";
            string yrlvl = cmb_level.SelectedItem.ToString() ?? "";
            string coursecode = cmb_course.SelectedItem.ToString() ?? "";



            if (txt_id.Text == "" | txt_lname.Text == "" || txt_fname.Text == "" || txt_mi.Text == "" || txt_father.Text == "" || txt_mother.Text == "" ||
                cmb_gender.SelectedIndex == -1 || cmb_region.SelectedIndex == -1 || cmb_prov.SelectedIndex == -1 || cmb_city.SelectedIndex == -1 ||
                cmb_brgy.SelectedIndex == -1 || cmb_level.SelectedIndex == -1 || cmb_course.SelectedIndex == -1 || lbl_picture.Image == null)
            {
                MessageBox.Show("All data is required");
            }
            else
            {
                try
                {

                    fs = new FileStream(file.FileName, FileMode.Open, FileAccess.Read);
                    br = new BinaryReader(fs);
                    byte[] image = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                    string sqlquery = "INSERT INTO StudentInformation " +
                        "VALUES (@id,@lname,@fname,@mname,@father,@mother,@birthdate,@gender,@region,@province,@city,@brgy,@yrlvl,@course,@public_image)";
                    pst = new SqlCommand(sqlquery, conn);
                    conn.Open();
                    pst.Parameters.AddWithValue("@id", id);
                    pst.Parameters.AddWithValue("@lname", lname);
                    pst.Parameters.AddWithValue("@fname", fname);
                    pst.Parameters.AddWithValue("@mname", mname);
                    pst.Parameters.AddWithValue("@father", father);
                    pst.Parameters.AddWithValue("@mother", mother);
                    pst.Parameters.AddWithValue("@birthdate", dt);
                    pst.Parameters.AddWithValue("@gender", gender);
                    pst.Parameters.AddWithValue("@region", add_region);
                    pst.Parameters.AddWithValue("@province", add_province);
                    pst.Parameters.AddWithValue("@city", add_city);
                    pst.Parameters.AddWithValue("@brgy", add_brgy);
                    pst.Parameters.AddWithValue("@yrlvl", yrlvl);
                    pst.Parameters.AddWithValue("@course", coursecode);
                    pst.Parameters.AddWithValue("@public_image", image);
                    int records = pst.ExecuteNonQuery();
                    if (records > 0)
                    {
                        Table_Data();
                        MessageBox.Show("Student enrolled Successfully");
                        lbl_picture.Text = "";
                        lbl_picture.Image = null;
                        txt_id.Text = "";
                        txt_lname.Text = "";
                        txt_fname.Text = "";
                        txt_mi.Text = "";
                        txt_father.Text = "";
                        txt_mother.Text = "";
                        date_birth.ResetText();
                        cmb_gender.ResetText();
                        cmb_region.ResetText();
                        cmb_prov.ResetText();
                        cmb_city.ResetText();
                        cmb_brgy.ResetText();
                        cmb_level.ResetText();
                        cmb_course.ResetText();
                        cmb_gender.Items.Clear();
                        cmb_region.Items.Clear();
                        cmb_prov.Items.Clear();
                        cmb_city.Items.Clear();
                        cmb_brgy.Items.Clear();
                        cmb_level.Items.Clear();
                        cmb_course.Items.Clear();

                    }
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
        }

        private void table_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SqlCommand pst;
                SqlDataReader rs;
                DataGridViewRow row = table_data.Rows[e.RowIndex];
                String id = row.Cells["idno"].Value.ToString() ?? "";
                conn.Open();
                string sqlquery = "SELECT * FROM StudentInformation WHERE idno = '" + id.Trim() + "'";
                pst = new SqlCommand(sqlquery, conn);
                rs = pst.ExecuteReader();
                while (rs.Read())
                {
                    if (rs.IsDBNull("ID_Picture"))
                    {
                        txt_id.Text = rs.GetString(0);
                        txt_lname.Text = rs.GetString(1);
                        txt_fname.Text = rs.GetString(2);
                        txt_mi.Text = rs.GetString(3);
                        txt_father.Text = rs.GetString(4);
                        txt_mother.Text = rs.GetString(5);
                        date_birth.Value = rs.GetDateTime(6);
                        cmb_gender.Text = rs.GetString(7);
                        cmb_region.Text = rs.GetString(8);
                        cmb_prov.Text = rs.GetString(9);
                        cmb_city.Text = rs.GetString(10);
                        cmb_brgy.Text = rs.GetString(11);
                        cmb_level.Text = rs.GetString(12);
                        cmb_course.Text = rs.GetString(13);
                        lbl_picture.Image = null;
                    }
                    else
                    {
                        byte[] image = (byte[])rs["Id_Picture"];
                        MemoryStream stream = new MemoryStream(image);
                        System.Drawing.Image temp = System.Drawing.Image.FromStream(stream);
                        NetVips.Image i = temp.ToVips();
                        string path = "C:\\Users\\MJ\\Pictures\\img\\public_image.jpg";
                        i.WriteToFile(path);
                        NetVips.Image img1 = NetVips.Image.Thumbnail(path, lbl_picture.Width, lbl_picture.Height);
                        System.Drawing.Image img;
                        img = img1.ToBitmap();
                        lbl_picture.Text = "";
                        lbl_picture.Image = img;
                        txt_id.Text = rs.GetString(0);
                        txt_lname.Text = rs.GetString(1);
                        txt_fname.Text = rs.GetString(2);
                        txt_mi.Text = rs.GetString(3);
                        txt_father.Text = rs.GetString(4);
                        txt_mother.Text = rs.GetString(5);
                        date_birth.Value = rs.GetDateTime(6);
                        cmb_gender.Text = rs.GetString(7);
                        cmb_region.Text = rs.GetString(8);
                        cmb_prov.Text = rs.GetString(9);
                        cmb_city.Text = rs.GetString(10);
                        cmb_brgy.Text = rs.GetString(11);
                        cmb_level.Text = rs.GetString(12);
                        cmb_course.Text = rs.GetString(13);
                    }

                }
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

        private void button2_Click_1(object sender, EventArgs e)
        {

            string id = txt_id.Text.Trim();
            string lname = txt_lname.Text;
            string fname = txt_fname.Text;
            string mname = txt_mi.Text;
            string father = txt_father.Text;
            string mother = txt_mother.Text;
            DateTime dt = date_birth.Value.Date;
            string gender = cmb_gender.SelectedItem.ToString() ?? "";
            string add_region = cmb_region.SelectedItem.ToString() ?? "";
            string add_province = cmb_prov.SelectedItem.ToString() ?? "";
            string add_city = cmb_city.SelectedItem.ToString() ?? "";
            string add_brgy = cmb_brgy.SelectedItem.ToString() ?? "";
            string yrlvl = cmb_level.SelectedItem.ToString() ?? "";
            string coursecode = cmb_course.SelectedItem.ToString() ?? "";



            try
            {

                FileStream fs;
                BinaryReader br;
                SqlCommand pst;
                fs = new FileStream(file.FileName, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                byte[] image = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                string sqlquery = "UPDATE StudentInformation SET idno = @id, LastName=@lname," +
                    "FirstName=@fname,MiddleName=@mname,Father_Name=@father,Mother_Name=@mother," +
                    "Birth_Date=@birthdate,Gender=@gender,Address_Region=@region,Address_Province=@province," +
                    "Address_City=@city,Address_Brgy=@brgy,YearLevel=@yrlvl,Department=@course,ID_Picture=@image " +
                    "WHERE idno=@id2";
                pst = new SqlCommand(sqlquery, conn);
                conn.Open();
                pst.Parameters.AddWithValue("@id", id);
                pst.Parameters.AddWithValue("@lname", lname);
                pst.Parameters.AddWithValue("@fname", fname);
                pst.Parameters.AddWithValue("@mname", mname);
                pst.Parameters.AddWithValue("@father", father);
                pst.Parameters.AddWithValue("@mother", mother);
                pst.Parameters.AddWithValue("@birthdate", dt);
                pst.Parameters.AddWithValue("@gender", gender);
                pst.Parameters.AddWithValue("@region", add_region);
                pst.Parameters.AddWithValue("@province", add_province);
                pst.Parameters.AddWithValue("@city", add_city);
                pst.Parameters.AddWithValue("@brgy", add_brgy);
                pst.Parameters.AddWithValue("@yrlvl", yrlvl);
                pst.Parameters.AddWithValue("@course", coursecode);
                pst.Parameters.AddWithValue("@image", image);
                pst.Parameters.AddWithValue("@id2", id);
                int records = pst.ExecuteNonQuery();
                if (records > 0)
                {
                    MessageBox.Show("Data Updated Successfully");
                    Table_Data();
                }


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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                string id = txt_id.Text;
                String sqlquery = "DELETE FROM StudentInformation WHERE idno=@id";
                SqlCommand pst = new SqlCommand(sqlquery, conn);
                pst.Parameters.AddWithValue("@id", id);
                conn.Open();
                DialogResult dialogResult = MessageBox.Show("Are you sure, you want to delete the records?", "Delete Records",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    int deleted = pst.ExecuteNonQuery();
                    if (deleted > 0)
                    {
                        MessageBox.Show("Record deleted!");
                        Table_Data();
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
        }
}
