using AST.Interfaces;
using Type = AST.Enums.Type;

namespace AST.Models;

public class Ast : IAst
{
    private Node root;

    public Node CreateNode(Type type)
    {
        return new Node(type);
    }

    public Node CreateNode(Type type, string attribute)
    {
        Node node = new Node(type);
        node.Attribute = attribute;
        return node;
    }

    public string GetAttr(Node node)
    {
        return node.Attribute;
    }

    public Node GetFirstChild(Node node)
    {
        return node.Children.FirstOrDefault();
    }

    public Node GetLinkedNode(Type type, Node node)
    {
        throw new NotImplementedException();
    }

    public Node GetRoot()
    {
        return this.root;
    }

    public Type GetType(Node node)
    {
        return node.Type;
    }

    public void SetAttr(Node node, string attribute)
    {
        node.Attribute = attribute;
    }

    public void SetChildOfLink(Node child, Node parent)
    {
        parent.Children.Add(child);
    }

    public void SetFirstChild(Node parent, Node child)
    {
        parent.Children.Insert(0, child);
    }

    public void SetLeftSibling(Node node, Node leftSibling)
    {
        node.LeftSibling = leftSibling;
    }

    public void SetLink(Type type, Node node1, Node node2)
    {
        throw new NotImplementedException();
    }

    public void SetRightSibling(Node node, Node rightSibling)
    {
        node.RightSibling = rightSibling;
    }

    public void SetRoot(Node node)
    {
        this.root = node;
    }

    public string Display()
    {
        return root.Display(0);
    }
}