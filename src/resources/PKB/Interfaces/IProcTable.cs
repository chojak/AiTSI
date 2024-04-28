using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Interfaces
{
    public interface IProcTable
    {
        void addProcedure(Procedure procedure);
        List<Procedure> getProcedure(string name);
        List<Procedure> getProcedureList();
    }
}
