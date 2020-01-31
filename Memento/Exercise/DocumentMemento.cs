using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Exercise
{
    public class DocumentMemento
    {

        public string FontName { get; }
        public string Content { get; }
        public int FontSize { get; }

        public DocumentMemento(string content, string fontName, int fontSize)
        {
            Content = content;
            FontName = fontName;
            FontSize = fontSize;
        }
    }
}
