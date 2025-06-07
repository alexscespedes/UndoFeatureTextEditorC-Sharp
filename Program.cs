namespace UndoFeatureTextEditor;

class Program
{
    static void Main(string[] args)
    {
        var editorAction = new EditorAction(ActionType.Insert, "Hello world", 1);

        Console.WriteLine(editorAction.ToString());
    }
}
