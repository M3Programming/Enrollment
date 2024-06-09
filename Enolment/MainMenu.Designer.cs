namespace Enolment
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(126, 21);
            label1.Name = "label1";
            label1.Size = new Size(395, 51);
            label1.TabIndex = 0;
            label1.Text = "M3 State University";
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.Image = Enrolment.Properties.Resources.student;
            button1.Location = new Point(32, 101);
            button1.Name = "button1";
            button1.Size = new Size(153, 158);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Beige;
            label2.Location = new Point(32, 262);
            label2.Name = "label2";
            label2.Size = new Size(153, 26);
            label2.TabIndex = 2;
            label2.Text = "Enrol Student";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.ForestGreen;
            button2.Font = new Font("Raleway", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(502, 325);
            button2.Name = "button2";
            button2.Size = new Size(111, 42);
            button2.TabIndex = 3;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.PeachPuff;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(221, 101);
            button3.Name = "button3";
            button3.Size = new Size(153, 158);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Font = new Font("Raleway", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Beige;
            label3.Location = new Point(221, 262);
            label3.Name = "label3";
            label3.Size = new Size(153, 52);
            label3.TabIndex = 5;
            label3.Text = "Student Information";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(625, 379);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}