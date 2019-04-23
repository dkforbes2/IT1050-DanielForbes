using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
/*
 2. Three types of control structures we can use to order the statements in our programs are Switch statements, If statements, and Loops (while, do while, for).
    Switch statements allow users to execute code based on predefined set choice (can be used like if else statement). 
    If statements execute if true and skip if false.
    A Loop will execute as long as a condition is true.
 */
 // 3.
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 101;
            Boolean keepLooping = true;
            while (keepLooping)
            {
                if (i <= 100)
                    keepLooping = false;
                i++;
                Console.WriteLine(i);
            }
        }
    }
}
// 4.
namespace Midterm2

{ class Program
    {
        static void Main(string[] args)
        {
            int loop = 2;
            
            while (loop < 128)
            {
            Console.WriteLine("[" + loop + "]");
            loop = loop + loop;
            }
        }
    }
}
// 5.
namespace Midterm3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 49; i > 0; i--)
            {
                Console.Write(i);
                if (i != 1)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}
// 6.
namespace Midterm4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 21)
            {
                if ((i % 2) == 0)
                    Console.Write(" ");
            
                else if ((i % 2) !=0)
                {
                    Console.Write(i);
                }
            i++;
            }
        }
    }
}
/* 7.
    The output for the code identified under #7 would be "*". There is no output if a while statement is used instead of a do while, because the do (or execution) 
    is based on the identified condition (or while).
 */
// 8.
/*Boolean values are combined using if or if else statements. The Logical Operators (&&, ||, !) will always work with 
  Boolean expressions (true or false) and return Boolean values.
  */
namespace Midterm5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool icyRain = false, tornadoWarning = false;
            if (icyRain == false && tornadoWarning == false)
                {
                    Console.Write("Let's go outside!");
                }
            
        }
    }
}

