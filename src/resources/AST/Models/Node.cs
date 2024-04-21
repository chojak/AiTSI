using System.Text;

namespace AST.Models;

using Type = Enums.Type;

public class Node
{
    public Type Type { get; set; }
    public string Attribute { get; set; }
    public Node Parent { get; set; }
    public Node LeftSibling { get; set; }
    public Node RightSibling { get; set; }
    public List<Node> Children { get; set; }

    public Node()
    {
        Children = new List<Node>();
        Attribute = string.Empty;
    }

    public Node(Type type)
    {
        Type = type;
        Children = new List<Node>();
    }

    public string Display(int number)
    {
        StringBuilder result = new StringBuilder();
        for (var i = 0; i < number; i++)
        {
            result.Append(" ");
        }

        if (Children.Count > 0)
        {
            result.AppendLine(Type + ": " + Attribute);

            foreach (var child in Children)
            {
                result.Append(child.Display(number + 5));
            }
        }
        else
        {
            result.AppendLine(Type + ": " + Attribute);
        }

        return result.ToString();
    }
}