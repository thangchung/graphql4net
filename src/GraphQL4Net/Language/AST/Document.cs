using System.Collections.Generic;

namespace GraphQL4Net.Language.AST
{
    public class Document : Node
    {
        public string Kind { get; set; } = Document;
        public List<IDefinition> Definitions { get; set; } = new List<IDefinition>();
    }
}