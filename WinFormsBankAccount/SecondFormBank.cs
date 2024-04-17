using BankAccountLibary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsBankAccount
{
    public partial class SecondFormBank : Form

    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-E6FQHK5\SQLEXPRESS; Database=BankAccount; Integrated Security=True;"); // use connection string to create a connection between project and database
        SqlCommand cmd;
        public string TextboxValue {  get; set; } // receive textbox value from form1


        double money = 0;
        double money2 = 0;
        public SecondFormBank()
        {
            InitializeComponent();
        }

        private void SecondFormBank_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)

        {
           
            
            AccountInfo CheckingsAcc = new AccountInfo(money, "Checkings Account");
            AccountInfo SavingsAcc = new AccountInfo(money2, "Savings Account");

            switch (choice1.Text)      //choose what your option
            {
                case "1":   
                    numericUpDown1.Visible = true;
                    label1.Visible = true;
                    button2.Visible = true;
                    label1.Text = "Enter amount to deposit: "; break;
                case "2":
                    numericUpDown1.Visible = true;
                    label1.Visible = true;
                    button2.Visible = true;
                    label1.Text = "Enter amount to deposit: "; break;
                case "3":
                    numericUpDown1.Visible = true;
                    label1.Visible = true;
                    button2.Visible = true;
                    label1.Text = "Enter amount to withdraw: "; break;
                case "4":                                                                            // labelbox and button will appear after making choice
                    numericUpDown1.Visible = true;
                    label1.Visible = true;
                    button2.Visible = true;
                    label1.Text = "Enter amount to withdraw: "; break;
                case "5":
                    numericUpDown1.Visible = true;
                    label1.Visible = true;
                    button2.Visible = true;
                    label1.Text = "Enter amount to Tranfer: "; break;
                case "6":
                    numericUpDown1.Visible = true;
                    label1.Visible = true;
                    button2.Visible = true;
                    label1.Text = "Enter amount to Tranfer: "; break;
                case "7": MessageBox.Show(CheckingsAcc.ToString()+ "\n"+ SavingsAcc.ToString()); label1.Visible = false; // Display checkings and savings account balance
                    numericUpDown1.Visible = false;
                    button2.Visible = false; break;
            }

        }

 
        private void button2_Click(object sender, EventArgs e)
        {
          
            AccountInfo CheckingsAcc = new AccountInfo(money, "Checkings Account");
            AccountInfo SavingsAcc = new AccountInfo(money2, "Savings Account");

            
            switch (choice1.Text)   

            {
                case "1":
                    money += (double)numericUpDown1.Value;
                    CheckingsAcc.DepositMoney(money);
                    label1.Visible = false;                               // add money to checkings account
                    numericUpDown1.Visible = false;        
                    button2.Visible = false;
                    MessageBox.Show("Transaction Complete");

                    con.Open(); // open connection to database
                    cmd = new SqlCommand("update AccountInfo set CheckingsAccount='" + money + "'where AccountPassword='" + TextboxValue + "'", con);// pass the value of money to checkingsAccount in database
                    cmd.ExecuteNonQuery();
                    con.Close(); //close connection to database

                    break;

                   

                case "2":
                    money2 += (double)numericUpDown1.Value;
                    SavingsAcc.DepositMoney(money2);
                    label1.Visible = false;                                  // add money to savings account
                    numericUpDown1.Visible = false;
                    button2.Visible = false;
                    MessageBox.Show("Transaction Complete");

                    con.Open(); // open connection to database
                    cmd = new SqlCommand("update AccountInfo set SavingsAccount='" + money2 + "'where AccountPassword='" + TextboxValue + "'", con); // pass the value of money2 to SavingsAccount in database
                    cmd.ExecuteNonQuery();
                    con.Close(); //close connection to database

                    break;

                case "3":
                    
                    if ((double)numericUpDown1.Value > money)
                    {
                        MessageBox.Show("Your account doesnt have that much money to withdraw."); // if users input is  greater than checkings account balance error message shows
                    }
                    else
                    {
                        money -= (double)numericUpDown1.Value;
                        CheckingsAcc.WithdrawMoney(money);
                        label1.Visible = false;
                        numericUpDown1.Visible = false;      // withdraw money from checkings account
                        button2.Visible = false;
                        MessageBox.Show("Transaction Complete");

                        con.Open(); // open connection to database
                        cmd = new SqlCommand("update AccountInfo set CheckingsAccount='" + money + "'where AccountPassword='" + TextboxValue + "'", con);// pass the value of money to checkingsAccount in database
                        cmd.ExecuteNonQuery();
                        con.Close(); //close connection to database

                    } break;
                    

                 case "4":
                    if ((double)numericUpDown1.Value > money2) // if users input is greater than savings account balance error message shows
                    {
                        MessageBox.Show("Your account doesnt have that much money to withdraw.");
                    }
                    else
                    {
                        money2 -= (double)numericUpDown1.Value;
                        SavingsAcc.WithdrawMoney(money2);
                        label1.Visible = false;                       // withdraw money from savings account
                        numericUpDown1.Visible = false;
                        button2.Visible = false;
                        MessageBox.Show("Transaction Complete");

                        con.Open(); // open connection to database
                        cmd = new SqlCommand("update AccountInfo set SavingsAccount='" + money2 + "'where AccountPassword='" + TextboxValue + "'", con);// pass the value of money2 to SavingsAccount in database
                        cmd.ExecuteNonQuery();
                        con.Close(); //close connection to database

                    } break;
               
                case "5":
                    if (money >= (double)numericUpDown1.Value)
                    {
                        money -= (double)numericUpDown1.Value;
                        money2 += (double)numericUpDown1.Value;
                        CheckingsAcc.TransferMoney(SavingsAcc, money2);     // Transfer  money from checkings account to savings account
                        label1.Visible = false;
                        numericUpDown1.Visible = false;
                        button2.Visible = false;
                        MessageBox.Show("Transaction Complete");

                        con.Open(); // open connection to database
                        cmd = new SqlCommand("update AccountInfo set CheckingsAccount='" + money + "'where AccountPassword='" + TextboxValue + "'", con); // pass the value of money to checkingsAccount in database
                        cmd.ExecuteNonQuery();
                        con.Close(); //close connection to database

                        con.Open(); // open connection to database
                        cmd = new SqlCommand("update AccountInfo set SavingsAccount='" + money2 + "'where AccountPassword='" + TextboxValue + "'", con); // pass the value of money2 to SavingsAccount in database
                        cmd.ExecuteNonQuery();
                        con.Close(); //close connection to database
                    }
                    else
                    {
                        MessageBox.Show("You dont have have that much money avaliable to transfer.");   // if users input is  greater than checkings account balance error message shows
                    }

                    break;
                
                case "6":
                    if (money2 >= (double)numericUpDown1.Value)
                    {
                        money2 -= (double)numericUpDown1.Value;
                        money += (double)numericUpDown1.Value;                // Transfer  money from Savings account to checkings account
                        SavingsAcc.TransferMoney(CheckingsAcc, money);
                        label1.Visible = false;
                        numericUpDown1.Visible = false;
                        button2.Visible = false;
                        MessageBox.Show("Transaction Complete");

                        con.Open(); // open connection to database
                        cmd = new SqlCommand("update AccountInfo set CheckingsAccount='" + money + "'where AccountPassword='" + TextboxValue + "'", con); // pass the value of money to checkingsAccount in database
                        cmd.ExecuteNonQuery();
                        con.Close(); //close connection to database

                        con.Open(); // open connection to database
                        cmd = new SqlCommand("update AccountInfo set SavingsAccount='" + money2 + "'where AccountPassword='" + TextboxValue + "'", con); // pass the value of money2 to SavingsAccount in database
                        cmd.ExecuteNonQuery();
                        con.Close(); //close connection to database
                    }
                    else {
                        MessageBox.Show("You dont have have that much money avaliable to transfer.");    // if users input is  greater than Savings account balance error message shows

                    }
                    break;
            }



        }

      
    }
}
