using System;
using System.Linq;

namespace Numbers
{
    public static class NumbersLibrary
    {
        public static decimal? ReverseSecondAndAdd(this int[] num1Arr, int[] num2Arr)
        {
            if (decimal.TryParse(string.Join("", num1Arr), out decimal num1) && decimal.TryParse(string.Join("", num2Arr.Reverse()), out decimal num2))
                return num1 + num2;
            else
                return null;
        }
    }
}
