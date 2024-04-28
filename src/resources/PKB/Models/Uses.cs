using AST.Nodes;
using PKB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Models
{
    public class Uses : IUses
    {
        public List<Variable> getUsetVariables(Assign assign)
        {
            throw new NotImplementedException();
        }

        public List<Variable> getUsetVariables(Statement statement)
        {
            throw new NotImplementedException();
        }

        public List<Variable> getUsetVariables(Procedure procedure)
        {
            throw new NotImplementedException();
        }

        public void setUses(Assign assign, Variable variable)
        {
            throw new NotImplementedException();
        }

        public void setUses(Statement statement, Variable variable)
        {
            throw new NotImplementedException();
        }

        public void setUses(Procedure procedure, Variable variable)
        {
            throw new NotImplementedException();
        }
    }
}
