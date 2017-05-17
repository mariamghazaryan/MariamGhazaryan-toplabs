using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Deposit
    {
        private Bank _bank;
        private Customer _customer;
        public Deposit(Bank bank, Customer customer)
        {
            _bank = bank;
            _customer = customer;
        }
        public int TotalAmount { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public int PeriodInMonths { get; set; }
        public int DurationInMonths { get; set; }

        public decimal CustomerAccount { get; set; }

        public void GiveAmount(decimal amount)
        {
            this.CustomerAccount += amount;
        }

        public decimal CalculateMonthlyProfit()
        {
            var days = Convert.ToInt32((DateTimeOffset.Now - this.StartDate).TotalDays);
            var newAmount = this.TotalAmount + this.CustomerAccount;
            var depositAmount = newAmount + days * newAmount * _bank.DeposittPercentage / 100;
            return depositAmount;
        }
    }
}
