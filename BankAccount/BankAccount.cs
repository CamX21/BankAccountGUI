

using System.ComponentModel;

namespace BankAccountLibary;

 public class AccountInfo
{
    string pass { get; set; }      // class attributes with getters and setters
    double money { get; set; }
    string description { get; }
    public AccountInfo(double money, string description)     // contructor
    {

        this.money = money;
        this.description = description;
    }
    public void DepositMoney(double AddMoney) 
    {
        money =+ AddMoney;  // deposit money
       
    }
    public void WithdrawMoney(double SubtractMoney)
    {
   money -= SubtractMoney;   // withdraw money
        
     }

    public void TransferMoney(AccountInfo TransferAcc, double TransferAmount)
    {
         money -= TransferAmount;
           TransferAcc.money += TransferAmount;    // transfer money 
     }
    public override string ToString()
    {
        return "Your " + description + " has: " + money.ToString("F2") + "$";  // display bank account balances

    }

    public static bool Passwordchecker(string pass)
    {
       
        bool Specialchar = false;
        bool Uppercase = false;                                         // password checker using the ascii chart with a for loop
        bool Hasdigit = false;
       

            for (int i = 0; i < pass.Length; i++)                                        
            {
                if (pass[i] >= 65 && pass[i] <= 90 && pass.Length >= 10) // must have one uppercase
                {
                    Uppercase = true;
                }
                                                                 
                if (pass[i] >= 48 && pass[i] <= 57)  // must have one a number
                {
                    Hasdigit = true;
                }

                if (pass[i] >= 33 && pass[i] <= 38)  // must have one speacial character
                {
                    Specialchar = true;
                }
            }

            if (Uppercase == true && Hasdigit == true && Specialchar == true)
            {
               return  true;
                
            }
            else
            {
                return false;
            }


        
    }
}
