using GraphQL4Net.Language;

namespace GraphQL4Net
{
    public interface IGraphQL
    {
        object Execute(
            Schema schema, 
            string query, 
            object root = null, 
            Inputs inputs = null, 
            string operationName = "");
    }

    public class GraphQL : IGraphQL
    {
        public object Execute(Schema schema, string query, object root = null,
            Inputs inputs = null, string operationName = "")
        {
            var source = new Source(query ?? "", "GraphQL Request");

            return string.Empty;
        }
    }
}