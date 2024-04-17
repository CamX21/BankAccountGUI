
using BankAccountLibary;
using System.Data.SqlClient;
namespace WinFormsBankAccount
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E6FQHK5\SQLEXPRESS; Database=BankAccount; Integrated Security=True;"); // use connection string to create a connection between project and database
        SqlCommand cmd; //create sql command
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

                con.Open(); //open connection to database
                cmd = new SqlCommand("insert into AccountInfo(AccountPassword)values('" + textBox3.Text + "')",con); //pass textbox3 value into database in the AccountPassword column
                cmd.ExecuteNonQuery();
                con.Close(); //close connection to database

                SecondForm.TextboxValue=textBox3.Text; //pass textbox value to secondform
            }
        }
    }
}
