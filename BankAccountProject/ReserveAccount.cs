using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class ReserveAccount : MainAccount
    {
        private decimal reserveBalance;
        private decimal reserveDeposit;
        private decimal reserveWithdrawal;

        public ReserveAccount()
        {
            this.reserveBalance = 1500;

        }



        public decimal ReserveDeposit { get; set; }

        public decimal ReserveWithdrawal { get; set; }

        public override void AccountBalance()
        {
            Console.WriteLine("Your checking account balance is $" + reserveBalance + ".\n");

        }

        public override void Deposit()
        {
            Console.WriteLine("Beginning balance is $" + reserveBalance + ".");
            reserveBalance += ReserveDeposit;
            Console.WriteLine("You have deposited: $" + ReserveDeposit + ".");
            Console.WriteLine("Your new Savings Account balance is $" + reserveBalance + ".");
            Console.WriteLine("----------------------------------------");
            StreamWriter writer = new StreamWriter("ReserveTransactionLog.txt", true);
            using (writer)
            {
                writer.WriteLine(DateTime.Now + "\t+" + ReserveDeposit + "\t$" + reserveBalance);
            }

        }
        public override void Withdrawal()
        {
            if (reserveBalance >= ReserveWithdrawal)
            {
                reserveBalance -= ReserveWithdrawal;
                Console.WriteLine("You have withdrawn: $" + ReserveWithdrawal + ".");
                Console.WriteLine("Your new Reserve Account balance is $" + reserveBalance + ".");
                Console.WriteLine("----------------------------------------");
                StreamWriter writer = new StreamWriter("ReserveTransactionLog.txt", true);
                using (writer)
                {
                    writer.WriteLine(DateTime.Now + "\t-" + ReserveWithdrawal + "\t$" + reserveBalance);
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient funds.");

            }
        }

    }
}
