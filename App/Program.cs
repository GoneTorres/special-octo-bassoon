using System;
using System.Linq;
using Numbers;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
            Console.WriteLine("Incorrect amount of parameters");
        else
        {
            int[] num1Arr = string.IsNullOrEmpty(args[0]) ? null : args[0].Select(x => (int)char.GetNumericValue(x)).ToArray();
            int[] num2Arr = string.IsNullOrEmpty(args[1]) ? null : args[1].Select(x => (int)char.GetNumericValue(x)).ToArray();

            decimal? result = NumbersLibrary.ReverseSecondAndAdd(num1Arr, num2Arr);

            Console.WriteLine(result != null ? result : "Invalid parameters");
        }
    }
}

