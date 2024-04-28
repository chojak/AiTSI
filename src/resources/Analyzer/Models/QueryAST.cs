using AST.Interfaces;
using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryProcessor.Models
{
    public class QueryAST : IAst
    {
        public Node CreateNode(AST.Enums.Type type /* type tochange - using exclusive node classes */ )
        {
            throw new NotImplementedException();
        }

        public Node CreateNode(AST.Enums.Type type, string attribute)
        {
            throw new NotImplementedException();
        }

        public string Display()
        {
            throw new NotImplementedException();
        }

        public string GetAttr(Node node)
        {
            throw new NotImplementedException();
        }

        public Node GetFirstChild(Node node)
        {
            throw new NotImplementedException();
        }

        public Node GetLinkedNode(AST.Enums.Type type, Node node)
        {
            throw new NotImplementedException();
        }

        public Node GetRoot()
        {
            throw new NotImplementedException();
        }

        public AST.Enums.Type GetType(Node node)
        {
            throw new NotImplementedException();
        }

        public void SetAttr(Node node, string attribute)
        {
            throw new NotImplementedException();
        }

        public void SetChildOfLink(Node child, Node parent)
        {
            throw new NotImplementedException();
        }

        public void SetFirstChild(Node parent, Node child)
        {
            throw new NotImplementedException();
        }

        public void SetLeftSibling(Node node, Node leftSibling)
        {
            throw new NotImplementedException();
        }

        public void SetLink(AST.Enums.Type type, Node node1, Node node2)
        {
            throw new NotImplementedException();
        }

        public void SetRightSibling(Node node, Node rightSibling)
        {
            throw new NotImplementedException();
        }

        public void SetRoot(Node node)
        {
            throw new NotImplementedException();
        }
    }
}
