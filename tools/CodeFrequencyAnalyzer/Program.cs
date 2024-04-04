using System.Text.RegularExpressions;
using System.Text;
using System.Text.Json;

var settings = new CodeFrequencyAnalyzer.Settings();
var ignoreSomeSettings = settings with
{
    IgnoreUsingAndNamespace = true,
    IgnoreSpaceAtStartAndEndOfLine = true,
};
var ignoreAllSettings = settings with
{
    IgnoreUsingAndNamespace = true,
    IgnoreSpaceAtStartAndEndOfLine = true,
    IgnoreNewlineAndSpace = true,
};
var analyzer = new CodeFrequencyAnalyzer();
//var path = @"C:\src\";
var path = @"C:\src\KeyboardLayoutGalore\CodeFrequencyAnalyzer\CodeFrequencyAnalyzer\";

var allcode = analyzer.AnalyzeFiles(path, "*.cs", settings);
var ignoredSomeCode = analyzer.AnalyzeFiles(path, "*.cs", ignoreSomeSettings);
var ignoredAllCode = analyzer.AnalyzeFiles(path, "*.cs", ignoreAllSettings);

var keypresses = JsonSerializer.Deserialize<J>(File.ReadAllText("KeyloggerForCode.json"))
    .accumulated.Records
    .Select(x => new CodeFrequencyAnalyzer.Usage(x.Key, x.Value, 0))
    .ToDictionary(x => x.key, x => x);
analyzer.CalculateFreq(keypresses);
Console.WriteLine(analyzer.MarkDown([allcode, ignoredSomeCode, ignoredAllCode, keypresses]));

public class J
{
    public Acc accumulated { get; set; }
    public class Acc
    {
        public Dictionary<string, int> Records { get; set; }
    }
}

class CodeFrequencyAnalyzer
{
    public record Usage(string key, int count, decimal frequency);
    enum Mode { normal, multilinecomment }

    public record Settings(bool IgnoreComments = false,
        bool IgnoreUsingAndNamespace = false,
        bool IgnoreNewlineAndSpace = false,
        bool IgnoreSpaceAtStartAndEndOfLine = false);

    public string MarkDown(Dictionary<string, Usage>[] usages)
    {
        var sb = new StringBuilder();
        // header
        for (int i = 0; i < usages.Length; i++)
            sb.Append("||Freq");
        sb.AppendLine("|");
        for (int i = 0; i < usages.Length; i++)
            sb.Append("|-|-");
        sb.AppendLine("|");

        var maxRow = usages.Max(x => x.Count());
        for (int row = 0; row < maxRow; row++)
        {
            for (int i = 0; i < usages.Length; i++)
            {
                if (usages[i].Count() > row)
                {
                    var stat = usages[i].OrderByDescending(x => x.Value.count).ToArray()[row];
                    var key = stat.Key.Replace("\\", "\\\\").Replace("|", "\\|").Replace("\n", "\\n");
                    sb.Append($"|{key,22}|{stat.Value.frequency,6}%");
                }
                else
                    sb.Append($"|                  |        ");

            }
            sb.AppendLine("|");
        }
        return sb.ToString();
    }

    public Dictionary<string, Usage> AnalyzeFiles(string path, string pattern, Settings settings)
    {
        var result = new Dictionary<string, Usage>();
        IEnumerable<string> files = Directory
                    .EnumerateFiles(path, pattern, SearchOption.AllDirectories)
                    .Where(x => !x.ToLower().Contains("\\obj\\debug"))
                    .Where(x => !x.ToLower().Contains("\\obj\\release"))
                    .Where(x => !x.EndsWith("\\AssemblyInfo.cs"))
                    .Where(x => !x.ToLower().Contains(".designer.cs"))
                    .Where(x => !x.ToLower().Contains(".xaml.cs"));
        foreach (var file in files)
        {
            //Console.WriteLine("*"+file);
            Analyze(result, File.ReadAllLines(file), settings);
        }

        CalculateFreq(result);

        return result;
    }

    public void CalculateFreq(Dictionary<string, Usage> result)
    {
        var sum = result.Select(x => x.Value.count).Sum();
        foreach (var r in result)
            result[r.Key] = result[r.Key] with { frequency = Math.Round(r.Value.count * 100M / sum, 2) };
    }

    public void Analyze(Dictionary<string, Usage> usage, string[] content, Settings settings)
    {
        Mode mode = Mode.normal;
        foreach (var l in content)
        {
            var line = l.ToLower();

            if (settings.IgnoreSpaceAtStartAndEndOfLine)
                line = line.Trim();

            if (settings.IgnoreUsingAndNamespace && Regex.IsMatch(line, "(namespace|using)\\s+(\\w|\\.)+\\s*;?"))
                continue;

            for (int i = 0; i < line.Length; i++)
            {
                if (settings.IgnoreComments)
                {
                    if (mode == Mode.normal && line[i] == '/' && line[i + 1] == '*')
                        mode = Mode.multilinecomment;

                    if (mode == Mode.multilinecomment)
                    {
                        if (line[i] == '*' && line[i + 1] == '/')
                            mode = Mode.normal;
                        else 
                            continue;
                    }

                    if (line[i] == '/' && line[i + 1] == '/')
                        break;
                }

                if (line[i] == ' ' && settings.IgnoreNewlineAndSpace)
                    continue;

                Add(usage, line[i].ToString());
            }

            if (!settings.IgnoreNewlineAndSpace)
                Add(usage, "\n");
        }

        void Add(Dictionary<string, Usage> usage, string use)
        {
            if (!usage.ContainsKey(use))
                usage[use] = new Usage(use, 0, 0);
            usage[use] = usage[use] with { count = usage[use].count + 1 };
        }
    }
}