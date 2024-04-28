using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Interfaces
{
    public interface IModifies
    {
        public void setModifies(Assign assign, Variable variable);
        public void setModifies(Statement statement, Variable variable);
        public void setModifies(Procedure procedure, Variable variable);
        public List<Variable> getModifiedBy(Assign assign, Variable variable);
        public List<Variable> getModifiedBy(Statement statement);
        public List<Variable> getModifiedBy(Procedure procedure);
        public List<Statement> getTransientModifiyingAssignments(Variable variable);
        public List<Statement> getTransientModifiyingStatements(Variable variable);
        public List<Statement> getTransientModifiyingProcedures(Variable variable);
    }
}