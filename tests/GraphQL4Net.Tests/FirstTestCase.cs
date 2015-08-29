using GraphQL4Net;
using Xunit;

namespace GraphQL4Net.Tests
{
    public class GraphQLTestCase
    {
        private readonly IGraphQL _graphQL;

        public GraphQLTestCase()
        {
            _graphQL= new GraphQL();
        }

        [Fact]
        public void Can_Execute_Query()
        {
            var schema = new Schema();
            var query = @"";

            var result = _graphQL.Execute(schema, query);

            Assert.Empty(result);
        }
    }
}