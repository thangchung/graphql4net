using System.Collections.Generic;

namespace GraphQL4Net.Language.AST
{
    public class Directive : Node
    {
        public string Kind { get; set; } = Directive;
        public string Name { get; set; }
        public List<Argument> Arguments { get; set; } = new List<Argument>();
    }
}