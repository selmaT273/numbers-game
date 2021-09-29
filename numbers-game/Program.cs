using System;

namespace numbers_game
{
    class Program
    {
        static void Main(string[] args)
        {
            StartSequence();
        }

        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero.");
            string userData = Console.ReadLine();
            int arrSize = Convert.ToInt32(userData);
            int[] numArray = new int[arrSize];
            Populate(numArray);
        }

        static void Populate(int[] numArr)
        { 
            int startingIndex = 1;
            for(int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {startingIndex}/{numArr.Length}");
                string dataToAdd = Console.ReadLine();
                int numToAdd = Convert.ToInt32(dataToAdd);
                numArr[i] = numToAdd;
                startingIndex++;
            }
        }
    }
}
