using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Exercise
{
    public class DocumentState
    {
        public DocumentState(Document doc)
        {
            Document = doc;
        }

        public Document Document { get; }
    }
}
