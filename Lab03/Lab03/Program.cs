using System;
using System.Threading.Tasks;
    
    namespace Declare_Two_Int_Variables
{
    //#2. The "If Single-Selection Statement" and the "While Repetition Statement are similar in that they both determine if a value is true/false. This determines how the code will proceed. The difference between the two is that the "If Single-Selection Statement" eventually stops, while the "While Repetition Statement" continues on a loop until a condition is met.
    class Program
    {
        static void Main(string[] args)
        {
            int speedLimit;
            int speed;

            speedLimit = 35;
            speed = 42;

            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW NOW");
            }
        }
    }
}
namespace If_Else_Statement
{
    class Program
    {
        static void Main (string[] args)
        {
            int isTrue;

            isTrue = 5;

            if
                (isTrue <= 10)
                Console.WriteLine("It is True!");

            else
                Console.WriteLine("It is False!");

            if

                (isTrue >= 10)
                Console.WriteLine("It is True!");

            else
                Console.WriteLine("It is False!");
            {
                Console.ReadLine();
            }
        }

    }
}
namespace If_Statement
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Fahrenheit Temperature: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Celsius Temperature {0}: ");
            Console.ReadLine();

            if (fahrenheit >= 90)
                Console.WriteLine("It is hot");
            if (fahrenheit <= 40)
                Console.WriteLine("It is cold");

        }
    }
}
namespace While_Loop_1_10
{
    class Program
    {
        static void Main (string [] args)
        {
            int a = 1;
            while (a < 11)
            {
                Console.Write("Value: ");
                Console.WriteLine(a); a = a+1;
            }
        }
    }
}
namespace While_Loop_60_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 60;
            while (a >= 20)
            {
                Console.Write("Value: ");
                Console.WriteLine(a); a = a - 5;
            }
        }
    }
}
namespace While_Loop_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            while (a <= 20)
            {
                Console.Write("Value: ");
                Console.WriteLine(a); a = a + 2;
            }
        }
    }
}