
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main()
        {
            Student[] studentGroup = 
            {
                new Student("Gosho", "Dimitrov", 3),
                new Student("Ivan", "Stoynov", 4),
                new Student("Peter", "Atanasov", 2),
                new Student("AAA", "BBA",3),
                new Student("AAB", "BBB",4),
                new Student("AAC", "BBC",6),
                new Student("AAD", "BBD",3),
                new Student("AAE", "BBE",2),
                new Student("AAF", "BBF",5),
                new Student("AAG", "BBG",5),
                new Student("AAH", "BBH",3),
            };
            studentGroup.ToArray();

            Worker[] workerGroup = 
            {
                new Worker("WWA","DDA", 100, 10),
                new Worker("WWB","DDB", 200, 9),
                new Worker("WWC","DDC", 300, 8),
                new Worker("WWD","DDD", 400, 7),
                new Worker("WWE","DDE", 500, 6),
                new Worker("WWF","DDF", 600, 5),
                new Worker("WWG","DDG", 700, 4),
                new Worker("WWH","DDH", 800, 3),
                new Worker("WWI","DDI", 900, 2),
                new Worker("WWJ","DDJ", 999, 1),
            };
            workerGroup.ToArray();

            // Sorting students ascending by grades

            var studentSort = studentGroup.OrderBy(Student => Student.Grade);

            foreach (var student in studentSort)
            {
                Console.WriteLine("Student {0} {1} has grade: {2}", student.FirstName, student.LastName, student.Grade);
            }
            Console.WriteLine();
            // Sorting Workers descending by money per hour
            var workersSort = workerGroup.OrderByDescending(Worker => Worker.MoneyPerHour(Worker.WeekSalary, Worker.WorkHoursPerDay));
            foreach (var worker in workersSort)
            {
                Console.WriteLine("Worker {0} {1} earn {2:0.00}$ per hour.", worker.FirstName, worker.LastName, worker.MoneyPerHour(worker.WeekSalary, worker.WorkHoursPerDay));
            }


            // Merging students and workers and sorting them by First and Last name
            var allHumans = studentGroup.Concat<Human>(workerGroup);
            var SortHumans = allHumans.OrderBy(Human => Human.FirstName).OrderBy(Human => Human.LastName);
            Console.WriteLine("\nSorting the humans: ");
            foreach (var human in SortHumans)
            {
                Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
            }

        }
    }
}
