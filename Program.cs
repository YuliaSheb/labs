//Implement effective mixing of the characters in the string
using System;

namespace shuffle
{
    class Program
    {
        static String Shuffle(String s)
        {
            var rand = new Random();
            var cArr = s.ToCharArray();
            for (var j = cArr.Length - 1; j > 0; j--)
            {
                var i = rand.Next(j);
                char c = cArr[i];
                cArr[i] = cArr[j];
                cArr[j] = c;
            }
            return new string(cArr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the line" );
            string letters = Console.ReadLine();
            String res = Shuffle(letters);
            Console.WriteLine(res);
        }
    }
}
