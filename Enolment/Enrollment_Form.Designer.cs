namespace Enrolment
{
    partial class Enrollment_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            cmb_city = new ComboBox();
            label14 = new Label();
            label12 = new Label();
            cmb_region = new ComboBox();
            cmb_brgy = new ComboBox();
            txt_mother = new TextBox();
            label11 = new Label();
            txt_father = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            cmb_prov = new ComboBox();
            label7 = new Label();
            cmb_gender = new ComboBox();
            label6 = new Label();
            date_birth = new DateTimePicker();
            label5 = new Label();
            txt_mi = new TextBox();
            label4 = new Label();
            txt_fname = new TextBox();
            label3 = new Label();
            txt_lname = new TextBox();
            label2 = new Label();
            txt_id = new TextBox();
            label1 = new Label();
            lbl_picture = new Label();
            panel2 = new Panel();
            table_data = new DataGridView();
            button1 = new Button();
            label13 = new Label();
            panel3 = new Panel();
            lbl_desc = new Label();
            cmb_course = new ComboBox();
            label18 = new Label();
            cmb_level = new ComboBox();
            label19 = new Label();
            btn_enroll = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)table_data).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(cmb_city);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(cmb_region);
            panel1.Controls.Add(cmb_brgy);
            panel1.Controls.Add(txt_mother);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txt_father);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cmb_prov);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(cmb_gender);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(date_birth);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_mi);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_fname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_lname);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 460);
            panel1.TabIndex = 0;
            // 
            // cmb_city
            // 
            cmb_city.Font = new Font("Raleway", 8F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_city.FormattingEnabled = true;
            cmb_city.Location = new Point(160, 392);
            cmb_city.Name = "cmb_city";
            cmb_city.Size = new Size(236, 24);
            cmb_city.TabIndex = 26;
            cmb_city.SelectedIndexChanged += cmb_cit_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(5, 304);
            label14.Name = "label14";
            label14.Size = new Size(90, 26);
            label14.TabIndex = 25;
            label14.Text = "Address:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Raleway", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(34, 367);
            label12.Name = "label12";
            label12.Size = new Size(67, 19);
            label12.TabIndex = 24;
            label12.Text = "Province";
            // 
            // cmb_region
            // 
            cmb_region.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmb_region.Font = new Font("Raleway", 8F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_region.FormattingEnabled = true;
            cmb_region.ItemHeight = 16;
            cmb_region.Location = new Point(160, 332);
            cmb_region.Name = "cmb_region";
            cmb_region.Size = new Size(236, 24);
            cmb_region.TabIndex = 23;
            cmb_region.SelectedIndexChanged += cmb_region_SelectedIndexChanged;
            // 
            // cmb_brgy
            // 
            cmb_brgy.Font = new Font("Raleway", 8F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_brgy.FormattingEnabled = true;
            cmb_brgy.Location = new Point(160, 422);
            cmb_brgy.Name = "cmb_brgy";
            cmb_brgy.Size = new Size(236, 24);
            cmb_brgy.TabIndex = 22;
            // 
            // txt_mother
            // 
            txt_mother.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_mother.Location = new Point(160, 194);
            txt_mother.Name = "txt_mother";
            txt_mother.Size = new Size(236, 30);
            txt_mother.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(3, 198);
            label11.Name = "label11";
            label11.Size = new Size(148, 26);
            label11.TabIndex = 20;
            label11.Text = "Mother's Name";
            // 
            // txt_father
            // 
            txt_father.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_father.Location = new Point(160, 158);
            txt_father.Name = "txt_father";
            txt_father.Size = new Size(236, 30);
            txt_father.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(3, 162);
            label10.Name = "label10";
            label10.Size = new Size(141, 26);
            label10.TabIndex = 18;
            label10.Text = "Father's Name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Raleway", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(37, 430);
            label9.Name = "label9";
            label9.Size = new Size(73, 19);
            label9.TabIndex = 16;
            label9.Text = "Barangay";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Raleway", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(34, 397);
            label8.Name = "label8";
            label8.Size = new Size(77, 19);
            label8.TabIndex = 14;
            label8.Text = "City/Mun.";
            // 
            // cmb_prov
            // 
            cmb_prov.Font = new Font("Raleway", 8F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_prov.FormattingEnabled = true;
            cmb_prov.Location = new Point(160, 362);
            cmb_prov.Name = "cmb_prov";
            cmb_prov.Size = new Size(236, 24);
            cmb_prov.TabIndex = 13;
            cmb_prov.SelectedIndexChanged += cmb_prov_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Raleway", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(37, 336);
            label7.Name = "label7";
            label7.Size = new Size(55, 19);
            label7.TabIndex = 12;
            label7.Text = "Region";
            // 
            // cmb_gender
            // 
            cmb_gender.Font = new Font("Raleway", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_gender.FormattingEnabled = true;
            cmb_gender.Items.AddRange(new object[] { "", "MALE", "FEMALE" });
            cmb_gender.Location = new Point(160, 262);
            cmb_gender.Name = "cmb_gender";
            cmb_gender.Size = new Size(236, 30);
            cmb_gender.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 268);
            label6.Name = "label6";
            label6.Size = new Size(78, 26);
            label6.TabIndex = 10;
            label6.Text = "Gender";
            // 
            // date_birth
            // 
            date_birth.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            date_birth.Font = new Font("Raleway SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            date_birth.Location = new Point(160, 230);
            date_birth.Name = "date_birth";
            date_birth.Size = new Size(236, 20);
            date_birth.TabIndex = 9;
            date_birth.Value = new DateTime(2023, 6, 6, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(3, 230);
            label5.Name = "label5";
            label5.Size = new Size(96, 26);
            label5.TabIndex = 8;
            label5.Text = "Birthdate";
            // 
            // txt_mi
            // 
            txt_mi.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_mi.Location = new Point(160, 122);
            txt_mi.Name = "txt_mi";
            txt_mi.Size = new Size(236, 30);
            txt_mi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(3, 126);
            label4.Name = "label4";
            label4.Size = new Size(133, 26);
            label4.TabIndex = 6;
            label4.Text = "Middle Name";
            // 
            // txt_fname
            // 
            txt_fname.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_fname.Location = new Point(160, 86);
            txt_fname.Name = "txt_fname";
            txt_fname.Size = new Size(236, 30);
            txt_fname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 90);
            label3.Name = "label3";
            label3.Size = new Size(102, 26);
            label3.TabIndex = 4;
            label3.Text = "Firstname";
            // 
            // txt_lname
            // 
            txt_lname.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_lname.Location = new Point(160, 51);
            txt_lname.Name = "txt_lname";
            txt_lname.Size = new Size(236, 30);
            txt_lname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(101, 26);
            label2.TabIndex = 2;
            label2.Text = "Lastname";
            // 
            // txt_id
            // 
            txt_id.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_id.Location = new Point(160, 15);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(236, 30);
            txt_id.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(110, 26);
            label1.TabIndex = 0;
            label1.Text = "ID Number";
            // 
            // lbl_picture
            // 
            lbl_picture.BorderStyle = BorderStyle.Fixed3D;
            lbl_picture.Location = new Point(135, 128);
            lbl_picture.Name = "lbl_picture";
            lbl_picture.Size = new Size(236, 236);
            lbl_picture.TabIndex = 22;
            lbl_picture.Text = "label12";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGreen;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(table_data);
            panel2.Location = new Point(12, 478);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 237);
            panel2.TabIndex = 22;
            // 
            // table_data
            // 
            table_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table_data.Location = new Point(5, 3);
            table_data.Name = "table_data";
            table_data.RowTemplate.Height = 25;
            table_data.Size = new Size(802, 229);
            table_data.TabIndex = 0;
            table_data.CellClick += table_data_CellClick;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(10, 151);
            button1.Name = "button1";
            button1.Size = new Size(119, 29);
            button1.TabIndex = 24;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(4, 122);
            label13.Name = "label13";
            label13.Size = new Size(106, 26);
            label13.TabIndex = 23;
            label13.Text = "ID Picture:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGreen;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbl_desc);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(cmb_course);
            panel3.Controls.Add(lbl_picture);
            panel3.Controls.Add(label18);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(cmb_level);
            panel3.Controls.Add(label19);
            panel3.Location = new Point(432, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(392, 387);
            panel3.TabIndex = 22;
            // 
            // lbl_desc
            // 
            lbl_desc.Font = new Font("Raleway SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_desc.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_desc.Location = new Point(108, 86);
            lbl_desc.Name = "lbl_desc";
            lbl_desc.Size = new Size(263, 26);
            lbl_desc.TabIndex = 25;
            lbl_desc.Text = " ";
            // 
            // cmb_course
            // 
            cmb_course.Font = new Font("Raleway", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_course.FormattingEnabled = true;
            cmb_course.Items.AddRange(new object[] { "", "MALE", "FEMALE" });
            cmb_course.Location = new Point(108, 47);
            cmb_course.Name = "cmb_course";
            cmb_course.Size = new Size(71, 26);
            cmb_course.TabIndex = 13;
            cmb_course.SelectedIndexChanged += cmb_course_SelectedIndexChanged;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Raleway", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label18.Location = new Point(4, 51);
            label18.Name = "label18";
            label18.Size = new Size(65, 22);
            label18.TabIndex = 12;
            label18.Text = "Course";
            // 
            // cmb_level
            // 
            cmb_level.Font = new Font("Raleway", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_level.FormattingEnabled = true;
            cmb_level.Items.AddRange(new object[] { "I", "II", "III", "IV" });
            cmb_level.Location = new Point(108, 15);
            cmb_level.Name = "cmb_level";
            cmb_level.Size = new Size(71, 26);
            cmb_level.TabIndex = 11;
            cmb_level.SelectedIndexChanged += cmb_level_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Raleway", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(4, 15);
            label19.Name = "label19";
            label19.Size = new Size(92, 22);
            label19.TabIndex = 10;
            label19.Text = "Year Level";
            // 
            // btn_enroll
            // 
            btn_enroll.BackColor = Color.LightGoldenrodYellow;
            btn_enroll.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_enroll.ForeColor = SystemColors.HotTrack;
            btn_enroll.ImageAlign = ContentAlignment.TopCenter;
            btn_enroll.Location = new Point(711, 405);
            btn_enroll.Name = "btn_enroll";
            btn_enroll.Size = new Size(113, 67);
            btn_enroll.TabIndex = 25;
            btn_enroll.Text = "Enrol";
            btn_enroll.UseVisualStyleBackColor = false;
            btn_enroll.Click += button2_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HotTrack;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(432, 405);
            button2.Name = "button2";
            button2.Size = new Size(113, 71);
            button2.TabIndex = 26;
            button2.Text = "Update Details";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.TopCenter;
            button3.Location = new Point(551, 405);
            button3.Name = "button3";
            button3.Size = new Size(113, 71);
            button3.TabIndex = 27;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Enrollment_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(836, 725);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btn_enroll);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Enrollment_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            FormClosed += Enrollment_Form_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)table_data).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txt_mi;
        private Label label4;
        private TextBox txt_fname;
        private Label label3;
        private TextBox txt_lname;
        private Label label2;
        private TextBox txt_id;
        private Label label1;
        private ComboBox cmb_gender;
        private Label label6;
        private DateTimePicker date_birth;
        private Label label5;
        private TextBox txt_mother;
        private Label label11;
        private TextBox txt_father;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox cmb_prov;
        private Label label7;
        private Label lbl_picture;
        private Panel panel2;
        private Button button1;
        private Label label13;
        private Panel panel3;
        private ComboBox cmb_course;
        private Label label18;
        private ComboBox cmb_level;
        private Label label19;
        private Button btn_enroll;
        private ComboBox cmb_brgy;
        private Label label14;
        private Label label12;
        private ComboBox cmb_region;
        private ComboBox cmb_city;
        private Label lbl_desc;
        private DataGridView table_data;
        private Button button2;
        private Button button3;
    }
}