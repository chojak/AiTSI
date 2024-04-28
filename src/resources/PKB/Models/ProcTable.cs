using AST.Nodes;
using PKB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Models
{
    public class ProcTable : IProcTable
    {
        private List<Procedure> procedureList = new List<Procedure>();
        public void addProcedure(Procedure procedure)
        {
            throw new NotImplementedException();
        }

        public List<Procedure> getProcedure(string name)
        {
            throw new NotImplementedException();
        }

        public List<Procedure> getProcedureList()
        {
            throw new NotImplementedException();
        }
    }
}
