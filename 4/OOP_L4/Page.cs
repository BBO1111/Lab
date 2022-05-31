using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L4
{
    internal class Page : IText
    {
        

        private int pages;

        public string _text { get; set; }
        public string _textColor { get; set; }
        public int _fontSize { get; set; }
        public string _fontName { get; set; }
        

        public void SymbolCount()
        {
            Console.WriteLine($"Кiлькiсть символiв - {_text.Length} ");
        }

        public void PageCount()
        {
            Random random = new Random();
            pages = random.Next(50, 260);
            Console.WriteLine($"Кiлькiсть сторiнок - {pages}");

        }
      
    }
}
