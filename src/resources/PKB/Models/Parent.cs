using AST.Nodes;
using PKB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Models
{
    public class Parent : IParent
    {
        public List<Statement> getChildren(Statement parent)
        {
            throw new NotImplementedException();
        }

        public Statement getParent(Statement child)
        {
            throw new NotImplementedException();
        }

        public List<Statement> getTransientChildren(Statement child)
        {
            throw new NotImplementedException();
        }

        public List<Statement> getTransientParent(Statement child)
        {
            throw new NotImplementedException();
        }

        public void setParent(Statement parent, Statement child)
        {
            throw new NotImplementedException();
        }
    }
}
