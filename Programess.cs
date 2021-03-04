//Replace all the letters after the vowels with the next letters in the alphabet (z is replaced by a).
using System;
using System.Linq;


namespace sledbukva
{
    class Program
    {
        static String ChangeString(String s)
        {
            var arr = s.ToCharArray();
            for (int i=0; i < arr.Count()- 1; i++)
            {
                if ("aeiouy".IndexOf(arr[i])>= 0)
                {
                    char c = (++arr[i + 1]);
                    if (c > 'z')
                    {
                        c = 'a';
                    }
                    arr[i + 1] = c;
                }
            }
            return new String(arr);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the line");
            string letters = Console.ReadLine();
            String res = ChangeString(letters);
            Console.WriteLine(res);
        }
    }
}
