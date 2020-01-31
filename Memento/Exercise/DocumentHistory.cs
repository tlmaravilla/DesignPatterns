using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Exercise
{
    public class DocumentHistory
    {
        private readonly List<DocumentMemento> _docStates = new List<DocumentMemento>();

        public void Push(DocumentMemento memento)
        {
            _docStates.Add(memento);
        }

        public DocumentMemento Pop()
        {
            return _docStates.Last();
        }
    }
}
