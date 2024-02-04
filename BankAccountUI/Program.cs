
using BankAccountLibary;



AccountInfo.Passwordchecker();





AccountInfo CheckingsAcc = new AccountInfo(0.00, "Checkings Account");
AccountInfo SavingsAcc = new AccountInfo(0.00, "Savings Account");

bool quit = false;
while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Deposit into checkings Account\n2. Deposit into Savings Account\n3. Withdraw from checkings Account\n4. Withdraw from savings Account\n5. Transfer money from Checking into Savings\n6. Transfer money from Savings into Checking\n7. Display your Bank account information\"");
    Console.WriteLine();
    Console.Write("Choose one of the options above: ");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("How much money do you want to deposit into your cheching account: ");
            float DM = float.Parse(Console.ReadLine());
            CheckingsAcc.DepositMoney(DM); break;

        case 2:
            Console.Write("How much money do you want to deposit into your saving account:");
            float SM = float.Parse(Console.ReadLine());
            SavingsAcc.DepositMoney(SM); break;

        case 3:
            Console.Write("How much money do you want to withdraw from your cheching account:");
            float WM = float.Parse(Console.ReadLine());
            CheckingsAcc.WithdrawMoney(WM); break;

        case 4:
            Console.Write("How much money do you want to withdraw from your savings account:");
            float WS = float.Parse(Console.ReadLine());
            SavingsAcc.WithdrawMoney(WS); break;


        case 5:
            Console.Write("How much money do yount want to tranfer from checkings into savings account ");
            float TM = float.Parse(Console.ReadLine());
            CheckingsAcc.TransferMoney(SavingsAcc, TM); break;

        case 6:
            Console.Write("How much money do yount want to tranfer from savings into checkings account ");
            float TM2 = float.Parse(Console.ReadLine());
            SavingsAcc.TransferMoney(CheckingsAcc, TM2); break;

        case 7:
            Console.WriteLine();
            Console.WriteLine(CheckingsAcc.ToString());
            Console.WriteLine(SavingsAcc.ToString());
            Console.WriteLine(); break;

        case 8:
            quit = true; break;

        default: Console.WriteLine("Choice not avaliable please try again."); break;

    }
    if (quit == true) { break; }

}

   