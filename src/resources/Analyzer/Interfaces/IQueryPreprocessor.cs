using AST.Interfaces;
using QueryProcessor.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryProcessor.Interfaces
{
    public interface IQueryPreprocessor
    {
        IAst getQueryTree(string query);
    }
}
