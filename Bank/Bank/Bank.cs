using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Bank
    {
        private int bankMoney;
        public Bank()
        {
            bankMoney = 300000;
        }

        public int Money
        {
            get
            {
                return bankMoney;
            }
            set
            {
                bankMoney = value;
            }
        }

    }
}
