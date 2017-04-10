using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            MineClass mine = new MineClass("X", 5000, ResouceType.Uranium);
            MineClass mine1 = new MineClass();
            Console.WriteLine("Mine : ");
            printMine(mine.NameProperty, mine.AmountProperty, mine.TypeProperty);
            Console.WriteLine("Resource State is : " +  mine.resourceState);
            Console.WriteLine(" ");
            Console.WriteLine("Mine1(default constructor : ");
            printMine(mine1.NameProperty, mine1.AmountProperty, mine1.TypeProperty);
            Console.WriteLine("Resource State is : " + mine1.resourceState);
            Console.WriteLine(" ");

            Miner obj = new Miner("Jack", 45, 100);
            Console.WriteLine("Miner : ");
            printMiner(obj.minerNameProperty, obj.AgeProperty, obj.healthProperty);
            Console.WriteLine("After 4 hits health is : ");
            obj.Heatlh(mine, 4);
            mine.AmountIsChanged += Changed;
            Console.WriteLine(obj.healthProperty);
            Console.WriteLine("After 4 hits amount is : ");
            obj.Mining(mine, 4);
            Console.WriteLine(" ");
            Miner obj1 = new Miner();
            Console.WriteLine("Miner(default constructor) : ");
            printMiner(obj1.minerNameProperty, obj1.AgeProperty, obj1.healthProperty);
            Console.WriteLine(" ");  
        }

        public static void printMine(string name, int amount,ResouceType type)
        {
            Console.WriteLine("Name : {0}, Amount : {1}, Type : {2}", name, amount, type);                
        }

        public static void printMiner(string name, int age, int health)
        {
            Console.WriteLine("Name : {0}, Age : {1}, Health : {2}", name, age, health);
        }

        private static void Changed(object sender, AmountChanged args)
        {
            MineClass mi = (MineClass)sender;
            Console.WriteLine("Old: {0}, New: {1}, Balance: {2}", args.OldAmount, args.NewAmount, args.OldAmount - args.NewAmount);
        }
    }
}
