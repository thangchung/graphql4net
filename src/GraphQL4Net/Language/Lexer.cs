using System;

namespace GraphQL4Net.Language
{
    public class Lexer
    {
        private int _prevPosition;

        private Source _source;

        public Lexer(Source source)
        {
            _prevPosition = 0;
            _source = source;
        }

        public Token NextToken(int resetPosition = 0)
        {
            throw new NotImplementedException();
        }

        private Token ReadToken(int fromPosition = 0)
        {
            throw new NotImplementedException();
        }

        private Token ReadName(int position)
        {
            throw new NotImplementedException();
        }

        private Token ReadNumber(int start, int firstCode)
        {
            throw new NotImplementedException();
        }

        private Token ReadString(int start)
        {
            throw new NotImplementedException();
        }

        private int PositionAfterWhitespace(string body, int startPosition)
        {
            throw new NotImplementedException();
        }
    }
}