namespace GraphQL4Net.Language.AST
{
    public class BooleanValue : Node
    {
        public string Kind { get; set; } = Boolean;
        public string Value { get; set; }
    }
}