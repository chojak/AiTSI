using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Interfaces
{
    public interface IUses
    {
        void setUses(Assign assign, Variable variable);
        void setUses(Statement statement, Variable variable);
        void setUses(Procedure procedure, Variable variable);

        List<Variable> getUsetVariables(Assign assign); 
        List<Variable> getUsetVariables(Statement statement);
        List<Variable> getUsetVariables(Procedure procedure);
    }
}
