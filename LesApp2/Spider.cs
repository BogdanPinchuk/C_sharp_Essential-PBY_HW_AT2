using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Павук
    /// </summary>
    class Spider
    {
        // створення поля по конструктору за замовчуванням
        private Web web = new Web();

        public void ShowWeb(char key)
        {
            if (key.ToString().ToLower() == "q")
            {
                Console.Beep();
                Environment.Exit(0);    // вихід з програми
            }

            // зміна кольору павутини
            web.ChangeWebColor(key.ToString().ToLower());

            // вивід сповіщення
            Console.ForegroundColor = web.TextColor;
            Console.WriteLine($"\n\tПавутина має {web.WebColor} колір.");
            Console.ResetColor();

        }

    }
}
