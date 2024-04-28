using AST.Interfaces;
using AST.Nodes;
using PKB;
using PKB.Interfaces;
using QueryProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryProcessor.Models
{
    public class QueryEvaluator : IQueryEvaluator
    {
        private IPkb _pkb;
        public QueryEvaluator(IPkb pkb) 
        {
            _pkb = pkb;
        }

        Statement IQueryEvaluator.evaluate(IAst ast)
        {
            throw new NotImplementedException();
        }
    }
}
