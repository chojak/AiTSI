using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Interfaces
{
    public interface ICalls
    {
        public void setCalls(Procedure p, Procedure q);
        public List<Procedure> getCalls(Procedure p);
        public List<Procedure> getCalledBy(Procedure p);
        public List<Procedure> getTransitiveCalls(Procedure p);
        public List<Procedure> getTransitiveCalledBy(Procedure p);
    }
}
