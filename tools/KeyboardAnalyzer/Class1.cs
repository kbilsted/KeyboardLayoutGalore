using System.Globalization;
using System.Runtime.InteropServices;

namespace KeyboardAnalyzer;


public class Program
{
    public static void Main(string[] args)

    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Keyboards();

        //Trigrams();
        //Bigrams();
        //Monograms();
    }

    static void Bigrams()
    {
        string reverse(string s) => string.Join("", s.Reverse().ToArray());

        string corpus = File.ReadAllText(@"C:\Users\kbils\Desktop\iweb-corpus-samples-cleaned.txt"
        //File.ReadAllText(@"C:\Users\kbils\Desktop\filtered_full"
        )
                      .ToLower()
          .Replace("the", "t@")
          ;
        var dictionary = new Corpus().GetNgrams(corpus, 2);

        var mirrorFreq = new Dictionary<string, decimal>();
        foreach (var item in dictionary)
        {
            var mirrors = reverse(item.Key);
            if (mirrorFreq.ContainsKey(item.Key))
            {
                mirrorFreq[item.Key] = mirrorFreq[item.Key] + item.Value.Freq;
                mirrorFreq[mirrors] = mirrorFreq[mirrors] + item.Value.Freq;
            }
            else
            {
                mirrorFreq[item.Key] = item.Value.Freq;
                mirrorFreq[mirrors] = item.Value.Freq;
            }
        }

        var summedBigrams = dictionary.Select(x => new NGram(x.Key, x.Value.Freq, mirrorFreq[x.Key]))
            .OrderByDescending(x => x.FrequencyWithMirror)
            .Take(800)
            .Select(x => $"new (\"{x.Value}\", {x.Frequency.ToString("0.000")}M, {x.FrequencyWithMirror.ToString("0.00")}M),");

        Console.WriteLine("bigrams " + dictionary.Count());
        Console.WriteLine(string.Join("\n", summedBigrams));

    }

    static void Trigrams()
    {
        string reverse(string s) => string.Join("", s.Reverse().ToArray());

        string corpus = File.ReadAllText(@"C:\Users\kbils\Desktop\iweb-corpus-samples-cleaned.txt"
        //File.ReadAllText(@"C:\Users\kbils\Desktop\filtered_full"
        )
                      .ToLower()
          //.Replace("the", "t")
          ;
        var dictionary = new Corpus().GetNgrams(corpus, 3);

        var mirrorFreq = new Dictionary<string, decimal>();
        foreach (var item in dictionary)
        {
            var mirrors = reverse(item.Key);
            if (mirrorFreq.ContainsKey(item.Key))
            {
                mirrorFreq[item.Key] = mirrorFreq[item.Key] + item.Value.Freq;
                mirrorFreq[mirrors] = mirrorFreq[mirrors] + item.Value.Freq;
            }
            else
            {
                mirrorFreq[item.Key] = item.Value.Freq;
                mirrorFreq[mirrors] = item.Value.Freq;
            }
        }

        var summedBigrams = dictionary.Select(x => new NGram(x.Key, x.Value.Freq, mirrorFreq[x.Key]))
            .OrderByDescending(x => x.FrequencyWithMirror)
            .Take(600)
            .Select(x => $"new (\"{x.Value}\", {x.Frequency.ToString("0.000")}M, {x.FrequencyWithMirror.ToString("0.00")}M),");

        Console.WriteLine("grams " + dictionary.Count());
        Console.WriteLine(string.Join("\n", summedBigrams));

    }



    static void Monograms()
    {
        string corpus = File.ReadAllText(@"C:\Users\kbils\Desktop\iweb-corpus-samples-cleaned.txt"
      //File.ReadAllText(@"C:\Users\kbils\Desktop\filtered_full"
      )
          .ToLower()
          //.Replace("the", "t")
          ;
        var dictionary = new Corpus().GetMonoGrams(corpus);

        var output = dictionary
                .OrderByDescending(x => x.Value.Freq)
                .Take(400)
                .Select(x => $"{x.Key}: {x.Value.Freq.ToString("0.000")}");

        Console.WriteLine(string.Join("\n", output));

    }

    const decimal SameRow1kipNeighbourWeight = 1.2m;
    const decimal DirectNeighbourWeight = 1.5m;
    const decimal NextRowNeighbourWeight = 0.5m;

    public static void Keyboards()
    {

        Stats res;
        NGram[] bigrams = new Corpus().GetEnglishBigrams()
            .Where(x=>!x.Value.Contains("!"))
            .Where(x=>!x.Value.Contains("?"))
            .ToArray();


        Stats print(string name, string keyboard)
        {
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("--------");
            Console.WriteLine("\n" + name);
            res = Analyze(new Keyboard(keyboard, name), bigrams);
            Console.WriteLine(res);
            return res;
        }


        //Console.WriteLine("\none_trick_roll"); res = Analyze(new Keyboard(Keyboard.one_trick_roll), bigrams); Console.WriteLine(res);

        //Console.WriteLine("\npine v4"); res = Analyze(new Keyboard(Keyboard.Pine_v4), bigrams); Console.WriteLine(res);

        //Console.WriteLine("\ngraphite"); res = Analyze(new Keyboard(Keyboard.Graphite), bigrams); Console.WriteLine(res);

        var stats = new Stats[] {
        print("qwerty",Keyboard.QWERTY),
        print("handsdown", Keyboard.Handsdown),

        print("roller", Keyboard.RollerCoaster),
        //print("roller-latest", Keyboard.RollerCoasterLatest);
        //print("roller1", Keyboard.RollerCoaster1);
        print("roller2", Keyboard.RollerCoaster2),
        print("roller3", Keyboard.RollerCoaster3),
        print("roller4", Keyboard.RollerCoaster4),
        print("roller5", Keyboard.RollerCoaster5),
        print("roller6", Keyboard.RollerCoaster6),
        };
        Console.WriteLine(string.Join("\n",stats.Select(x=>x.Name+ " "+x.ToString())));
    }


    public static Stats Analyze(Keyboard keyboard, NGram[] bigrams)
    {
        Stats result = new Stats(keyboard.Name);
        int colPrint = 0;
        int matches = 0;

        foreach (var bigram in bigrams)
        {
            bool printed = false;
            var keys = keyboard.Get(bigram.Value);

            bool SFB = ((keys[0].col == 3 || keys[0].col == 4) && (keys[1].col == 3 || keys[1].col == 4))
                || ((keys[0].col == 5 || keys[0].col == 6) && (keys[1].col == 5 || keys[1].col == 6))
                || ((keys[0].col == 9 || keys[0].col == 10) && (keys[1].col == 9 || keys[1].col == 10));

            if (keyboard.ContainsSameRowSequence(keys))
            {
                bool isNeighbour = (Math.Abs(keys[0].col - keys[1].col) == 1);
                bool oneSkipNeighbour = (Math.Abs(keys[0].col - keys[1].col) == 2);
                decimal weight = 1;
                if (isNeighbour)
                {
                    weight = DirectNeighbourWeight;
                }
                if(oneSkipNeighbour) { weight = SameRow1kipNeighbourWeight; }
                decimal value = bigram.Frequency * weight;
                result.Value += value;
                matches++;

                Console.Write($"{bigram.Value} {value.ToString("0.00")}  {(isNeighbour ? "Y" : "N")}{(SFB ? "!" : " ")}");
                printed = true;
            }

            bool neighbourRow = Math.Abs(keys[0].row - keys[1].row) == 1;
            if (neighbourRow) 
            { 
                bool neighbourCol= Math.Abs(keys[0].col- keys[1].col) == 1;
                if(neighbourCol)
                {

                    decimal value = bigram.Frequency * NextRowNeighbourWeight;
                    result.Value += value;
                    matches++;

                    Console.Write($"{bigram.Value} {bigram.Frequency.ToString("0.00")}  ${(SFB ? "!" : " ")}");
                    printed = true;

                }
            }

            if (SFB)
            {
                result.SFB += bigram.Frequency;
                if (!printed)
                    Console.Write($"{bigram.Value} {bigram.Frequency.ToString("0.00")}!!! ");
                printed = true;
            }


            if (printed)
            {
                colPrint++;

                if (colPrint % 1 == 0)
                    Console.WriteLine();
                else
                    Console.Write("   ");
            }
        }

        Console.WriteLine("\nBigram matches: " + matches);
        return result;
    }

}

public class Keyboard
{
    public static readonly string QWERTY = @"
    qwertyuiop'
    asdfghjkl;*
    zxcvbnm,.-/";

    public static readonly string Handsdown = @"
    wfmpv  /.q""'z
    rsntb  ,aeihj
    xcldg  -uoyk*";

    public static readonly string RollerCoaster = @"
	wfmpb  'youlz
	sinak  gtherj
	xqv;,  /d.*c-
";

    public static readonly string RollerCoasterLatest = @"
	wdmpb  'luoyz
	sinag  ktherj
	xqc.,  -fv./*
";
    public static readonly string RollerCoaster1 = @"
	jgmpb  'luofz
	sinac  ytherw
	xqd.,  -kv./*
";
    public static readonly string RollerCoaster2 = @"
	qdlpb  'muoyj
	sinag  ctherv
	zxf.-  ,w.k/*
";
   

    public static readonly string RollerCoaster3 = @"
	qdlpb  'muoy*
	sinag  ctherj
	zxf.-  ,wvk/*
  ";

    // 2 + w bigrams
    public static readonly string RollerCoaster4 = @"
	wdlpf  bmuoy*
	sinag  ctherj
	zxkq-  /v',.-
  ";
    
    // 2 
    public static readonly string RollerCoaster5 = @"
	qpldy  bwuox'
	ainsc  kther;
	.,fgz  -mv*j/
";

    // 2 
    public static readonly string RollerCoaster6 = @"
	qpldb  zfuoy'
	ainsc  kther;
	.,wgx  -mv*j/
";

    public static readonly string one_trick_roll = @"
    .dyw'  zroum/
    itscf  jnael-
    ,kvpb  xhq;g""";


    public static readonly string dvorak = @"
    ',.py  fgcrl/
    aoeui  dhtns-
    ;qjkx  bmwvz""";


    public static readonly string Pine_v4 = @"
    qlcmk  'fuoy/
    nrstw  pheai""
    jxzgv  bd;,._";

    public static readonly string Graphite = @"
    bldwz  'fouj;
    nrtsg  yhaei,
    qxmcv  kp.-/""";



    const int RowSize = 11;
    public string Name;
    public Key[,] Keys;
    public Keyboard(string input, string name)
    {
        Keys = new Key[3, RowSize];
        var rows = input
            .Replace(" ", "")
            .Replace("\t", "")
            .Replace("\r", "")
            .Split("\n", StringSplitOptions.RemoveEmptyEntries);
        if (rows.Length != 3) throw new Exception("only 3 rows");
        if (rows.Any((x) => x.Count() != RowSize)) throw new Exception($"All rows must be length {RowSize}");

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < rows[row].Length; col++)
            {
                Keys[row, col] = new Key(rows[row][col], Fingers.Middle, 0, row, col);
            }
        }
        Name = name;
    }

    public Key[]? ContainsSameRowSequence(string sequence)
    {
        var keys = sequence.Select(x => Get(x)).ToArray();
        return ContainsSameRowSequence(keys) ? keys : (Key[]?)null;
    }

    public bool ContainsSameRowSequence(Key[] keys) => keys.All(x => x.row == keys[0].row);

    public Key[] Get(string s) => s.Select(x => Get(x)).ToArray();

    public Key Get(char c)
    {
        for (int row = 0; row < Keys.GetLength(0); row++)
            for (int col = 0; col < Keys.GetLength(1); col++)
                if (c == Keys[row, col].K)
                    return Keys[row, col];
        throw new Exception($"Cannot find key '{c}'");
    }

}

public enum Hand { Left, Right }
public enum Fingers { Pinkie, Ring, Middle, Index };
public class Stats(string name)
{
    public Decimal Value = 0;
    public Decimal SFB = 0;
    public string Name = name;

    public override string ToString()
    {
        return $"Total: {Value}    SFB: {SFB}%";
    }
}
public record Key(char K, Fingers finger, decimal rowPenalty, int row, int col);

public record NGram(string Value, decimal Frequency, decimal FrequencyWithMirror)
{
    public override string ToString()
    {
        return $"'{Value}' {Frequency}% {FrequencyWithMirror}%";
    }
}