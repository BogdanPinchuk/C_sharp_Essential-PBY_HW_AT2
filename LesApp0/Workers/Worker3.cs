using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    partial class Worker
    {
        public void ShowWorkerInfo()
        {
            Console.WriteLine($"\n\tСпівробітник: {Name}");
            Console.WriteLine($"\tВік: {Age}");
            if (WorkExperience > 0)
            {
                Console.WriteLine($"\tСтаж: {WorkExperience}\n");
            }
        }
    }
}
