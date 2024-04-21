using AST.Models;

namespace Parser.Interfaces
{
    public interface IParser
    {
        public void Parse(string input);
        public string ProcedureToParse();
    }
}