using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    abstract class MainAccount
    {
        private decimal accountBalance;
        private decimal depositAmount;
        private decimal withdrawalAmount;

        public MainAccount()
        {
            accountBalance = 5000;
        }
        public decimal DepositAmount
        {
            get { return this.depositAmount; }
            set { this.depositAmount = value; }
        }
        public decimal WithdrawalAmount
        {
            get { return this.withdrawalAmount; }
            set { this.withdrawalAmount = value; }
        }
        public virtual void AccountBalance()
        {

        }


        public virtual void Deposit()
        {

        }
        public virtual void Withdrawal()
        {

        }


    }

}
