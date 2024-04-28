using AST.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Interfaces
{
    public abstract class IPkb
    {
        public IAst ast;

        public ICalls calls;
        public IFollows follows;
        public IModifies modifies;
        public IParent parent;
        public IProcTable procTable;
        public IUses uses;
        public IVarTable varTable;
    }
}
