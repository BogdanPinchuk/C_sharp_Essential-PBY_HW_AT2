using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// не бачу смисла ставити тип більше byte, так як ні прожити
// ні пропрацювати стільки покищо не можливо

namespace Workers
{
    /// <summary>
    /// Працівник
    /// </summary>
    partial class Worker
    {
        /// <summary>
        /// Вік
        /// </summary>
        public byte Age { get; set; }
        /// <summary>
        /// Ім'я
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Стаж роботи
        /// </summary>
        public byte WorkExperience { get; set; }

    }
}
