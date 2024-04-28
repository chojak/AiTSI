using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Interfaces
{
    public interface IParent
    {
        void setParent (Statement parent, Statement child);
        Statement getParent(Statement child);
        List<Statement> getChildren(Statement parent);
        List<Statement> getTransientParent(Statement child);
        List<Statement> getTransientChildren(Statement child);

    }
}
