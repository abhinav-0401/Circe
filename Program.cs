using Circe.Lexing;

namespace Circe;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("harry, yer a greek witch now!");
        const string testSource = "+-*/==";
        Lexer lexer = new Lexer(testSource);
        lexer.Lex();
    }
}
