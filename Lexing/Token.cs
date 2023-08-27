namespace Circe.Lexing;

class Token
{
    public TokenType Type { get; }
    public string Literal { get; }

    public Token(TokenType type, string literal)
    {
        Type = type;
        Literal = literal;
    }
}