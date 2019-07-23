using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker = Workers.Worker;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // підключення Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // краще створити масивом
            Worker[] workers = new Worker[3];

            // присвоєння даних
            workers[0] = new Worker()
            {
                Name = "Vlad",
                Age = 26,
                WorkExperience = 5
            };
            workers[1] = new Worker("Vadim", 28);
            workers[2] = new Worker("Bogdan", 27, 3);

            // виведення даних
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i].ShowWorkerInfo();
            }

            // delay
            Console.ReadKey(true);
        }
    }
}
