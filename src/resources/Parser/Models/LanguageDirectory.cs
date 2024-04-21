using Parser.Enums;

namespace Parser.Models;

public static class LanguageDirectory
{
    public static Dictionary<LanguageToken, string> Tokens = new Dictionary<LanguageToken, string>
    {
        { LanguageToken.WhileStatement, "while" },
        { LanguageToken.IfStatement, "if" },
        { LanguageToken.ThenStatement, "then" },
        { LanguageToken.ElseStatement, "else" },
        { LanguageToken.CallStatement, "call" },
        { LanguageToken.BeginOfClosure, "{" },
        { LanguageToken.EndOfClosure, "}" },
        { LanguageToken.EndOfStatement, ";" },
        { LanguageToken.AssignmentOperator, "=" },
        { LanguageToken.AdditionOperator, "+" },
        { LanguageToken.SubtractionOperator, "-" },
        { LanguageToken.MultiplicationOperator, "*" },
        { LanguageToken.ProcedureKeyword, "procedure" },
        { LanguageToken.OpenParenthesis, "(" },
        { LanguageToken.CloseParenthesis, ")" }
    };
}