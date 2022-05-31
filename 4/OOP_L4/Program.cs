using System;

namespace OOP_L4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaperBook book = new PaperBook
            { _text = "Немає більше русського воєнного корабля",
                _fontName = "Times new Roman",
                _fontSize = 18,
                _textColor = "Yellow"

            };
            book.PageCount();
            book.ShowInfo();
            book.SymbolCount();
            Console.WriteLine();
            Console.WriteLine();
            ElectrinicBook electrinicBook = new ElectrinicBook
            {
                _text = "Звісно, я тобі допоможу",
                _fontName = "Segoe UI",
                _fontSize = 12

            };
            electrinicBook.PageCount();
            electrinicBook.ShowInfo();
            electrinicBook.SymbolCount();

            Console.WriteLine();
            Console.WriteLine();

            Graffiti graffiti = new Graffiti
            {
                _text = "Zомбі",
                _fontName = "Calibri",
                _fontSize = 56
            };
            graffiti.PageCount();
            graffiti.ShowInfo();
            graffiti.SymbolCount();



        }
    }
}
