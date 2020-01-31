using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Exercise
{
    public class Document
    {
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public DocumentMemento CreateState(Document doc)
        {
            return new DocumentMemento(doc.Content, doc.FontName, doc.FontSize);
        }

        public void RestoreState(DocumentMemento memento)
        {
            Content = memento.Content;
            FontName = memento.FontName;
            FontSize = memento.FontSize;
        }

        public override string ToString()
        {
            return $"Content:{Content}, FontName:{FontName}, FontSize:{FontSize}";
        }
    }
}
