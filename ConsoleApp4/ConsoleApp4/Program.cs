using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Info inf = new Info();
            Human hum = new Human();
            int i = 0;
            Person person = new Person();
            /*Console.WriteLine("Enter the name");
            hum.Name = Console.ReadLine();
            Console.WriteLine("Enter the surname");
            hum.Surname = Console.ReadLine();
            Console.WriteLine("Enter the age");
            hum.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the univercity");
            hum.Univercity = Console.ReadLine();
            Console.WriteLine("Enter the specialty");
            hum.Specialty = Console.ReadLine();
            inf.Student();
            person[0] = hum;*/
            int sw = 0;
            while (sw != 3)
            {
                Console.WriteLine("1 - Get info\n2 - Write info\n3- Exit");
                try
                {
                    sw = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                }
                switch (sw)
                {
                    case 1:
                        Console.WriteLine("Enter the name");
                        hum.Name = Console.ReadLine();
                        Console.WriteLine("Enter the surname");
                        hum.Surname = Console.ReadLine();
                        Console.WriteLine("Enter the age");
                        hum.Age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the univercity");
                        hum.Univercity = Console.ReadLine();
                        Console.WriteLine("Enter the specialty");
                        hum.Specialty = Console.ReadLine();
                        inf.Student();
                        person[i] = hum;
                        i++;
                        break;
                    case 2:
                        for (i=0; i<10; i++)
                        {
                            Console.WriteLine(person[i].Name + " " + person[i].Surname + " " + person[i].Univercity + " " + person[i].Specialty);
                        }
                        break;
                    case 3:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}