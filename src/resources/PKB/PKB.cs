using AST.Interfaces;
using AST.Models;
using AST.Nodes;
using PKB.Interfaces;
using PKB.Models;

namespace PKB
{
    public class PKB : IPkb
    {
        public IAst ast;

        public ICalls calls;
        public IFollows follows;
        public IModifies modifies;
        public IParent parent;
        public IProcTable procTable;
        public IUses uses;
        public IVarTable varTable;

        public PKB()
        {
            ast = new Ast();
            calls = new Calls();
            follows = new Follows();
            modifies = new Modifies();
            parent = new Parent();
            procTable = new ProcTable();
            uses = new Uses();
            varTable = new VarTable();
        }
    }
}
