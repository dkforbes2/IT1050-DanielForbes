using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
/*
2.
 a. Scope - Public. Method can be called anywhere in program.
 b. Static vs. Non Static - The data for a static method is contained in its own object. Non-static methods are not limited in where there data come from. This method is
    non-static.
 c. Return Type - Double; how information is returned. Other possible values could be int or void.
 d. Method Name (identifier) - getArea
 e. Parameters - Anything in parentheses (generally speaking). In this case double height, double width.
 f. Method Body - return height * width. The Method Body is the set of instructions contained in {} that execute to "getArea".
3. A user-defined method is written by the user and is limited in its use. A method provided with a framework is able to be reused several times throughout
    a program. When creating a user-defined method, it is important to make sure the intended purpose cannot be accomplished already with other existing methods,
    as this would be duplicative work.
4. A non-static method can access all static and non-static fields. A static method can’t call non-static fields.
 */
//5. & 6.
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";
            myDog.bark();
            myDog.doTrick("Fetch");
        }
    class Dog
        {
            public string Name { get; set; }
            public string trickName { get; set; }
            // Add bark() method
            public void bark()
            {

                Console.WriteLine("{0} is barking...", Name);

            }
            // Add doTrick() method
            public void doTrick(string trickName)
            {

                Console.WriteLine("{0} is so smart! {0} is doing a(n) {1}", Name, trickName);

            }
        }
    }
}