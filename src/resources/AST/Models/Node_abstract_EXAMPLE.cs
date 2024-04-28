using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AST.Models
{
    public abstract class Node_abstract_EXAMPLE
    {
        public Node Parent { get; set; }
        public Node LeftSibling { get; set; }
        public Node RightSibling { get; set; }
        public List<Node> Children { get; set; }
    }
}
