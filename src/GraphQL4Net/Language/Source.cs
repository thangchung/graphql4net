using System.Text.RegularExpressions;
using GraphQL4Net.Extensions;

namespace GraphQL4Net.Language
{
    public class Source
    {
        private readonly string _body;
        private int _length;
        private string _name;

        public Source(string body, string name)
        {
            _body = body;
            _length = body.Length;
            _name = name ?? "GraphQL";
        }

        public SourceLocation GetLocation(int position)
        {
            var line = 1;
            var column = position + 1;

            var utfChars = @"\u2028\u2029".EscapeUnicode();
            var lineRegexp = @"/\r\n|[\n\r" + utfChars + "]/su";
            var tempBody = _body.Substring(0, position);
            var matches = Regex.Matches(tempBody, lineRegexp, RegexOptions.IgnoreCase);
            foreach (Match match in matches)
            {
                line += 1;
                column = (position + 1) - (match.Groups[2].Length + match.Groups[1].Length);
            }

            return new SourceLocation(line, column);
        }
    }
}