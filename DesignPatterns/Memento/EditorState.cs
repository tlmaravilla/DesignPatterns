using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class EditorState
    {
        public EditorState(string content)
        {
            Content = content;
        }

        public string Content { get; }
    }
}
