using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }

        public Book(string title, string author, DateTime date)
        {
            Title = title;
            Author = author;
            Date = date;
        }

        public override string ToString()
        {
            return string.Format("Title: {0}\nAuthor: {1}\nYear: {2}", Title, Author, Date);

        }
    }
    class Program
    {
        static void Main()
        {
            Book d= new Book("Dune", "Frank Herbert", new DateTime(1965, 1, 1));
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}

/*3.	Before adding a constructor method, describe what is called when we create an instance of type Book? (2 points)
If you don't provide a constructor for your class, C# creates one by default that uses an instance of that object and sets member variables to the default values. If you don't provide a constructor for your struct, C# relies on an implicit parameterless constructor to automatically initialize each field of a value type to its default value.

4.	What concept would we be practicing if we created two new constructor methods? (2 points)
This practice is called constructor overloading. It is when two or more constructors in a class share the same name. That said, the constructor must have the same name but with different parameters list. Constructors can be overloaded in the following ways: using a different type of arguments, using a different number of arguments, or using a different order of arguments.

5.	Why is it important to use exception handling? (2 points)
Exception handling is important to avoid errors/problems in the execution of a program. There are 4 methods or keywords of exception handling: try, catch, finally, and throw. A try block identifies a block of code for which particular exceptions is activated. It is followed by one or more catch blocks. A program catches an exception with an exception handler at the place in a program where you want to handle the problem. The catch keyword indicates the catching of an exception. The finally block is used to execute a given set of statements, whether an exception is thrown or not thrown. A program throws an exception when a problem shows up. This is done using a throw keyword.

6.	What’s the purpose of private vs. public when we’re adding new properties and/or methods to our class?  How does this apply to information hiding? (2 points)
Public is available to any caller. Private specifies that a variable or function is available only to the class that declares or defines it or to subclasses of that class. By default, a variable or function is public, and available to any caller. If you want to restrict access you use private.
Information hiding is an approach to hiding an objects attributes and behaviors, which is a component of private.

7.	What is composition?  How could we use Composition in our Book class? (2 points)
Under Composition, if the parent object is deleted, then the child object also loses its status. The composition is a special type of Aggregation and gives a part-of relationship.

8.	What is data abstraction? (2 points)
Data Abstraction is the process of identifying only the required characteristics of an object and ignoring the irrelevant details.
*/