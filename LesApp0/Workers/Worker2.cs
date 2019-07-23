using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    partial class Worker
    {
        /// <summary>
        /// Ініціалізація за замовчуванням
        /// </summary>
        public Worker() { }

        // конструктори коритувача
        public Worker(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Worker(string name, byte age, byte workExp)
            : this(name, age)
        {
            this.WorkExperience = workExp;
        }

    }
}
