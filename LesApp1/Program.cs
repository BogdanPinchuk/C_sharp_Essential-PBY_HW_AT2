using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // підключення Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // печемо пиріг/торт
            Pie pie = new Pie();

            // друкуємо на коробку дату
            pie.GetManufacturingDate();
            Console.WriteLine("\n\tBon appetit =)");

            // delay
            Console.ReadKey(true);
        }
    }
}
