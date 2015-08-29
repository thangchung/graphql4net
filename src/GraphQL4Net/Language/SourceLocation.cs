using System;

namespace GraphQL4Net.Language
{
    public class SourceLocation
    {
        private readonly int _line;
        private readonly int _column;

        public SourceLocation(int line = 0, int column = 0)
        {
            _line = line;
            _column = column;
        }

        public Array ToArray()
        {
            return new int[_line, _column];
        }
    }
}