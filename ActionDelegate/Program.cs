using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    internal class Program
    {
        public delegate void Print(int value);
        public delegate int ReturnNumber(int value);
        static void PrintMethod(int value)
        {
            Console.WriteLine(value);
        }

        static int ReturnNum(int value)
        {
            return value;
        }
        static void Main(string[] args)
        {
            //Print print = PrintMethod;
            //Action<int> print = PrintMethod;
            
            Action<int> print = new Action<int>(PrintMethod);
            print(100);

            Action<string> action = delegate (string name)
            {
                Console.WriteLine("Your name: {0}", name);
            };

            Console.WriteLine("Input your name:");
            string Name = Console.ReadLine();
            action(Name);


            ///Action<int> ReturnNum = ReturnNum(5); Phuong thuc phai la void

        }
    }
}
