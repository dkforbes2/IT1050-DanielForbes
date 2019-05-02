using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Q2: A one-dimensional array p contains four elements. The array access expressions to access each of the elements in p are [0], [1], [2], and [3].
namespace Lab06_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 0; i < 12; i++)
            { 
                Console.WriteLine(months[i]);
            }

        }
    }
}
namespace Lab06_Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seasons = { "Winter", "Spring", "Summer", "Autumn" };
            Console.WriteLine("Four Seasons");
            foreach (string season in seasons)
            {
                Console.WriteLine(season);
            }
        }
    }
}
namespace Lab06_Q5
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int [1000];
            Random random = new Random();
            foreach (int y in x)
            {
                int randomNumber = random.Next(0, 100);
                Console.WriteLine(randomNumber);
            }
            
        }
    }
}
namespace Lab06_Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine(names[i]);
                i++;
            }
        }
    }
}
namespace Lab06_Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            while (i < names.Length)
            {
                Console.WriteLine("{0,2}. {1}", i ,names[i]);
                i++;
            }
        }
    }
}
namespace Lab06_Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            int i = 0;
            foreach (string name in names)
            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);
                i++;
            }
        }
    }
}