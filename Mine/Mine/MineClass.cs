using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    public class MineClass
    {
        private string name;
        private int resourceAmount;
        private int maxAmount = 10000;
        private int minAmount = 0;
        ResouceType type = ResouceType.Uranium;
        public event AmountLowDelegate AmountIsChanged;

        public MineClass()
        {
            name = " ";
            resourceAmount = 0;
            type = ResouceType.Gold;
        }

        public MineClass(string n, int a, ResouceType t)
        {
            name = n;
            resourceAmount = a;
            type = t;
        }

        public string NameProperty
        {
            get
            {
                return name;
            }
        }

        public int AmountProperty
        {
            set
            {
                if(AmountIsChanged != null)
                {
                    AmountChanged args = new AmountChanged();
                    args.OldAmount = resourceAmount;
                    args.NewAmount = value;
                    Changed(this, args);
                }
                resourceAmount = value;
            }
            get
            {
                if (resourceAmount >= minAmount && resourceAmount <= maxAmount)
                {
                    return resourceAmount;
                }
                return -1;
            }
        }
        
        public ResouceType TypeProperty
        {
            get
            {
                return type;
            }
        }

        public string resourceState
        {
            get
            {
                if (resourceAmount > 8000)
                {
                    return "Good";
                }
                else
                {
                    if (resourceAmount > 4000 && resourceAmount <= 8000)
                    {
                        return "Normal";
                    }
                    else if (resourceAmount > 100 && resourceAmount <= 4000)
                    {
                        return "Bad";
                    }
                    else
                    {
                        return "Warning!";
                    }
                }
            }
        }

        private void Changed(object sender, AmountChanged args)
        {
            MineClass mi = (MineClass)sender;
            Console.WriteLine("Old: {0}, New: {1}, Balance: {2}", args.OldAmount, args.NewAmount, args.OldAmount-args.NewAmount);
        }
    }
}