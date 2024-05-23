Console.WriteLine("keyboard layouter v1.0!");

var bigrams = new Corpus().GetEnglishBigrams()
    .Where(x => !x.Value.Contains('?'))
    .Where(x => !x.Value.Contains('!'))
    .Where(x => !x.Value.Contains('/'))
    .Where(x => !x.Value.Contains('.'))
    .Where(x => !x.Value.Contains(','))
    .Where(x => !x.Value.Contains('-'))
    .Where(x => x.Frequency > 0.1m)
    .ToArray();


int maxhistory = 2500000;//00;
int half = maxhistory / 2;
int quart = half / 2;

List<keyb> brain = new List<keyb>();


//!!

var keb = new keyb("qwertyuiopasdfghjkl'zxcvbnm-,.;");
//Console.WriteLine(keb.layout);
//Console.WriteLine(keb.TypeText(Corpus.Alice));
//Console.WriteLine("----");
keb = new keyb("qdlypwmoufsinagctherbzxvj,'k;.-");
keb.Print();
Console.WriteLine(keb.layout);
Console.WriteLine(keb.TypeText(Corpus.Alice));
Console.WriteLine("----");
keb = new keyb("qdlfpwmuoysinagctherbzxvj;'k,.-"); 
keb.Print();
Console.WriteLine(keb.layout);
Console.WriteLine(keb.TypeText(Corpus.Alice));
//!

//qdlyp wmouf
//sinag  ctherb
//zxvj,  'k;.-

//    score: 92088
//score: 9223372036854775807
//add("qdlypwmoufsinagctherbzxvj,'k;.-"); // 92088

//add("qwertyuiopasdfghjkl'zxcvbnm-,.;");

add("qdlfpwmuoysinagctherbzxvj;'k,.-");
//add(";qkz.,'x-jshetciandgvyblpurmofw"); // 77040

//add(",fpmkbwylgcsorehtinad-:qu'vz.xj");
//add("qcalmwgfykstehriondp'-b,vxzju.:");
//add("pwofmyulbzstehriandjx-.,kv'gcq:"); // 888,837635905
//add("'vermpdcx.,sthuoinalw-zbyqjgfk:"); // 462,5302052172
//add("pfoujzy.,:thersdinalwmkq-v'gcbx"); // 506,31691320320
//add("foubw'pmgqrehtsdinalcvzkx:.,yj-"); // 1174,8616992385007
//add("qgmp'wbuoflanidstherc,xy-.zkvj"); // 1176,1711586028005
//add("xgmpqybuoflanidstherc.zw',-kvj;"); // 1396,6772793288003
//add("fdcg.jkmpvuonialthersyqw;-,zb'x"); // 987321066
//add(",winp;ouja'dthksrelqzmcgbxy-f.v"); // 4414046921
add("pmervboufqkcthsaind,xz-w'jygl.:"); // 4833538685
//add("wdlfybmuoqsinagctherjzxp;,-.v'k");
//add("'x.thjvgkqdyserlanic:,-mpwzfoub"); // 16666288
//add("bumpwylacvserofhtindgx'zk-qj.:,"); // 18574073
//add(",m;wkjpabghtinduoresy.xqfl'czv-"); // 17055664
//add("ykcubmofwgsinalderthv;'.zqxp-,j"); // 15415197


//vbylp muofw
//sithc  derang
//'-,.x  k;qjz

//score: 1221383
//score: 9223372036854775807
//add("vbylpmuofwsithcderang'-,.xk;qjz"); // 1221383


Console.WriteLine("press any key...");
Console.ReadKey();

ReBrain(brain.Count);

void add(string layout)
{
    var k = new keyb(layout);
    k.PrintScore(bigrams);
    k.Print();
    brain.Add(k);
}

void ReBrain(int cellsToKeep)
{
    brain = brain.Take(cellsToKeep).ToList();

    while (brain.Count < half)
    {
        int m = brain.Count;
        for (int i = 0; i < m; i++)
        {
            brain.Add(brain[i].Mutate(2));
        }
    }
}

long count = 0;
DateTime now = DateTime.Now;
int countNoChange = 0;

while (true)
{
    Console.Write((DateTime.Now - now) + "  ");
    now = DateTime.Now;

    for (int i = 0; i < quart; i++)
    {
        var current = brain[i].Mutate(Random.Shared.Next(1, 2));
        brain.Add(current);
    }
    for (int i = quart; i < half; i++)
    {
        var current = brain[i].Mutate(Random.Shared.Next(2, 4));
        brain.Add(current);
    }

    count += half;

    Console.Write(1);
    var max = brain[0].Score(bigrams);

    brain = brain
        .AsParallel()
        .OrderByDescending(x => x.Score(bigrams))
        .Take(half)
        .ToList();

    Console.Write(2);

    if (max < brain[0].Score(bigrams)||countNoChange==0)
    {
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine("top 3");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("count " + count);
        Console.WriteLine();
        brain.Take(3).ToList().ForEach(c => c.Print());
        countNoChange = 0;
    }

    if (countNoChange++ > 10)
    {
        ReBrain(1);
        countNoChange = 0;
    }
}

