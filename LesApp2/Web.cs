using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    /// <summary>
    /// Павутина
    /// </summary>
    class Web
    {
        /// <summary>
        /// Колір павутини
        /// </summary>
        public string WebColor { get; set; } = "сірий";

        public ConsoleColor TextColor { get; set; } = ConsoleColor.Gray;

        /// <summary>
        /// зміна кольору павутини
        /// </summary>
        /// <param name="color"></param>
        public void ChangeWebColor(string color)
        {
            switch (color)
            {
                case "к":
                case "r":
                    WebColor = "червоний";
                    TextColor = ConsoleColor.Red;
                    break;
                case "и":
                case "b":
                    WebColor = "синій";
                    TextColor = ConsoleColor.Blue;
                    break;
                case "ц":
                case "w":
                    WebColor = "білий";
                    TextColor = ConsoleColor.White;
                    break;
                case "н":
                case "y":
                    WebColor = "жовтий";
                    TextColor = ConsoleColor.Yellow;
                    break;
                case "п":
                case "g":
                    WebColor = "зелений";
                    TextColor = ConsoleColor.Green;
                    break;
                case "ь":
                case "m":
                    WebColor = "розовий";
                    TextColor = ConsoleColor.Magenta;
                    break;
                case "с":
                case "c":
                    WebColor = "блакитний";
                    TextColor = ConsoleColor.Cyan;
                    break;
                default:
                    WebColor = "сірий";
                    TextColor = ConsoleColor.Gray;
                    break;
            }
        }
    }
}
