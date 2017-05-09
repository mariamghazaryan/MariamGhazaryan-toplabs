using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Deposit
    {
        private const int percent = 12;
        private int month;
        private int principal = 0;
        DateTime date;

        public Deposit(Bank myBank, Customer cst)
        {
            if (cst.GivingMoney >= 100)
            {
                date = DateTime.Now;
                cst.Money -= cst.GivingMoney;
                myBank.Money += cst.GivingMoney;
                principal = cst.GivingMoney;
            }
        }
        public int Principal
        {
            get
            {
                return this.principal;
            }
            set
            {
                this.principal = value;
            }
        }
        public int Month
        {
            get
            {
                return this.month;
            }
            set
            {
                this.month = value;
                principal = principal + month * (principal * percent) / 100;
            }
        }

       
        public void takeYourDeposit(Bank myBank, Customer cst)
        {
            myBank.Money -= principal;
            cst.Money += principal;
        }
    }
}
