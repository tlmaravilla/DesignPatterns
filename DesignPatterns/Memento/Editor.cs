﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Memento
{
    public class Editor
    {
        private string _content;

        public EditorState CreateState()
        {
            return new EditorState(_content);
        }

        public void RestoreState(EditorState state)
        {
            _content = state.Content;
        }

        public string GetContent()
        {
            return _content;
        }
    }
}
