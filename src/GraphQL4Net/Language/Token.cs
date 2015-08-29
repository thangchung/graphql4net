
using System.Collections.Generic;

namespace GraphQL4Net.Language
{
    public enum TokenEnum
    {
        EOF = 1,
        BANG = 2,
        DOLLAR = 3,
        PAREN_L = 4,
        PAREN_R = 5,
        SPREAD = 6,
        COLON = 7,
        EQUALS = 8,
        AT = 9,
        BRACKET_L = 10,
        BRACKET_R = 11,
        BRACE_L = 12,
        PIPE = 13,
        BRACE_R = 14,
        NAME = 15,
        VARIABLE = 16,
        INT = 17,
        FLOAT = 18,
        STRING = 19
    }

    public class Token
    {
        private readonly TokenEnum _kind;
        private readonly int _start;
        private readonly int _end;
        private readonly string _value;

        public Token(TokenEnum kind, int start, int end, string value = "")
        {
            _kind = kind;
            _start = start;
            _end = end;
            _value = value;
        }

        public TokenEnum GetKind()
        {
            return _kind;
        }

        public int GetStart()
        {
            return _start;
        }

        public int GetEnd()
        {
            return _end;
        }

        public string GetValue()
        {
            return _value;
        }

        public static string GetKindDescription(TokenEnum kind)
        {
            var tokenDictionary = new Dictionary<TokenEnum, string>();
            var output = "";

            tokenDictionary.Add(TokenEnum.EOF, "EOF");
            tokenDictionary.Add(TokenEnum.BANG, "!");
            tokenDictionary.Add(TokenEnum.DOLLAR, "$");
            tokenDictionary.Add(TokenEnum.PAREN_L, "(");
            tokenDictionary.Add(TokenEnum.PAREN_R, ")");
            tokenDictionary.Add(TokenEnum.SPREAD, "...");
            tokenDictionary.Add(TokenEnum.COLON, ":");
            tokenDictionary.Add(TokenEnum.EQUALS, "=");
            tokenDictionary.Add(TokenEnum.AT, "@");
            tokenDictionary.Add(TokenEnum.BRACKET_L, "[");
            tokenDictionary.Add(TokenEnum.BRACKET_R, "]");
            tokenDictionary.Add(TokenEnum.BRACE_L, "{");
            tokenDictionary.Add(TokenEnum.PIPE, "|");
            tokenDictionary.Add(TokenEnum.BRACE_R, "}");
            tokenDictionary.Add(TokenEnum.NAME, "Name");
            tokenDictionary.Add(TokenEnum.VARIABLE, "Variable");
            tokenDictionary.Add(TokenEnum.INT, "Int");
            tokenDictionary.Add(TokenEnum.FLOAT, "Float");
            tokenDictionary.Add(TokenEnum.STRING, "String");

            return tokenDictionary.TryGetValue(kind, out output) ? output : null;
        }

        public override string ToString()
        {
            return $"{GetKindDescription(_kind)} {_value}";
        }
    }
}