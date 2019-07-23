using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    /// <summary>
    /// Шматок, торт, пиріг
    /// </summary>
    class Pie
    {
        /// <summary>
        /// Дата виробництва
        /// </summary>
        private readonly DateTime manufacturingDate;

        /// <summary>
        /// Ініціалізація з присвоєнням дати
        /// </summary>
        public Pie()
        {
            manufacturingDate = DateTime.Now;
        }

        public void GetManufacturingDate()
        {
            Console.Write("\n\tDate create of pie: ");
            Console.WriteLine(manufacturingDate);
        }

    }
}
