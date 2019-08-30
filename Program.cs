using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            lab1 homework = new lab1();
            int summation = 2;
            int value = homework.multipl(1, 2, 3, out summation);
            Console.WriteLine(summation);
            Console.WriteLine(value);
            Console.Read();

        }
    }
    class lab1
    {
        public int multipl(int firstnumb, int secondnumb, int thirdnumb, out int summation)
        {
            summation = firstnumb + secondnumb+ thirdnumb;
            return (firstnumb * secondnumb * thirdnumb);

        }
    }
}
