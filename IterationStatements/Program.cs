using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();

            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num  -DONE
            //initialize the variable with a value of 0      -DONE
            int num;
            num = 0;

            // Create a do-while loop and use the template below:  -DONE

            do
            {    // Increment num by 1   -DONE
                num++;
                // Then add num to the collection - numbers   -DONE
                // Hint: reference num inside of the Add method's parentheses
                numbers.Add(num);

                // <---- While your variable is less than 100  -DONE             
            } while (num < 100);



            // Create a while loop
            // <--- While num is less than 200  -DONE
            while (num < 200)
            {
                num++;
                numbers.Add(num);
                // Increment num by 1   -DONE
                // Then add num to the collection numbers   -DONE
                    //HINT: copy how this was done in the do while loop

            }


            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers   -DONE
            //In the scope of the foreach loop, print each number in numbers   -DONE

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1   -DONE
                // in your initializer set the value of i to 199   -DONE
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)  -DONE
                // AND as long as i is greater than or equal to 0  -DONE
                // Decrement i by 1  -DONE
                for (int i = 199; i <= numbers.Count && i >= 0; i--)
            //start for loop here
            {
                Console.WriteLine(numbers[i]);
                // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise
        }
    }
}
