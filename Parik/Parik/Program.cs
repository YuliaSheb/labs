using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в парикмахерскую!");
            int N,t=20;
            Console.WriteLine("Количество клиентов:");
            N = Convert.ToInt32(Console.ReadLine());
            Info info = new Info();
            List<Info> people = new List<Info>(N);
            for (int i = 0; i < N; i++)
            {
                int k = i + 1;
                Console.WriteLine("Время прихода  " + k + " клиента:");
                Console.WriteLine("Представтесь:");
                info.Name = Console.ReadLine();
                Console.WriteLine("Часы:");
                info.Time = Convert.ToInt32(Console.ReadLine());
                while ((info.Time <= 0) || (info.Time >= 23))
                {
                    Console.WriteLine("Неправильный ввод");
                    info.Time = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Минуты:");
                info.Time_m = Convert.ToInt32(Console.ReadLine());
                while ((info.Time_m <= 0) || (info.Time_m >= 59))
                {
                    Console.WriteLine("Неправильный ввод");
                    info.Time_m = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Терпение клиента:");
                info.Terpenie = Convert.ToInt32(Console.ReadLine());
                while ((info.Terpenie < 0) || (info.Terpenie >= 100))
                {
                    Console.WriteLine("Неправильный ввод");
                    info.Terpenie = Convert.ToInt32(Console.ReadLine());
                }
                people.Add(new Info() { Name = info.Name, Time = info.Time, Time_m = info.Time_m, Terpenie = info.Terpenie });
            }

            var sortedUsers = from u in people
                              orderby u.Time
                              select u;

            foreach (Info u in sortedUsers)
            {
                Console.WriteLine($"{u.Name} {u.Time}.{u.Time_m}, {u.Terpenie}");
            }
            /*int sum = 0,n=0;
            foreach (Info p in people)
            {
                    if (sum > p.Terpenie)
                    {
                        Console.WriteLine("Клиент " + p.Name + " ушел");
                        people.RemoveAt(n);
                        sum--;
                    }
                    else
                    {
                        sum++;
                    }
                n++; 
            }
            Console.WriteLine("В очереди осталось "+sum+" человек");*/
            Console.WriteLine("Парикмахер стрижет клиента за " + t + " минут:");
            foreach (Info p in people)
            {
                int temp;
                temp = p.Time_m + t;
                if (temp>60)
                {
                    p.Time++;
                    temp -= 60;
                }
                Console.WriteLine(info.Name + " вышел из парикмахерской в "+p.Time+"."+temp);
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
