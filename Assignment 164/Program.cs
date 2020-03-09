using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_164
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int answer;
            MathFunctions functionOne = new MathFunctions();

            Console.WriteLine("Please enter a number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            functionOne.divided(num1, out answer);
            Console.WriteLine(num1 + " divided by 2 equals:" + answer);

            int num2;
            int num3;
            
            MathFunctions functionTwo = new MathFunctions();
            functionTwo.numbers(out num2, out num3);
            Console.WriteLine(num2 + ", " + num3);

            int int1 = 5;
            int int2 = 5;
            int total;
            MathFunctions functionThree = new MathFunctions();
            functionThree.numbers(int1, int2, out total);
            Console.WriteLine(int1 + " plus " + int2 + " equals " + total);
            Console.ReadLine();
        }
    }
}
