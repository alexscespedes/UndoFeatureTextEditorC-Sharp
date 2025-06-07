namespace UndoFeatureTextEditor;

class Program
{
    static Stack<EditorAction> undoStack = new Stack<EditorAction>();
    static void Main(string[] args)
    {
        PerfomAction(new EditorAction(ActionType.Insert, "Hello", 0));
        PerfomAction(new EditorAction(ActionType.Insert, "World", 5));
        PerfomAction(new EditorAction(ActionType.Insert, "o", 4));

        Console.WriteLine("\nAll actions performed. Press any key to undo them...");
        Console.ReadKey();

        UndoLastAction();
        UndoLastAction();
        UndoLastAction();

        UndoLastAction();

        Console.WriteLine("\nDone.");
    }

    static void PerfomAction(EditorAction action)
    {
        undoStack.Push(action);
        Console.WriteLine($"Performed action: {action}");
    }

    static void UndoLastAction()
    {
        if (undoStack.Count == 0)
        {
            Console.WriteLine("Nothing left to undo.\n");
            return;
        }

        var lastAction = undoStack.Pop();
        Console.WriteLine($"Undo: {lastAction}");
    }
}
