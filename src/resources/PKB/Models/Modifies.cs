using AST.Nodes;
using PKB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Models
{
    public class Modifies : IModifies
    {
        public List<Variable> getModifiedBy(Assign assign, Variable variable)
        {
            throw new NotImplementedException();
        }

        public List<Variable> getModifiedBy(Statement statement)
        {
            throw new NotImplementedException();
        }

        public List<Variable> getModifiedBy(Procedure procedure)
        {
            throw new NotImplementedException();
        }

        public List<Statement> getTransientModifiyingAssignments(Variable variable)
        {
            throw new NotImplementedException();
        }

        public List<Statement> getTransientModifiyingProcedures(Variable variable)
        {
            throw new NotImplementedException();
        }

        public List<Statement> getTransientModifiyingStatements(Variable variable)
        {
            throw new NotImplementedException();
        }

        public void setModifies(Assign assign, Variable variable)
        {
            throw new NotImplementedException();
        }

        public void setModifies(Statement statement, Variable variable)
        {
            throw new NotImplementedException();
        }

        public void setModifies(Procedure procedure, Variable variable)
        {
            throw new NotImplementedException();
        }
    }
}
