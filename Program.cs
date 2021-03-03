//Find all the capital letters in it that are not included in the English alphabet.
using System;

namespace zaglavnbukv
{
    class Program
    {
        static void FindNonEnglish(String s)
        {
            foreach (char c in s)
            {
                if (char.IsUpper(c) && (c > 90))
                {
                    Console.WriteLine(c);
                }
            }
        }
        static void Main(string[] args)
        {
            String s;
            Console.WriteLine("Enter the line:");
            s = Console.ReadLine();
            FindNonEnglish(s);
        }
    }
}
