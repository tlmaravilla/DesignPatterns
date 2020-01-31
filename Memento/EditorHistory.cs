using System.Collections.Generic;
using System.Linq;

namespace Memento
{
    public class EditorHistory
    {
        private readonly List<EditorState> _editorStates = new List<EditorState>();

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
