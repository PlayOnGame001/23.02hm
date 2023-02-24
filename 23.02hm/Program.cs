using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._02hm
{
    internal class Program
    {
        class Bankomat : IPrint, ISum, ICurrency
        {
            private int baks;
            private string curs;
            public Bankomat() { }
            public Bankomat(int m, string c)
            {
                baks = m;
                curs = c;
            }
            public void Print()
            {
                Console.WriteLine($"Sum: {baks} {curs}");
            }
            public void Sum()
            {
                Console.Write($"Enter sum: ");
                baks = Convert.ToInt32(Console.ReadLine());
            }
            public void UAH()
            {
                curs = "UAH";
            }
            public void USD()
            {
                curs = "USD";
            }
            public void EUR()
            {
                curs = "EUR";
            }
        }
        interface IPrint
        {
            void Print();
        }
        interface ISum
        {
            void Sum();
        }
        interface ICurrency
        {
            void UAH();
            void EUR();
            void USD();
        }
        static void Main(string[] args)
        {
            Bankomat bank = new Bankomat();
            bank.Sum();
            bank.USD();
            bank.Print();
        }
    }
}

