using System.Text.RegularExpressions;
/*
 * ^ - Starts with
 * $ - Ends with
 * [] - Range
 * () - Group
 * . - Single character once
 * + - one or more characters in a row
 * ? - optional preceding character match
 * \ - escape character
 * \n - New line
 * \d - Digit
 * \D - Non-digit
 * \s - White space
 * \S - non-white space
 * \w - alphanumeric/underscore character (word chars)
 * \W - non-word characters
 * {x,y} - Repeat low (x) to high (y) (no "y" means at least x, no ",y" means that many)
 * (x|y) - Alternative - x or y
 * 
 * [^x] - Anything but x (where x is whatever character you want)
 */
namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Regex.IsMatch("Shoaib", "ai"));

            //regex for Indian phone number
            string phoneNumberPattern = @"(\+91)?\s?\d{10}\s?(\.)?";
            string textToSearchPhnNumFrom = "my phone number is +91 9123473210.";
            Console.WriteLine(Regex.Match(textToSearchPhnNumFrom, phoneNumberPattern));

            //regex for email
            string emailIdPattern = @"[a-z]{3,}\@(gmail|yahoo)\.(com|in)";
            string textToSearchEmailFrom = "my email id is shoaib@gmail.com. and my friend's email is lokesh@yahoo.com and his friend's email is santosh@yahoo.in";
            foreach(var match in Regex.Matches(textToSearchEmailFrom, emailIdPattern))
            {
                Console.WriteLine(match);
            }

            //alphanumeric
            string alphaNumericPatternFilter = @"[A-Z]{0,}[a-z]{0,}[0-9]{0,}\s{0,}";
            string textToCheckAlphaNumericPatternFilter = @"sdfbgd fvl hgkjbe465sdc63d6!@#$%*s5s6df1fd3s5 6d5 d65xcv6asd3fvfd";
            Console.WriteLine("**************");
            Console.WriteLine(textToCheckAlphaNumericPatternFilter);
            foreach (var match in Regex.Matches(textToCheckAlphaNumericPatternFilter, alphaNumericPatternFilter))
            {
                Console.Write(match);
            }
        }
    }
}
