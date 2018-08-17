using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructIntro
{
    public struct Number
    {
        public decimal Amount;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 45.34356M;
            Console.WriteLine(number.Amount);
        }
    }
}
