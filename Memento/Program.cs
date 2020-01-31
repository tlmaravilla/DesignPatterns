using System;
using Memento.Example;
using Memento.Exercise;

namespace Memento
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //RunDemo();

            RunExercise();
            Console.ReadLine();
        }

        public static void RunDemo()
        {
            var editor = new Editor();
            var history = new EditorHistory();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());
            
            editor.Content = "c";
            editor.RestoreState(history.Pop());
            Console.WriteLine($"State After Restore: {editor.Content}");
        }

        public static void RunExercise()
        {
            var history = new DocumentHistory();

            var doc = new Document {Content = "The Title", FontName = "Times New Roman", FontSize = 12};
            history.Push(doc.CreateState(doc));

            doc = new Document { Content = "The Body", FontName = "Times New Roman", FontSize = 11 };
            history.Push(doc.CreateState(doc));

            Console.WriteLine($"State After Save: {doc.ToString()}");

            doc = new Document { Content = "The Footer", FontName = "Times New Roman", FontSize = 14 };
            doc.RestoreState(history.Pop());
            Console.WriteLine($"State After Restore: {doc.ToString()}");
        }
    }
}