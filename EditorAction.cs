namespace UndoFeatureTextEditor;

public enum ActionType
{
    Insert,
    Delete
}

public class EditorAction
{
    public ActionType Type { get; set; }
    public string Content { get; set; }
    public int Position { get; set; }

    public EditorAction(ActionType type, string content, int position)
    {
        Type = type;
        Content = content;
        Position = position;
    }

    public override string ToString()
    {
        return $"{Type} \"{Content}\" at position {Position}";
    }
}
