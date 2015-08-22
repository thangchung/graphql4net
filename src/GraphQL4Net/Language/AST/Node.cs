namespace GraphQL4Net.Language.AST
{
    public abstract class Node
    {
        protected const string GraphQLName = "Name";

        // Document
        protected const string Document = "Document";
        protected const string OperationDefinition = "OperationDefinition";
        protected const string VariableDefinition = "VariableDefinition";
        protected const string Variable = "Variable";
        protected const string SelectionSet = "SelectionSet";
        protected const string Field = "Field";
        protected const string Argument = "Argument";

        // Fragments
        protected const string FragmentSpread = "FragmentSpread";
        protected const string InlineFragment = "InlineFragment";
        protected const string FragmentDefinition = "FragmentDefinition";

        // Values
        protected const string Int = "IntValue";
        protected const string Float = "FloatValue";
        protected const string String = "StringValue";
        protected const string Boolean = "BooleanValue";
        protected const string Enum = "EnumValue";
        protected const string Lst = "ListValue";
        protected const string Object = "ObjectValue";
        protected const string ObjectField = "ObjectField";

        // Directives
        protected const string Directive = "Directive";

        // Types
        protected const string NamedType = "NamedType";
        protected const string ListType = "ListType";
        protected const string NonNullType = "NonNullType";

        protected dynamic GraphQLKind;

        protected int GraphQLLoc;
    }
}