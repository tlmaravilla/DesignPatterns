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

        public DocumentState CreateState(Document doc)
        {
            return new DocumentState(doc);
        }

        public void RestoreState(DocumentState state)
        {
            Content = state.Document.Content;
            FontName = state.Document.FontName;
            FontSize = state.Document.FontSize;
        }

        public override string ToString()
        {
            return $"Content:{Content}, FontName:{FontName}, FontSize:{FontSize}";
        }
    }
}
