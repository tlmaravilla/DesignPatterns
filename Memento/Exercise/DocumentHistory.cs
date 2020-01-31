using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento.Exercise
{
    public class DocumentHistory
    {
        private readonly List<DocumentState> _docStates = new List<DocumentState>();

        public void Push(DocumentState state)
        {
            _docStates.Add(state);
        }

        public DocumentState Pop()
        {
            return _docStates.Last();
        }
    }
}
