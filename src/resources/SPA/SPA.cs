namespace SPA;

public static class SPA
{
    public static Parser.Interfaces.IParser Parser = new Parser.Models.Parser();
    public static QueryProcessor.Interfaces.IQueryProcessor QueryProcessor = new QueryProcessor.Models.QueryProcessor();
}