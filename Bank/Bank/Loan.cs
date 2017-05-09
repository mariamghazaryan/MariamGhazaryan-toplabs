using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Loan
    {
        private const int percent = 10;
        private int principal = 0;
        private int month;
        DateTime date;
        public Loan(Bank bk, Customer cst)
        {
            if(cst.history() == "Good" && cst.Guarantors > 0 && cst.Money > 200)
            {
                date = DateTime.Now;
                cst.Money = cst.Money + cst.NeededMoney;
                bk.Money -= cst.NeededMoney;
                principal = cst.NeededMoney;
            }
            else
            {
                Console.WriteLine("Customer can't take a loan.");
            }
        }

        public int Principal
        {
            get
            {
                return principal;
            }
            set
            {
                principal = value;
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
        public void toPayLoan(int howMuch)
        {
            if(date.Month > date.Month + 30)
            {
                Console.WriteLine("You don't pay a loan.");
                principal += 100;
            }
            else
            {
                principal -= howMuch;
                if (principal <= 0)
                {
                    Console.WriteLine("The loan is paid.");
                    month = 0;
                }
                else
                {
                    Console.WriteLine("Customer must pay " + principal + " dollars.");
                }
            }
           
        }

    }
}
