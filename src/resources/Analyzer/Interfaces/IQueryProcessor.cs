using AST.Interfaces;
using AST.Nodes;
using QueryProcessor.Enums;
using QueryProcessor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryProcessor.Interfaces
{
    public interface IQueryProcessor
    {
        /// <summary>
        /// All-in-one method 
        /// </summary>
        /// <param name="query">User's query input</param>
        /// <returns></returns>
        public string processQuery(string query);

        /// <summary>
        /// Method should considered as private, ONLY access it from REST.API
        /// </summary>
        /// <param name="query">User's query input</param>
        /// <returns></returns>
        public string getQueryTreeDisplay(string query);
        /// <summary>
        /// Method should considered as private, ONLY access it from REST.API
        /// </summary>
        /// <returns></returns>
        public Statement evaluateQuery();
        /// <summary>
        /// Method should considered as private, ONLY access it from REST.API
        /// </summary>
        /// <returns></returns>
        public string getResult();
    }
}