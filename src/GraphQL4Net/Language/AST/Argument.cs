namespace GraphQL4Net.Language.AST
{
    public class Argument : Node
    {
        public string Kind { get; set; } = Argument;
        public string Name { get; set; }
        public string Value { get; set; }
    }
}