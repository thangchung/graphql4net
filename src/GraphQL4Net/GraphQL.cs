using GraphQL4Net.Language;

namespace GraphQL4Net
{
    public interface IGraphQL
    {
        dynamic Execute(
            Schema schema, 
            string query, 
            dynamic root = null, 
            Inputs inputs = null, 
            string operationName = "");
    }

    public class GraphQL : IGraphQL
    {
        public dynamic Execute(Schema schema, string query, dynamic root = null,
            Inputs inputs = null, string operationName = "")
        {
            var source = new Source(query ?? "", "GraphQL Request");

            return string.Empty;
        }
    }
}