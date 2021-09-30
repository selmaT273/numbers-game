using System;

namespace numbers_game
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                StartSequence();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            finally
            {
                Console.Write("The program is complete.");
            }
        }

        static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero.");
            string userData = Console.ReadLine();
            try {
                int arrSize = Convert.ToInt32(userData);
                int[] arrToFill = new int[arrSize];
                int[] populatedArr = Populate(arrToFill);
                int finalSum = GetSum(populatedArr);
                int product = GetProduct(populatedArr, finalSum);
                int numFromIndex = product / finalSum;
                string arrString = String.Join(",", populatedArr);
                Console.WriteLine($"Your array size is: {arrSize}");
                Console.WriteLine($"The numbers in the array are {arrString}");
                Console.WriteLine($"The sum is {finalSum}");
                Console.WriteLine($"{finalSum} * {numFromIndex} = {product}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
            
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

            if(totalSum < 20)
            {
                throw new SumTooLowException($"Value of {totalSum} is too low.");
            }
            return totalSum;
        }

        static int GetProduct(int[] numArr, int sum)
        {
            int maxNum = numArr.Length;
            Console.WriteLine($"Pick a number between 1 and {maxNum}");
            string userInput = Console.ReadLine();
            int randomNum = Convert.ToInt32(userInput);
            try 
            {
                int numFromArr = numArr[randomNum - 1];
                int product = sum * numFromArr;
                return product;
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException(ex.Message);
            }
        }
     }

    public class SumTooLowException : Exception
    { 
        public SumTooLowException() { }

        public SumTooLowException(string message)
            : base(message) { }
    }
}
