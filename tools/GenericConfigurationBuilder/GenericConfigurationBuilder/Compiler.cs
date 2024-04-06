using System.Buffers;
using System.Data;


public enum KKind { Single, Group, Sequence, Newline }
public record K(string[] inKeys, string[] outKeys, string? modifier = null, KKind Kind = KKind.Single);
public enum TokenKind { Newline, Token }
public record Token(string? key, string? shiftKey, TokenKind kind)
{
    public bool IsMeta => kind == TokenKind.Newline;
}

public class Compiler
{
    public static readonly string[] QWERTY_5_grid_2_thumb =
       @"Q W E R T       Y U I     O       P         
          A S D F G      H J K     L       Semicolon 
          Z X C V B      N M Comma Period  Slash 
          Space          Enter"
       .Split([" ", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);

    public static readonly string[] QWERTY_5by6_grid_2_thumb =
        @"Q W E R T      Y U I      O       P         BracketLeft
          A S D F G      H J K      L       Semicolon Semicolon 
          Z X C V B      N M Comma  Period  Slash
          Space          Enter"
        .Split([" ", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);

    public static readonly string[] QWERTY_105_6by5_grid_2_thumb =
        @"Q W E R T Y    U I  O  P         BracketLeft
          A S D F G H    J K  L  Semicolon Semicolon 
IntlBackslash Z X C V    B N  M  Comma     Period  Slash  
          Space          Enter"
      .Split([" ", "\r", "\n"], StringSplitOptions.RemoveEmptyEntries);

    public static void CompileToFile(string doc, string keyboard, string[] targetBoard, K[] combos, Action<string, K[]> Writer)
    {
        var k = KeyboardParser(keyboard, targetBoard);
        Writer(doc, combos.Concat(k).ToArray());
    }

    public static K[] KeyboardParser(string keyboard, string[] targetBoard)
    {
        IEnumerable<Token> Parser(string keyboardLayout)
        {
            keyboardLayout = keyboardLayout + " "; // ensure no need for EOF check when substring
            for (int i = 0; i < keyboardLayout.Length; i++)
            {
                char c = keyboardLayout[i];
                if (c is ' ' or '\r' or '\t')
                    continue;

                if (c is '\n')
                {
                    yield return new Token(null, null, TokenKind.Newline);
                    continue;
                }

                if (c is '\\')
                {
                    int j = i + 1;
                    while (j < keyboardLayout.Length && char.IsLetter(keyboardLayout[j]))
                        j++;
                    yield return new Token(keyboard.Substring(i, j - i), null, TokenKind.Token);
                    i = j;
                    continue;
                }

                if (char.IsLetter(c))
                {
                    int j = i + 1;
                    while (j < keyboardLayout.Length && char.IsLetter(keyboardLayout[j]))
                        j++;
                    yield return new Token(keyboard.Substring(i, j - i).ToUpper(), null, TokenKind.Token);
                    i = j;
                    continue;
                }

                var symbol = c.ToString();
                i++;
                if (i < keyboardLayout.Length)
                {
                    c = keyboardLayout[i];
                    if (c is ' ' or '\r' or '\t' or '\n')
                        yield return new Token(symbol, null, TokenKind.Token);
                    else
                        yield return new Token(symbol, c.ToString(), TokenKind.Token);
                    continue;

                }
            }
        }

        var tokens = Parser(keyboard);

        var keyTokens = tokens.Where(x => !x.IsMeta).ToArray();
        if (targetBoard.Length != keyTokens.Length)
            throw new Exception($"Target board has {targetBoard.Length} characters, mapping has {keyTokens.Length}");

        int i = 0;
        List<K> keys = new List<K>();
        foreach (var token in tokens)
        {
            if (token.kind == TokenKind.Newline)
            {
                keys.Add(new K(null, null, null, KKind.Newline));
                continue;
            }
            if (token.key != null)
            {
                keys.Add(new K([targetBoard[i]], [token.key], null, KKind.Single));
            }
            if (token.shiftKey != null)
            {
                keys.Add(new K([targetBoard[i]], [token.shiftKey], "Shift", KKind.Single));
            }
            i++;
        }

        return keys.ToArray();

    }
}

