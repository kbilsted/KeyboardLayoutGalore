using System.Text;

public class Writers
{
    public static void HoumainKeymapper(string? doc, string path, K[] ks)
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
             ( "␣", "' '"),
             ( "`", "'`'")];

        string map(string s) => defs.FirstOrDefault(x => x.search == s).replace ?? s;


        string paren(string[] s) => $"({string.Join(" ", s)})";
        string tostr(string[] s) => string.Join(" ", s);

        var sb = new StringBuilder();
        sb.AppendLine(@"# Mapping by Kasper B. Graversen - Feel free to use and modify
# To get started install Keymapper from https://github.com/houmain/keymapper it works on Windows/Mac/Linux
# Then start it with this config as argument
");
        if (doc != null)
        {
            sb.AppendLine(string.Join("\n#", doc.Split('\n')));
            sb.AppendLine();
        }

        foreach (K k in ks)
        {
            switch (k.Kind)
            {
                case KKind.Newline:
                    sb.AppendLine();
                    break;

                case KKind.Single:
                    if (k.modifier == null)
                    {
                        bool noMapping =
                         (k.inKeys[0] is "Enter" && k.outKeys[0] is @"\n")
                            || (k.inKeys[0] is "Space" && k.outKeys[0] is "␣");

                        if (!noMapping)
                            sb.AppendLine($"{k.inKeys[0]} >> {map(k.outKeys[0])}");
                    }
                    else
                    {
                        sb.AppendLine($"{k.modifier}{{{k.inKeys[0]}}} >> {map(k.outKeys[0])}");
                    }
                    break;

                case KKind.Group:
                    sb.AppendLine($"{paren(k.inKeys)} >> {map(k.outKeys[0])}");
                    break;

                case KKind.Sequence:
                    sb.AppendLine($"{tostr(k.inKeys)} >> {map(k.outKeys[0])}");
                    break;
            }
        }

        var result = sb.ToString();
        File.WriteAllText(path, result);
    }
}


