using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
    //The four basic elements of the counter-controlled repeition are the 1. control variable (loop variable), 2. initial value (beginning of control variable), 3. increment/decrement (the modification for each loop), 4. loop continuation condition (determines if looping should continue).
    //The while and for repetition statements are similar in their respective uses and test for conditions to be true. The for statement is more compact and is most appropriate when the number of iterations are known in advance. If the number of iterations are not known, a while statement may be more appropriate. 
    //It is more appropriate to use a do-while statement than a while statement when a condition has to occur at least once. This happens because in a do while statement, the condition executes after the loop.
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine(i);
                {
                    if ((i % 2) == 0)
                    {
                        Console.WriteLine("Number is Even");
                    }
                    else if ((i % 2) != 0)
                    {
                        Console.WriteLine("Number is Odd");
                      
                    }
                }
            }
        }
    }
}
namespace If_Else_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a temperature");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp >= 90)
            { Console.WriteLine("Fish"); }
            else if (temp >= 80)
            { Console.WriteLine("Lion"); }
            else if (temp >= 70)
            { Console.WriteLine("Turtle"); }
            else if (temp >= 60)
            { Console.WriteLine("Deer"); }
            else if (temp >= 50)
            { Console.WriteLine("Reindeer"); }
            else if (temp >= 40)
            { Console.WriteLine("Moose"); }
            else if (temp >= 20)
            { Console.WriteLine("Penguin"); }
            else if (temp >= 10)
            { Console.WriteLine("Polar Bear"); }
            else
            {
                Console.WriteLine("Bug");
            }
        }
    }
}
namespace While_10_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 9;
            while (i < 20)
            {
                i++;
                Console.WriteLine(i);
            }
        }
    }
}
namespace For_0_100
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("********");
            }
        }
    }
}