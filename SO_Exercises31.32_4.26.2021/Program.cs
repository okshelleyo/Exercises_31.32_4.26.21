using System;
using System.Linq;

namespace SO_Exercises31._32_4._26._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool keepLooping = true;


            while (keepLooping)
            {
                int[] numbers = { 2, 8, 0, 24, 51 };

                //EXERCISE 32: Prompt the user to enter a number.If the number is in the array, display the index. 

                Console.WriteLine("Enter a number");
                int userNum = int.Parse(Console.ReadLine());
                int index = Array.IndexOf(numbers, userNum);


                if (index > 0)
                {  // Array.Index will return -1 if the index does not exist. 

                    Console.WriteLine($"The value {userNum} can be found at index {index}");

                }
                else
                {
                    Console.WriteLine("The value cannot be found in the array");
                } 


                // EXERCISE 31: prompt the user to enter an index. Display the element in the array at that index" 

                Console.WriteLine("Enter an index of the array.");
                int userIndex = int.Parse(Console.ReadLine());
                int totalElements = numbers.Count();

                if (userIndex > totalElements)
                {
                    Console.WriteLine("That is not a valid index");
                } else
                {
                    Console.WriteLine($"The value at index {userIndex} is {numbers[userIndex]}");
                }

                                
                Console.WriteLine("Would you like to continue? (y/n)");
                string userPlay = Console.ReadLine().ToLower();

                if (userPlay == "y")
                {
                    keepLooping = true;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    keepLooping = false;
                }
            }

        }
    }   
}

       

        

    

