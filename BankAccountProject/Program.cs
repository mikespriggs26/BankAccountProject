using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption;

            CheckingAccount check = new CheckingAccount();
            SavingsAccount save = new SavingsAccount();
            ReserveAccount reserve = new ReserveAccount();



        MainMenu:
            Console.WriteLine("Please select a number from the list below and press enter.");

            List<string> clientOptions = new List<string>();        //Main Menu of options
            clientOptions.Add("1. View Client Information");
            clientOptions.Add("2. View Account Information");
            clientOptions.Add("3. Make a Deposit");
            clientOptions.Add("4. Make a Withdrawal");
            clientOptions.Add("5. Exit");

            foreach (string option in clientOptions)
            {
                Console.WriteLine(option);
            }

            userOption = Console.ReadLine();

            if (userOption == "1")
            {
                //display client information
                StreamReader reader = new StreamReader("ClientInfo.txt");
                using (reader)
                {
                    int lineNumber = 1;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;
                        Console.WriteLine(line);
                        line = reader.ReadLine();


                    }

                }
                Console.WriteLine();
            }
            else if (userOption == "2")     //User account info
            {
            AccountBalanceMenu:
                Console.WriteLine("View which account balance: \n1. Checking \n2. Savings \n3. Reserve");
                string accountInfoInput = Console.ReadLine();
                if (accountInfoInput == "1")
                {
                    check.AccountBalance();         //shows balance
                }
                else if (accountInfoInput == "2")
                {
                    save.AccountBalance();          //shows balance
                }
                else if (accountInfoInput == "3")
                {
                    reserve.AccountBalance();         //shows balance
                }
                else
                {
                    Console.WriteLine("That is not a valid selection.  Please try again.");
                    goto AccountBalanceMenu;

                }


            }
            else if (userOption == "3")     //Make a deposit
            {

                // AccountSelection:
                Console.WriteLine("Into which account: \n1. Checking \n2. Savings \n3. Reserve");
                string userAccountInput = Console.ReadLine();

                if (userAccountInput == "1")   //Deposit -> Checking
                {
                CheckingDepositInput:
                    Console.WriteLine("How much would you like to deposit? Do not enter a dollar sign.");
                    try
                    {
                        check.CheckingDeposit = decimal.Parse(Console.ReadLine());
                        check.Deposit();                   //shows deposit amount and new balance and writes to text file
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("You have entered non-numeric characters. Please try again.");
                        goto CheckingDepositInput;
                    }
                }

                if (userAccountInput == "2")   //  Deposit -> Savings
                {
                SavingsDepositInput:
                    Console.WriteLine("How much would you like to deposit? Do not enter a dollar sign.");
                    try
                    {
                        save.SavingsDeposit = decimal.Parse(Console.ReadLine());
                        save.Deposit();         //shows deposit amount and new balance and writes to text file
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("You entered non-numeric characters. Please try again.");
                        goto SavingsDepositInput;
                    }
                }
                if (userAccountInput == "3")   //Deposit -> Reserve
                {
                ReserveDepositInput:
                    Console.WriteLine("How much would you like to deposit? Do not enter a dollar sign.");
                    try
                    {
                        reserve.ReserveDeposit = decimal.Parse(Console.ReadLine());
                        reserve.Deposit();      //shows deposit amount and new balance and writes to text file
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("You have entered non-numeric characters. Please try again.");
                        goto ReserveDepositInput;
                    }
                }


            }    //  End of 3 .Make a deposit





            else if (userOption == "4")     //  Withdraw funds
            {
                // AccountSelection:
                Console.WriteLine("Into which account: \n1. Checking \n2. Savings \n3. Reserve");
                string userAccountInputW = Console.ReadLine();

                if (userAccountInputW == "1")   //Withdraw -> Checking
                {
                CheckingWithdrawalInput:
                    Console.WriteLine("How much would you like to withdraw? Do not enter a dollar sign.");
                    try
                    {
                        check.CheckingWithdrawal = decimal.Parse(Console.ReadLine());
                        check.Withdrawal();       //show withdrawal amount and new balance and writes to text file
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("You have entered non-numeric characters. Please try again.");
                        goto CheckingWithdrawalInput;
                    }
                }

                if (userAccountInputW == "2")   //  Withdraw -> Savings
                {
                SavingsWithdrawalInput:
                    Console.WriteLine("How much would you like to withdraw? Do not enter a dollar sign.");
                    try
                    {
                        save.SavingsWithdrawal = decimal.Parse(Console.ReadLine());
                        save.Withdrawal();      //shows withdrawal amount and new savings and writes to text file
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("You have entered non-numeric characters. Please try again.");
                        goto SavingsWithdrawalInput;
                    }
                }
                if (userAccountInputW == "3")   //  Withdraw -> Reserve
                {
                ReserveWithdrawalInput:
                    Console.WriteLine("How much would you like to withdraw? Do not enter a dollar sign.");
                    try
                    {
                        reserve.ReserveWithdrawal = decimal.Parse(Console.ReadLine());
                        reserve.Withdrawal();       //show withdrawal amount and new balance and writes to text file
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("You have entered non-numeric characters. Please try again.");
                        goto ReserveWithdrawalInput;
                    }
                }



            }
            else if (userOption == "5")     //  Exit
            {
                Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("That is not a valid option.  Please start over.");
                goto MainMenu;
            }
            goto MainMenu;


        }//static void main



    }//class Program
} //namespace

