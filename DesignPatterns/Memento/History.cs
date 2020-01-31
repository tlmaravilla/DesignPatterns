using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Memento
{
    public class History
    {
        private List<EditorState> _editorStates = new List<EditorState>();

        public void Push(EditorState state)
        {
            _editorStates.Add(state);
        }

        public EditorState Pop()
        {
            return _editorStates.Last();
        }
    }
}
