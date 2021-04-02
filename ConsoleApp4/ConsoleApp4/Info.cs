using System;
namespace ConsoleApp4
{
    class Info
    {
        private static void Id()
        {
            Console.WriteLine("Unique Id student");
            int id;
            Random rand = new Random();
            id = rand.Next(100000, 999999);
            Console.WriteLine(id);
        }
        private static void Grade()
        {
            int sum = 0;
            int t = 0;
            int srednarifm;
            Console.WriteLine("Enter the student's grades for the subject tools and programming tools:");
            while (true)
            {
                int mark = Convert.ToInt32(Console.ReadLine());
                if (mark < 0 || mark > 10)
                {
                    Console.WriteLine("Mark does not exist ");
                }
                if (mark >= 0 || mark < 11)
                {
                    sum += mark;
                    t++;
                }
                Console.WriteLine("Click h to finish entering the marks");
                if (Console.ReadLine() == "h")
                {
                    break;
                }
            }
            srednarifm = sum / t;
            Console.WriteLine("Average student score " + srednarifm);
        }
        public void Student()
        {
            Console.WriteLine("Choose a course:");
            string course = Console.ReadLine();
            switch (course)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("This is no such course");
                    break;
            }
            Grade();
            Id();
        }
    }
}
