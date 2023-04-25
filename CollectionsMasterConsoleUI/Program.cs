using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            var numArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numArray);

            //TODO: Print the first number of the array
            Console.WriteLine($"First number of array = {numArray[0]}");

            //TODO: Print the last number of the array
            Console.WriteLine($"Last number of array = {numArray[numArray.Length - 1]}");

            Console.WriteLine("-------------------");


            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numArray);
            NumberPrinter(numArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine($"Capacity: {numList.Capacity}");

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numList);

            //TODO: Print the new capacity
            Console.WriteLine($"New Capacity: {numList.Capacity}");

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            int userInput;
            bool isNumber;

            Console.WriteLine("What number will you search for in the number list?");
            do
            {
                isNumber = int.TryParse(Console.ReadLine(), out userInput);
            } while (isNumber == false);

            NumberChecker(numList, userInput);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);

            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(numList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numList.Sort();
            NumberPrinter(numList);

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var newNumArray = numList.ToArray();

            //TODO: Clear the list
            numList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numArray)
        {
            for(int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 3 == 0)
                {
                    numArray[i] = 0;
                }
            }

            NumberPrinter(numArray);
        }

        private static void OddKiller(List<int> numList)
        {
            numList.RemoveAll(i => i % 2 != 0);
            
            NumberPrinter(numList);
        }

        private static void NumberChecker(List<int> numList, int searchNumber)
        {
            if (numList.Contains(searchNumber))
            {
                Console.WriteLine($"Yes, I have the number you are searching for");
            }
            else
            {
                Console.WriteLine($"No, I do not have the number you are searching for");
            }
        }

        private static void Populater(List<int> numList)
        {
            while(numList.Count < 51)
            {
                Random rng = new Random();
                var number = rng.Next(0, 50);

                numList.Add(number);
            }
            NumberPrinter(numList);

        }

        private static void Populater(int[] numArray)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                Random rng = new Random();
                numArray[i] = rng.Next(0, 50);
            }
        }        

        private static void ReverseArray(int[] numarray)
        {
            Array.Reverse(numarray);

            NumberPrinter(numarray);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
