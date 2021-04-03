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
            int s = 0;
            while (s != 2)
            {
                Console.WriteLine("1 - Get info\n2- Exit");
                try
                {
                    s = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                }
                switch (s)
                {
                    case 1:
                        Console.WriteLine("Enter the name");
                        hum.Name = Console.ReadLine();
                        Console.WriteLine("Enter the surname");
                        hum.Surname = Console.ReadLine();
                        Console.WriteLine("Enter the age");
                         try
                        {
                            hum.Age = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Incorrect....Enter the age");
                            hum.Age = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Enter the univercity");
                        hum.Univercity = Console.ReadLine();
                        Console.WriteLine("Enter the specialty");
                        hum.Specialty = Console.ReadLine();
                        inf.Student();
                        person[i] = hum;
                        Console.WriteLine(person[i].Name + " " + person[i].Surname + " ," + person[i].Age + " year," + person[i].Univercity + " ," + person[i].Specialty);
                        i++;
                        break;
                    case 2:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
