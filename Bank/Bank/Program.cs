using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {   
            bool flag = true;
            int ch = 0;
            Console.WriteLine("Is customer's credit history good or bad (0-good, 1-bad)?");
            while (flag)
            {
                ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 0 || ch == 1)
                {
                    flag = false;
                }
                else
                {
                    Console.Write("Your input is incorrect. Try again. \n");
                }   
            }
            flag = true;
            Console.WriteLine("How many guarantors has a customer?");
            int g = 0;
            while (flag)
            {
                g = Convert.ToInt32(Console.ReadLine());
                if (g >= 0)
                {
                    flag = false;
                }
                else
                {
                    Console.Write("Your input is incorrect. Try again. \n");
                }
            }
            flag = true;
            Console.WriteLine("How much money has a customer?");
            int m = 0;
            while (flag)
            {
                m = Convert.ToInt32(Console.ReadLine());
                if (m >= 0)
                {
                    flag = false;
                }
                else
                {
                    Console.Write("Your input is incorrect. Try again. \n");
                }
            }
            Customer person = new Customer(ch, g, m);

            Console.WriteLine("Customer's credit history is " + person.history() + ".");
            Console.WriteLine("Customer has " + person.Guarantors + " guarantors.");
            Console.WriteLine("Customer has " + person.Money + " dollars.");

            Bank myBank = new Bank();
            Console.WriteLine("\n" + "There are " + myBank.Money + " dollars in the Bank.");

            Console.WriteLine("\n\nTaking a loan : ");

            Console.WriteLine("How much money customer needs to take?");
            person.NeededMoney = Convert.ToInt32(Console.ReadLine());
            Loan personLoan = new Loan(myBank, person);
            Console.WriteLine("In how month customer will pay his loan?");
            personLoan.Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer has " + person.Money + " dollars.");
            Console.WriteLine("There are " + myBank.Money + " dollars in the Bank.\n");
            Console.WriteLine("Customer must pay " + personLoan.Principal + " dollars.");

            Console.WriteLine("\nCustomer pays his loan : ");
            personLoan.toPayLoan(400);

            Console.WriteLine("\n\nGiving a deposite : ");
           
            Console.WriteLine("How much money customer wants to give?");
            person.GivingMoney = Convert.ToInt32(Console.ReadLine());
            Deposit personDeposit = new Deposit(myBank, person);
            Console.WriteLine("In how month customer will take his deposite?");
            personDeposit.Month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer has " + person.Money + " dollars.");
            Console.WriteLine("There are " + myBank.Money + " dollars in the Bank.\n");

            Console.WriteLine("\nCustomer takes his money : ");
            personDeposit.takeYourDeposit(myBank, person);
            
            Console.WriteLine("Customer has " + person.Money + " dollars.");
            Console.Write("\n" + "There are " + myBank.Money + " dollars in the Bank.");
        }
    }
}

