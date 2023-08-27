# TODO

- Create a lexer that can lex simple algebraic expressions first, then the whole suite of tokens in Circe.
    - Refer to example/FirstDraft.md for details on Circe's syntax.

# Getting a Lexer up and running

- It's basically an infinite loop. You go ahead character by character, scan for single letter tokens, then keeps pushing them onto a list.

## Token
    - A type
    - A string literal associated with it (will be needed for identifiers)