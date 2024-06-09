using Enrolment;

namespace Enolment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Enrollment_Form enrollment_Form = new Enrollment_Form();

            {
                enrollment_Form.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Userlogin userlogin = new Userlogin();
            {
                userlogin.ShowDialog();
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
