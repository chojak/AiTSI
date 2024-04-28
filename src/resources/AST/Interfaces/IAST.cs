using AST.Nodes;
using Type = AST.Enums.Type;

namespace AST.Interfaces;

public interface IAst
{
    Node CreateNode(Type type);
    Node CreateNode(Type type, string attribute);
    void SetRoot(Node node);
    void SetAttr(Node node, string attribute);
    void SetFirstChild(Node parent, Node child);
    void SetRightSibling(Node node, Node rightSibling);
    void SetLeftSibling(Node node, Node leftSibling);
    void SetChildOfLink(Node child, Node parent);
    void SetLink(Type type, Node node1, Node node2);
    Node GetRoot();
    Type GetType(Node node);
    string GetAttr(Node node);
    Node GetFirstChild(Node node);
    Node GetLinkedNode(Type type, Node node);
    string Display();
}