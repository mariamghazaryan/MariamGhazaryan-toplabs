using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer
    {
        private int creditHistory;
        private int guarantors;
        private int money;
        private int neededMoney;
        private int giveMoney;

        public Customer()
        {
            creditHistory = 0;
            guarantors = 0;
            money = 0;
        }

        public Customer(int creditHistory1, int guarantors1, int money1)
        {
            this.creditHistory = creditHistory1;
            this.guarantors = guarantors1;
            this.money = money1;
        }

        public int GivingMoney
        {
            get
            {
                return giveMoney;
            }
            set
            {
                giveMoney = value;
            }
        }

        public int NeededMoney
        {
            get
            {
                return this.neededMoney;
            }
            set
            {
                this.neededMoney = value;
            }
        }

        public int CreditHistory
        {
            get
            {
                return this.creditHistory;
            }
            set
            {
                this.creditHistory = value;
            }
        }
        public string history()
        {

            if (this.creditHistory == 0)
            {
                return "Good";
            }
            else
            {
                return "Bad";
            }
        }
           
        public int Guarantors
        {
            get
            {
                return this.guarantors;
            }
            set
            {
                this.guarantors = value;
            }
        }
        public int Money
        {
            get
            {
                return this.money;
            }
            set
            {
                this.money = value;
            }
        }

    }
}
