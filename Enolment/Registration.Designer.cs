namespace Enrolment
{
    partial class Registration
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
            cmb_role = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            txt_lastname = new TextBox();
            label5 = new Label();
            txt_mi = new TextBox();
            label4 = new Label();
            txt_firstname = new TextBox();
            label3 = new Label();
            txt_password = new TextBox();
            label2 = new Label();
            txt_username = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleGreen;
            panel1.Controls.Add(cmb_role);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_lastname);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_mi);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_firstname);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_password);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(16, 18);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 276);
            panel1.TabIndex = 0;
            // 
            // cmb_role
            // 
            cmb_role.Font = new Font("Raleway", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            cmb_role.FormattingEnabled = true;
            cmb_role.Items.AddRange(new object[] { "Admin", "User" });
            cmb_role.Location = new Point(123, 191);
            cmb_role.Name = "cmb_role";
            cmb_role.Size = new Size(211, 30);
            cmb_role.TabIndex = 14;
            // 
            // button2
            // 
            button2.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(123, 228);
            button2.Name = "button2";
            button2.Size = new Size(102, 36);
            button2.TabIndex = 13;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(232, 228);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 12;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 196);
            label6.Name = "label6";
            label6.Size = new Size(100, 26);
            label6.TabIndex = 10;
            label6.Text = "User Role";
            // 
            // txt_lastname
            // 
            txt_lastname.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_lastname.Location = new Point(123, 155);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(211, 30);
            txt_lastname.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(13, 159);
            label5.Name = "label5";
            label5.Size = new Size(101, 26);
            label5.TabIndex = 8;
            label5.Text = "Lastname";
            // 
            // txt_mi
            // 
            txt_mi.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_mi.Location = new Point(123, 119);
            txt_mi.Name = "txt_mi";
            txt_mi.Size = new Size(211, 30);
            txt_mi.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 123);
            label4.Name = "label4";
            label4.Size = new Size(41, 26);
            label4.TabIndex = 6;
            label4.Text = "M.I.";
            // 
            // txt_firstname
            // 
            txt_firstname.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_firstname.Location = new Point(123, 83);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(211, 30);
            txt_firstname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 87);
            label3.Name = "label3";
            label3.Size = new Size(102, 26);
            label3.TabIndex = 4;
            label3.Text = "Firstname";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(123, 48);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '●';
            txt_password.Size = new Size(211, 30);
            txt_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(13, 52);
            label2.Name = "label2";
            label2.Size = new Size(100, 26);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.Location = new Point(123, 12);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(211, 30);
            txt_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 26);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(374, 311);
            Controls.Add(panel1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            FormClosed += Registration_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label6;
        private TextBox txt_lastname;
        private Label label5;
        private TextBox txt_mi;
        private Label label4;
        private TextBox txt_firstname;
        private Label label3;
        private TextBox txt_password;
        private Label label2;
        private TextBox txt_username;
        private Label label1;
        private ComboBox cmb_role;

    }
}