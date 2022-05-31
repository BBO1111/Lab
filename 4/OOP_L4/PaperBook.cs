using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L4
{
    internal class PaperBook:Page
    {
       public PaperBook()
       {
            Console.WriteLine("Створена книга");
            
       }
        
        public void ShowInfo()
        {
            Console.Write($"Розмiр шрифту: {_fontSize}\nНазва шрифту: {_fontName}");
            Console.WriteLine("\nТекст:");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_text);

            if (Console.ForegroundColor == ConsoleColor.Red)
            { 
                _textColor = "Червоний";
            }
            else if (Console.ForegroundColor == ConsoleColor.Green)
            {
                _textColor = "Зелений";
            }
            else if(Console.ForegroundColor== ConsoleColor.Cyan)
            {
                _textColor = "Блакитний";
            }
            Console.ResetColor();
            Console.WriteLine($"Колiр тексту: {_textColor}");
        }

    }
}
