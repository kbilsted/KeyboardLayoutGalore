using System.Text;

public class Writers
{
    public static void HoumainKeymapper(string path, K[] ks)
    {
        (string search, string replace)[] defs = [
            ( "'", "\"'\""),
             ( "-", "Minus"),
             ( "+", "'+'"),
             ( ".", "Period"),
             ( ",", "Comma"),
             ( ";", "Semicolon"),
             ( ":", "':'"),
             ( "/", "Slash"),
             ( "\"", "'\"'"),
             ( "#", "'#'"),
             ( "*", "'*'"),
             ( "@", "'@'"),
             ( "␣", "' '")];

        string map(string s) => defs.FirstOrDefault(x => x.search == s).replace ?? s;


        string paren(string[] s) => "(" + string.Join(" ", s) + ")";
        var sb = new StringBuilder();
        sb.AppendLine(@"# Mapping by Kasper B. Graversen - Feel free to use and modify
# To get started install Keymapper from https://github.com/houmain/keymapper it works on Windows/Mac/Linux
# Then start it with this config as argument
");

        foreach (K k in ks)
        {
            switch (k.Kind)
            {
                case KKind.Newline:
                    sb.AppendLine();
                    break;

                case KKind.Single:
                    if (k.modifier == null)
                        sb.AppendLine($"{k.inKeys[0]} >> {map(k.outKeys[0])}");
                    else
                        sb.AppendLine($"{k.modifier}{{{k.inKeys[0]}}} >> {map(k.outKeys[0])}");
                    break;

                case KKind.Group:
                    sb.AppendLine($"{paren(k.inKeys)} >> {map(k.outKeys[0])}");
                    break;
            }
        }

        var result = sb.ToString();
        File.WriteAllText(path, result);
    }
}


