/*
 * Author: Gursimran Kaur
 * Course: COMP-003A
 * Purpose: COMP003A.Assignment4
 */

using System.ComponentModel.Design;

namespace COMP003.ASSIGNMENT4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // For Loop Section (Right Triangle)
            Console.WriteLine("Enter a positive whole number");
            int limit= Convert.ToInt32(Console.ReadLine());
            string output = "#";

            for (int i=0; i< limit; i++)
            {
                Console.WriteLine(output);
                output += "#";
            }

            // For Each Section (Friends)
            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };

            foreach (string friend in friends)
            {
                Console.WriteLine(friend);
            }

            // Do-While Loop Section (Counting by 5s)
            int counter = 0;

            do
            {
                Console.WriteLine(counter);
                counter += 5;
            } while (counter <= 50);

            // While Loop Section (Foo Bar)
            int counter2 = 1;
            while (counter2 <= 20)
            {
                if (counter2 % 2 == 0 && counter2 % 5 == 0)
                {
                    Console.WriteLine("FooBar");
                }
                else if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                }
                else if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                }
                else
                {
                    Console.WriteLine(counter2);
                }
                counter2++;
            }

        }
    }
}
