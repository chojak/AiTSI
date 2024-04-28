using AST.Nodes;
using PKB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Models
{
    public class VarTable : IVarTable
    {
        List<Variable> variables = new List<Variable>();
        public void addVariable(Variable variable)
        {
            throw new NotImplementedException();
        }

        public Variable getVariable(string name)
        {
            throw new NotImplementedException();
        }

        public List<Variable> getVariable()
        {
            throw new NotImplementedException();
        }
    }
}
