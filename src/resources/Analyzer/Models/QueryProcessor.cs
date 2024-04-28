using AST.Interfaces;
using AST.Nodes;
using PKB.Interfaces;
using QueryProcessor.Interfaces;

namespace QueryProcessor.Models;

public class QueryProcessor : IQueryProcessor
{
    private IPkb _pkb;
    private IQueryPreprocessor _preprocessor;
    private IQueryEvaluator _evaluator;
    private IQueryResultProjector _projector;

    private IAst _queryAst;
    private Statement _queryStatement;
    
    public QueryProcessor(IPkb pkb)
    {
        _pkb = pkb;
        _preprocessor = new QueryPreprocessor();
        _evaluator = new QueryEvaluator(pkb);
    }

    public string getQueryTreeDisplay(string query)
    {
        _queryAst = _preprocessor.getQueryTree(query);
        return _queryAst.Display();
    }

    public Statement evaluateQuery()
    {
        _queryStatement = _evaluator.evaluate(_queryAst);
        return _queryStatement;
    }

    public string getResult()
    {
        return _projector.getResult(_queryStatement);
    }

    public string processQuery(string query)
    {
        _queryAst = _preprocessor.getQueryTree(query);
        _queryStatement = _evaluator.evaluate(_queryAst);
        return _projector.getResult(_queryStatement);
    }
}