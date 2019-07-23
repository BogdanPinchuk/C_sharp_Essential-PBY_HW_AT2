using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // підключення Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створюємо екземпляр павука
            Spider spider = new Spider();

            // безкінечний цикл подібно до алгоритму Дейкстра
            for (; ; )
            {
                spider.ShowWeb(Console.ReadKey(true).KeyChar);
            }
        }
    }
}
