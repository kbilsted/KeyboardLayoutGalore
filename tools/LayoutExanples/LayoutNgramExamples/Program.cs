using System.Net.Http.Headers;

string keyboard = 
@"
qpldb  jfuoy
ainsc  kther
.,wgz  -mv/x";


Ngram[] bigrams =[
            new ("er", 1.833M, 3.56M),
            new ("th", 3.079M, 3.21M),
            new ("in", 2.347M, 2.64M),
            new ("he", 2.509M, 2.53M), 
            new ("an", 1.885M, 2.18M),
            new ("it", 1.087M, 2.14M),
            new ("es", 1.193M, 2.02M),
            new ("or", 1.260M, 1.95M),
            new ("en", 1.213M, 1.90M),
            new ("on", 1.497M, 1.87M),
            new ("at", 1.305M, 1.79M),
            new ("ed", 0.952M, 1.62M),
            new ("ar", 1.026M, 1.59M),
            new ("to", 1.156M, 1.56M),
            new ("te", 1.065M, 1.51M),
            new ("is", 0.953M, 1.46M),
            new ("al", 0.959M, 1.42M),
            new ("st", 1.042M, 1.39M),
            new ("le", 0.830M, 1.33M),
            new ("nd", 1.257M, 1.28M),
            new ("of", 0.759M, 1.27M),
            new ("ng", 1.102M, 1.16M),
            new ("ou", 1.154M, 1.16M),
            new ("ve", 0.856M, 1.11M),
            new ("li", 0.591M, 1.08M),
            new ("me", 0.751M, 1.06M),
            new ("sa", 0.218M, 1.00M),
];



Ngram[] trigrams =[
            new ("the", 2.699M, 2.70M),
            new ("ing", 1.283M, 1.30M),
            new ("and", 1.224M, 1.23M),
            new ("ion", 0.683M, 0.69M),
            new ("ent", 0.607M, 0.62M),
            new ("for", 0.583M, 0.60M),
            new ("you", 0.565M, 0.57M),
            new ("tio", 0.548M, 0.55M),
            new ("hat", 0.489M, 0.49M),
            new ("ter", 0.425M, 0.48M),
            new ("tha", 0.472M, 0.47M),
            new ("are", 0.350M, 0.47M),
            new ("her", 0.460M, 0.47M),
            new ("ati", 0.394M, 0.44M),
            new ("all", 0.403M, 0.43M),
            new ("ver", 0.371M, 0.41M),
            new ("ate", 0.369M, 0.40M),
            new ("res", 0.278M, 0.39M),
            new ("thi", 0.372M, 0.37M),
            new ("our", 0.367M, 0.37M),
            new ("art", 0.180M, 0.35M),
            new ("ith", 0.345M, 0.35M),
            new ("ere", 0.349M, 0.35M),
            new ("ers", 0.335M, 0.34M),
            new ("wit", 0.335M, 0.34M),
];


foreach(var gram in bigrams)
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine();
    string result = keyboard;
    foreach(char c in keyboard.Trim())
    {
        if(c is not '\n' and not '\r' and not ' ')
            if(!gram.gram.Contains(c))
                result = result.Replace(c,'-');
    }

    System.Console.WriteLine(result);
}

foreach(var gram in trigrams)
{
    System.Console.WriteLine();
    System.Console.WriteLine();
    System.Console.WriteLine();
    string result = keyboard;
    foreach(char c in keyboard.Trim())
    {
        if(c is not '\n' and not '\r' and not ' ')
            if(!gram.gram.Contains(c))
                result = result.Replace(c,'-');
    }

    System.Console.WriteLine(result);
}


record Example(string x){
    public string[] Lines(){
        return x.Trim().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);
    }
}


record Ngram(string gram, decimal local, decimal global);
