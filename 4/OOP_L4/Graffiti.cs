using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L4
{
    internal class Graffiti : IText
    {
        public string _text { get; set; }
        public string _textColor { get; set; }
        public int _fontSize { get; set; }
        public string _fontName { get; set; }
        public Graffiti()
        {
            Console.WriteLine("Створено граффтi");
        }
        public void SymbolCount()
        {
            Console.WriteLine($"Кiлькiсть символiв - {_text.Length} ");
        }
        public void PageCount()
        {
            Console.WriteLine("Сторiнки відсутні");
        }
        public void ShowInfo()
        {
            Console.Write($"Розмiр шрифту: {_fontSize}\nНазва шрифту: {_fontName}");
            Console.WriteLine("\nТекст:");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(_text);

            if (Console.ForegroundColor == ConsoleColor.Red)
            {
                _textColor = "Червоний";
            }
            else if (Console.ForegroundColor == ConsoleColor.Blue)
            {
                _textColor = "Синій";
            }
            else if (Console.ForegroundColor == ConsoleColor.Yellow)
            {
                _textColor = "Жовтий";
            }
            Console.ResetColor();
            Console.WriteLine($"Колiр тексту: {_textColor}");
        }
    }
}
