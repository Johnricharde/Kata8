using System.ComponentModel;

namespace Kata8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static char FindMissingLetter(char[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] > 1)
                    return (char)(array[i] + 1);
            }
            return ' ';
        }
// Write a method that takes an array of consecutive(increasing) letters as
// input and that returns the missing letter in the array.

// You will always get an valid array.
// And it will be always exactly one letter be missing.
// The length of the array will always be at least 2.
// The array will always contain letters in only one case.

// Example:
// ['a','b','c','d','f'] -> 'e'
// ['O','Q','R','S'] -> 'P'
    }
}
