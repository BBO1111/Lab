using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L4
{
    internal interface IText
    {
        public string _text { get; set; }

        public string _textColor { get; set; }

        public int _fontSize { get; set; }

        public string _fontName { get; set; }

        public void SymbolCount();

 
    }
}
