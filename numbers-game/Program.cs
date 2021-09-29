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
            int[] arrToFill = new int[arrSize];
            int[] populatedArr = Populate(arrToFill);
            int finalSum = GetSum(populatedArr);
            string arrString = String.Join(",", populatedArr);
            Console.WriteLine($"Your array size is: {arrSize}");
            Console.WriteLine($"The numbers in the array are {arrString}");
            Console.WriteLine($"The sum is {finalSum}");
        }

        static int[] Populate(int[] numArr)
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
            return numArr;
        }

        static int GetSum(int[] numArr)
        {
            int totalSum = 0;
            for(int i = 0; i < numArr.Length; i++)
            {
                totalSum = totalSum + numArr[i];
            }
            return totalSum;
        }
    }
}
