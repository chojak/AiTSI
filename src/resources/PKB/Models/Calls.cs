using AST.Nodes;
using PKB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Models
{
    public class Calls : ICalls
    {
        public List<Procedure> getCalledBy(Procedure p)
        {
            throw new NotImplementedException();
        }

        public List<Procedure> getCalls(Procedure p)
        {
            throw new NotImplementedException();
        }

        public List<Procedure> getTransitiveCalledBy(Procedure p)
        {
            throw new NotImplementedException();
        }

        public List<Procedure> getTransitiveCalls(Procedure p)
        {
            throw new NotImplementedException();
        }

        public void setCalls(Procedure p, Procedure q)
        {
            throw new NotImplementedException();
        }
    }
}
