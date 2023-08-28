using Circe.Lexing;

namespace Circe;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("harry, yer a greek witch now!");
        const string testSource = "+-*/==";
        Lexer lexer = new Lexer(testSource);
        var tokens = lexer.Lex();

        int i = 0;
        foreach (var token in tokens)
        {
            Console.WriteLine("token index {0} is {1} of type {2}", i, token.Literal, token.Type);
            ++i;
        }
    }
}
