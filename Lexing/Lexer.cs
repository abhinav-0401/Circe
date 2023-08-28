namespace Circe.Lexing;

class Lexer
{
    private readonly string _source;
    private readonly int _length;
    private int _index; // basically tracks the current position of the lexer in the source code

    public Lexer(string source)
    {
        _source = source;
        _length = _source.Length;
        _index = 0;
    }

    public List<Token> Lex()
    {
        Console.WriteLine("the lexer is now up and running...");
        List<Token> tokens = new();
        while (_index < _length)
        {
            tokens.Add(Tokenise());
        }
        return tokens;
    }

    private Token Tokenise()
    {
        char currentChar = _source[_index];
        Token newToken = currentChar switch
        {
            '+' => new Token(TokenType.Add, currentChar.ToString()),
            '-' => new Token(TokenType.Subtract, currentChar.ToString()),
            '*' => new Token(TokenType.Star, currentChar.ToString()),
            '/' => new Token(TokenType.Divide, currentChar.ToString()),
            ':' => new Token(TokenType.Colon, currentChar.ToString()),
            ';' => new Token(TokenType.Semicolon, currentChar.ToString()),
            '=' => new Token(TokenType.Equal, currentChar.ToString()),
            _ => new Token(TokenType.Illegal, currentChar.ToString()),
        };
        _index++;

        return newToken;
    }
}