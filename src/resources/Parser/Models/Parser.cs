using AST.Interfaces;
using AST.Models;
using Parser.Interfaces;
using Type = AST.Enums.Type;
using Parser.Enums;

namespace Parser.Models;

public class Parser : IParser
{
    private string _input;
    private string _token;
    private IAst _astTree;

    public void Parse(string input)
    {
        _astTree = new Ast();
        this._input = ParseInput(input);
        ParseProcedure();
    }

    private Node ParseProcedure()
    {
        TakeToken();

        if (!IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.ProcedureKeyword]))
        {
            throw new Exception("ErrorReadingProcName");
        }

        TakeToken();
        var node = _astTree.CreateNode(Type.PROCEDURE, _token);
        _astTree.SetRoot(node);


        _astTree.SetChildOfLink(ParseStatementList(), node);
        return node;
    }

    private Node ParseStatementList()
    {
        TakeToken();
        if (!IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.BeginOfClosure]))
        {
            throw new Exception("ErrorReadingStmtList");
        }

        var stmtListNode = _astTree.CreateNode(Type.STMTLIST);

        Node currentStatement = ParseStatement();
        while (currentStatement != null)
        {
            _astTree.SetChildOfLink(currentStatement, stmtListNode);
            currentStatement = ParseStatement();
        }

        return stmtListNode;
    }

    private Node ParseStatement()
    {
        TakeToken();
        if (IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.EndOfClosure]))
        {
            return null;
        }

        if (IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.WhileStatement]))
        {
            return ParseWhileStatement();
        }
        else if (IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.IfStatement]))
        {
            return ParseIfStatement();
        }
        else
        {
            return ParseAssignStatement();
        }
    }

    private Node ParseWhileStatement()
    {
        TakeToken();

        Node loop = _astTree.CreateNode(Type.WHILE);
        Node codition = _astTree.CreateNode(Type.VARIABLE, _token);
        _astTree.SetChildOfLink(codition, loop);
        _astTree.SetChildOfLink(ParseStatementList(), loop);

        return loop;
    }

    private Node ParseIfStatement()
    {
        TakeToken();
        Node ifNode = _astTree.CreateNode(Type.IF, _token);

        TakeToken();
        if (!IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.ThenStatement]))
        {
            throw new Exception("ErrorReadingIf");
        }

        _astTree.SetChildOfLink(ParseStatementList(), ifNode);


        return ifNode;
    }

    private Node ParseAssignStatement()
    {
        Node assignNode = _astTree.CreateNode(Type.VARIABLE, _token);
        Node assignmentNode = _astTree.CreateNode(Type.ASSIGN);
        _astTree.SetChildOfLink(assignNode, assignmentNode);

        TakeToken();
        if (!IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.AssignmentOperator]))
        {
            throw new Exception("ErrorReadingAssignment");
        }

        Node assignedNode = ParseExpr();
        _astTree.SetChildOfLink(assignedNode, assignmentNode);
        return assignmentNode;
    }

    private Node ParseExpr()
    {
        TakeToken();
        Node node = null;

        if (IsInteger(_token))
        {
            node = _astTree.CreateNode(Type.CONSTANT, _token);
        }
        else
        {
            node = _astTree.CreateNode(Type.VARIABLE, _token);
        }

        TakeToken();
        if (IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.EndOfStatement]))
        {
            return node;
        }
        else if (IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.AdditionOperator]))
        {
            Node plusNode = _astTree.CreateNode(Type.PLUS);
            _astTree.SetChildOfLink(node, plusNode);
            Node expr = ParseExpr();
            _astTree.SetChildOfLink(expr, plusNode);
            return plusNode;
        }
        else if (IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.SubtractionOperator]))
        {
            Node plusNode = _astTree.CreateNode(Type.MINUS);
            _astTree.SetChildOfLink(node, plusNode);
            Node expr = ParseExpr();
            _astTree.SetChildOfLink(expr, plusNode);
            return plusNode;
        }
        else if (IsTokenExpression(LanguageDirectory.Tokens[LanguageToken.MultiplicationOperator]))
        {
            Node plusNode = _astTree.CreateNode(Type.MULTIPLY);
            _astTree.SetChildOfLink(node, plusNode);
            Node expr = ParseExpr();
            _astTree.SetChildOfLink(expr, plusNode);
            return plusNode;
        }
        else
        {
            throw new Exception("ErrorReadingAssignment");
        }
    }

    private void TakeToken()
    {
        _input = _input.TrimStart();
        int tokenLength = _input.IndexOf(" ");
        _token = _input.Substring(0, tokenLength);
        _input = _input.Substring(tokenLength);
    }

    private bool IsTokenExpression(string expression)
    {
        return string.Equals(_token, expression);
    }

    private bool IsInteger(string token)
    {
        if (int.TryParse(token, out int value))
        {
            return true;
        }

        return false;
    }

    private string ParseInput(string input)
    {
        return input.Replace(LanguageDirectory.Tokens[LanguageToken.AdditionOperator],
                " " + LanguageDirectory.Tokens[LanguageToken.AdditionOperator] + " ")
            .Replace(LanguageDirectory.Tokens[LanguageToken.AssignmentOperator],
                " " + LanguageDirectory.Tokens[LanguageToken.AssignmentOperator] + " ")
            .Replace(LanguageDirectory.Tokens[LanguageToken.EndOfClosure],
                " " + LanguageDirectory.Tokens[LanguageToken.EndOfClosure] + " ")
            .Replace(LanguageDirectory.Tokens[LanguageToken.BeginOfClosure],
                " " + LanguageDirectory.Tokens[LanguageToken.BeginOfClosure] + " ")
            .Replace(LanguageDirectory.Tokens[LanguageToken.EndOfStatement],
                " " + LanguageDirectory.Tokens[LanguageToken.EndOfStatement] + " ")
            .Replace(LanguageDirectory.Tokens[LanguageToken.MultiplicationOperator],
                " " + LanguageDirectory.Tokens[LanguageToken.MultiplicationOperator] + " ")
            .Replace(LanguageDirectory.Tokens[LanguageToken.SubtractionOperator],
                " " + LanguageDirectory.Tokens[LanguageToken.SubtractionOperator] + " ")
            .Replace(LanguageDirectory.Tokens[LanguageToken.OpenParenthesis], " ")
            .Replace(LanguageDirectory.Tokens[LanguageToken.CloseParenthesis], " ");
    }

    public string ProcedureToParse()
    {
        return _astTree.Display();
    }
}