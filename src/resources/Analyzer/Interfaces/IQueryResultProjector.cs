﻿using AST.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryProcessor.Interfaces
{
    public interface IQueryResultProjector
    {
        public string getResult(Statement stmt);
    }
}
