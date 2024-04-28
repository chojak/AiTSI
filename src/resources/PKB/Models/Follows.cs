using AST.Nodes;
using PKB.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKB.Models
{
    public class Follows : IFollows
    {
        public Statement getFollowedBy(Statement statement, Statement follows)
        {
            throw new NotImplementedException();
        }

        public Statement getFollows(Statement statement, Statement follows)
        {
            throw new NotImplementedException();
        }

        public Statement getTransientFollowedBy(Statement statement, Statement follows)
        {
            throw new NotImplementedException();
        }

        public List<Statement> getTransientFollows(Statement statement, Statement follows)
        {
            throw new NotImplementedException();
        }

        public void setFollows(Statement statement, Statement follows)
        {
            throw new NotImplementedException();
        }
    }
}
