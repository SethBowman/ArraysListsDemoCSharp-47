using System.Collections.Generic;

namespace ArraysListsDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arrays
            //Arrays have a set size that define at creation and that size cannot change
            int[] numbers = new int[] {12, 50, 40, 12, 5};

            numbers[1] = 4000;

          
            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //Arrays have a property called "Length" that shows you the number of things in the array
            //Console.WriteLine(numbers.Length - 1);

            var names = new string[] { "Seth", "Mack", "Cruz" };

            //Console.WriteLine(names.Length);

            //for(int i = names.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //for(int i = 0; i <= names.Length - 1; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}


            //Lists
            //Lists have a size that can change all you want
            //Lists have a property called "Count" that gives you the number of things in the List

            List<int> numbersList = new List<int>() { 34, 60, 200, 5, 3 };

            //numbersList.Add(1000);
            //numbersList.Remove(numbersList[numbersList.Count - 1]);

            //foreach(int number in numbersList)
            //{
            //    Console.WriteLine(number);
            //}

            var ourClass = new List<string>() { "Brett", "Brooks", "Chris", "Cory", "Jessica", "JP", "Kaitlyn", "Katey", "Levi", "Mack", "Soibi", "Ryan", "Sam", "Seth" };

            //Console.WriteLine(ourClass.Count);

            ourClass.Remove("Seth");

            for(int i = 0; i < ourClass.Count; i++)
            {
                Console.WriteLine(ourClass[i]);
            }
        }
    }
}
