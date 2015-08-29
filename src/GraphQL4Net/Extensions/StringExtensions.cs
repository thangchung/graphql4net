using System.Globalization;
using System.Text;

namespace GraphQL4Net.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Reference at http://stackoverflow.com/questions/2936989/c-sharp-utf8-output-keep-encoded-characters-intact
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string EscapeUnicode(this string input)
        {
            var sb = new StringBuilder(input.Length);
            foreach (var ch in input)
            {
                if (ch <= 0x7f)
                    sb.Append(ch);
                else
                    sb.AppendFormat(CultureInfo.InvariantCulture, "\\u{0:x4}", (int)ch);
            }
            return sb.ToString();
        }
    }
}