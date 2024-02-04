
using BankAccountLibary;

namespace WinFormsBankAccount
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            string password = textBox1.Text;



            if (AccountInfo.Passwordchecker(password) == true)
            {                                                           
                label9.Visible = true;                   // if password meets requirements new textbox and button appears
                textBox3.Visible = true;
                button1.Visible = false;
                button2.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Password");   // if password does not meet requirements error message shows
            }
        }

        private void button2_Click(object sender, EventArgs e)     // this confirms password matches
        {
            if (textBox3.Text != textBox1.Text)            // if password doesnt match error message appears
            {
                MessageBox.Show("Password does not match");
            }
            else
            {
                SecondFormBank SecondForm = new SecondFormBank(); // if password does match second form uploads
                SecondForm.Show();
            }
        }
    }
}
