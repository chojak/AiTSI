using AST.Interfaces;
using QueryProcessor.Enums;
using QueryProcessor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryProcessor.Models
{
    public class QueryPreprocessor : IQueryPreprocessor
    {
        public Dictionary<QueryToken, string> QueryDictionary = new Dictionary<QueryToken, string>();

        public IAst getQueryTree(string query)
        {
            IAst queryTree; 
            try
            {
                queryChecker(query);
                queryTree = createQueryTree(query);
            }
            catch
            {
                throw new Exception("getQueryTree exception.");
            }
            return queryTree;
        }

        private bool queryChecker(string query)
        {
            return true;
        } 

        private IAst createQueryTree(string query)
        {
            return new QueryAST();
        }
    }
}
