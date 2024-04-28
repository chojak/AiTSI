using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Interfaces
{
    public interface IVarTable
    {
        void addVariable(Variable variable);
        Variable getVariable(string name);
        List<Variable> getVariable();
    }
}
