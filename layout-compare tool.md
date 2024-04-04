# Layout compare tool

incomplete code for comparing layouts

 ```
string join(IEnumerable<object> s) => string.Join("", s.Select(x => x.ToString()));

(string, string)[] kb = [
    ("Qwerty", "ASDFGHJKL;"), 
    ("Dvorak", "AOEUIDHTNS-"), 
    ("Colemak", "ARSTDHNEIO'"), 
    ("Workman", "ASHTGYNEOI'"), 
    ("Hands Down Neu", "RSNTB,AEIHJ"), 
    ("Engram", "CIEA,.HTSNQ"), 
    ("Three Layout", "OHEAIDRTNS "),];
string sorted = $"|Name {join(kb.Select(x=>"|"))}\n{join(kb.Select(x=>"|-"))}|\n{string.Join("\n", kb.Select(x => $"|{x.Item1}|{string.Join("|", x.Item2.OrderBy(c => c))}|"))}";
string raw = $"|Name {join(kb.Select(x => "|"))}\n{join(kb.Select(x => "|-"))}|\n{string.Join("\n", kb.Select(x => $"|{x.Item1}|{string.Join("|", x.Item2.Select(c => c))}|"))}";
Console.WriteLine($"{sorted}\n\n{raw}");
```

