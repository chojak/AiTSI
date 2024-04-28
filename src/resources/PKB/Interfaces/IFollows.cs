using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Interfaces
{
    public interface IFollows
    {
        public void setFollows(Statement statement, Statement follows);
        public Statement getFollows(Statement statement, Statement follows);
        public Statement getFollowedBy(Statement statement, Statement follows);
        public List<Statement> getTransientFollows(Statement statement, Statement follows);
        public Statement getTransientFollowedBy(Statement statement, Statement follows);
    }
}
