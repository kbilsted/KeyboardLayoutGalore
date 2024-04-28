using System.Text;

public class Writers
{

    public static void TypeFuMapper(string path, K[] ks)
    {
        var header = @"{
  ""id"": ""custom-421c67e2-87d1-41e4-96e7-c79dcfa2ccad"",
  ""name"": ""rollercoaster - typefu"",
  ""version"": 1,
  ""keys"": {";
        var digits = @"
  ""Minus"": {
      ""default"": {
        ""base"": ""1""
      }
    },
    ""Equal"": {
      ""default"": {
        ""base"": ""0""
      }
    },
    ""IntlBackslash"": {
      ""default"": {
        ""base"": ""<"",
        ""shift"": "">""
      }
    },
    ""Space"": {
      ""default"": {
        ""base"": "" ""
      }
    },
    ""Backquote"": {
      ""default"": {}
    },
    ""Digit1"": {
      ""default"": {
        ""base"": ""1"",
        ""shift"": ""!""
      }
    },
    ""Digit2"": {
      ""default"": {
        ""base"": ""2""
      }
    },
    ""Digit3"": {
      ""default"": {
        ""base"": ""3""
      }
    },
    ""Digit4"": {
      ""default"": {
        ""base"": ""4""
      }
    },
    ""Digit5"": {
      ""default"": {
        ""base"": ""5""
      }
    },
    ""Digit6"": {
      ""default"": {
        ""base"": ""6""
      }
    },
    ""Digit7"": {
      ""default"": {
        ""base"": ""7""
      }
    },
    ""Digit8"": {
      ""default"": {
        ""base"": ""8""
      }
    },
    ""Digit9"": {
      ""default"": {
        ""base"": ""9""
      }
    },
    ""Digit0"": {
      ""default"": {
        ""base"": ""0""
      }
    },
";

        var sb = new StringBuilder();
        sb.AppendLine(header);
        sb.AppendLine(digits);

        static string key(string keyboardName, string newValue) => key2(keyboardName, newValue, newValue.ToUpper());
        static string key2(string keyboardName, string newValue, string UppercaseNewValue) {
            var keyname = keyboardName.Length == 1 ? $"Key{keyboardName}" : keyboardName;
            return @$"  ""{keyname}"": {{
      ""default"": {{
        ""base"": ""{newValue}"",
        ""shift"": ""{UppercaseNewValue}""
      }}
    }}";

        }

        foreach (K k in ks)
        {
            switch (k.Kind)
            {

                case KKind.Single:
                    if (k.modifier == null)
                        sb.AppendLine(key(k.inKeys[0], k.outKeys[0].ToLower()));
                    else
                        sb.AppendLine($"{k.modifier}{{{k.inKeys[0]}}} >> {(k.outKeys[0])}");
                    break;

                case KKind.Newline:
                    break;

                case KKind.Group:
                    break;
            }
            sb.Append(",");
        }
        sb.Remove(sb.Length - 1,1);

        var footer = @"  
  },
  ""description"": ""improved""
}";

        sb.AppendLine(footer);
        var result = sb.ToString();
        File.WriteAllText(path, result);

    }
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


