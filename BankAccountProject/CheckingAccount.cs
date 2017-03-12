using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class CheckingAccount : MainAccount
    {

        private decimal checkingBalance;
        private decimal checkingDeposit;
        private decimal checkingWithdrawal;

        public CheckingAccount()
        {
            this.checkingBalance = 1000;

        }



        public decimal CheckingDeposit { get; set; }
       

        public decimal CheckingWithdrawal
        {
            get { return this.checkingWithdrawal; }
            set { this.checkingWithdrawal = value; }
        }

        public override void AccountBalance()
        {
            Console.WriteLine("Your checking account balance is $" + checkingBalance + ".\n");
        }

        public override void Deposit()
        {
            Console.WriteLine("Beginning balance is $" + checkingBalance + ".");
            checkingBalance += CheckingDeposit;
            Console.WriteLine("You have deposited: $" + CheckingDeposit + ".");
            Console.WriteLine("Your new Checking Account balance is $" + checkingBalance + ".");
            Console.WriteLine("----------------------------------------");
            StreamWriter writer = new StreamWriter("CheckingTransactionLog.txt", true);
            using (writer)
            {
                writer.WriteLine(DateTime.Now + "\t+" + CheckingDeposit + "\t$" + checkingBalance);
            }


        }
        public override void Withdrawal()
        {
            if (checkingBalance >= CheckingWithdrawal)
            {
                checkingBalance -= CheckingWithdrawal;
                Console.WriteLine("You have withdrawn: $" + CheckingWithdrawal);
                Console.WriteLine("Your new Checking Account balance is $" + checkingBalance);
                Console.WriteLine("----------------------------------------");
                StreamWriter writer = new StreamWriter("CheckingTransactionLog.txt", true);
                using (writer)
                {
                    writer.WriteLine(DateTime.Now + "\t-" + CheckingWithdrawal + "\t$" + checkingBalance);
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient funds.");

            }
        }






    }
}
