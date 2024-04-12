
using System.Text;
using System.Text.RegularExpressions;

var path = @"../../../../../README.md";
var readme =File.ReadAllText(path);
var content = PaintBoards();
var result = Regex.Replace(readme, "### Visualisations.*<!-- end visualisation  -->", 
    "### Visualisations" + content + "\n<!-- end visualisation  -->", 
    RegexOptions.Singleline);
File.WriteAllText(path, result);


string Paint(string title, string keyboard)
{
    var vocals = "eaoi";
    var consonants = "tnsrhl";
    var leastFrequent = "ybvkxjqz,.;'-/";
    var sb = new StringBuilder();
    sb.AppendLine("\n**" + title + "**");
    sb.AppendLine("<table><tr>");
    foreach (char c in keyboard
        .ToLower()
        .Replace("\r", "")
        .SkipWhile(x => x == '\n')
        .Where(x => x != ' ')
        )
    {
        if (c == '\n')
            sb.Append("</tr><tr>");
        else if (vocals.Contains(c))
            sb.Append("<td><img src=\"green.png\"></td>");
        else if (consonants.Contains(c))
            sb.Append("<td><img src=\"blue.png\"></td>");
        else if (leastFrequent.Contains(c))
            sb.Append("<td><img src=\"darkgray.png\"></td>");
        else
            sb.Append("<td><img src=\"gray.png\"></td>");
    }
    sb.AppendLine("</tr></table>");

    return sb.ToString();
}

string PaintBoards()
{
    var sb = new StringBuilder();

    sb.AppendLine(Paint("qwerty",
@"
q w e r t y u i o p
a s d f g h j k l ;
z x c v b n m , ."));

    sb.AppendLine(Paint("dvorak",
@"
' , . p y f g c r l /
a o e u i d h t n s -
; q j k x b m w v z"));

    sb.AppendLine(Paint("Colemak", @"
q w f p g j l u y 
a r s t d h n e i o 
z x c v b k m , . "));

    sb.AppendLine(Paint("hands down", @"
w f m p v / . q "" z 
r s n t b , a e i h j
x c l d g - u o y k"));

    sb.AppendLine(Paint("Engram",
@"
B Y O U ' L D W V Z
C I E A , H T S N Q
G X J K - R M F P"));

    sb.AppendLine(Paint("canary",
        @"
w l y p k z x o u ;
c r s t b f n e i a '
j v d g q m h / , ."));

    return sb.ToString();
}

