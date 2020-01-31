using System.Collections.Generic;
using System.Linq;

namespace Memento.Example
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
