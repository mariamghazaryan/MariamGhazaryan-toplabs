using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    public class Miner
    {
        private string minerName;
        private int age;
        private int health;

        public Miner()
        {
            minerName = " ";
            age = 0;
            health = 0;        
        }

        public Miner(string name1, int age1, int health1)
        {
            minerName = name1;
            age = age1;
            health = health1;
        }

        public string minerNameProperty
        {
            set
            {
                minerName = value;
            }
            get
            {
                return minerName;
            }
        }

        public int AgeProperty
        {
            get
            {
                return age;
            }
        }

        public int healthProperty
        {
            get
            {
                return health;
            }
        }

        public int perHit
        {
            get
            {
                return 10;
            }
        }

        public void Mining(MineClass m, int HitCount)
        {
            m.AmountProperty -= HitCount * perHit;
        }

        public void Heatlh(MineClass m, int h)
        {
            if (m.TypeProperty == ResouceType.Silver)
            {
                health = health - (int)((health * 1) / 100);
            }
            else if (m.TypeProperty == ResouceType.Gold)
            {
                health = health - (int)((health * 1) / 100);
            }
            else
            {
                health -= h * ((int)((health * 10) / 100));
            }
        }
    }
}