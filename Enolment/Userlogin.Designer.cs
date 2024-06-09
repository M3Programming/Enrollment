namespace Enolment
{
    partial class Userlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.ForestGreen;
            label1.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 16);
            label1.Name = "label1";
            label1.Size = new Size(104, 26);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.ForestGreen;
            label2.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(8, 52);
            label2.Name = "label2";
            label2.Size = new Size(100, 26);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_username.Location = new Point(129, 12);
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Enter Username";
            txt_username.Size = new Size(226, 30);
            txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txt_password.Location = new Point(129, 48);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '●';
            txt_password.PlaceholderText = "Enter Password";
            txt_password.Size = new Size(226, 30);
            txt_password.TabIndex = 3;
            txt_password.KeyPress += CheckEnter;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.Location = new Point(239, 84);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(116, 36);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.TextAlign = ContentAlignment.TopCenter;
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(129, 84);
            button1.Name = "button1";
            button1.Size = new Size(102, 36);
            button1.TabIndex = 13;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Userlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            ClientSize = new Size(362, 130);
            Controls.Add(button1);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Userlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Userlogin";
            TransparencyKey = Color.FromArgb(128, 255, 128);
            FormClosed += Userlogin_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private Button button1;
    }
}