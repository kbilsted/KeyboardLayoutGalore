using System.Globalization;
using System.Net.WebSockets;

namespace KeyboardAnalyzer;


public class Program
{
    public static void Main(string[] args)
    {

        Keyboards();

        //Bigrams();
    }

    static void Bigrams()
    {

        var dictionary = new Corpus().GetBigrams(
        File.ReadAllText(@"C:\Users\kbils\Desktop\iweb-corpus-samples-cleaned.txt")
        //File.ReadAllText(@"C:\Users\kbils\Desktop\filtered_full")
        .ToLower());
        Console.WriteLine("bigrams " + dictionary.Count());
        string @out = string.Join("\n", dictionary
                        .OrderByDescending(x => x.Value.Count)
                        .Take(300)
                        .Select(x => $"new Bigram(\"{x.Key}\", {x.Value.Freq.ToString("0.000")}M),")
                    )
                    .Replace("0,", "0.")
                    .Replace("1,", "1.")
                    .Replace("2,", "2.")
                    .Replace("3,", "3.");
        Console.WriteLine(@out);

        Console.ReadLine();

    }

    public static void Keyboards()
    {
        Stats res;
        Bigram[] bigrams = new Corpus().ReadCorpus();

        //Console.WriteLine("qwerty");
        //res = Analyze(new Keyboard(Keyboard.QWERTY), bigrams);
        //Console.WriteLine(res);

        //Console.WriteLine("\nhandsdown");
        //res = Analyze(new Keyboard(Keyboard.Handsdown), bigrams);
        //Console.WriteLine(res);

        //Console.WriteLine("\none_trick_roll");
        //res = Analyze(new Keyboard(Keyboard.one_trick_roll), bigrams);
        //Console.WriteLine(res);

        //Console.WriteLine("\npine v4");
        //res = Analyze(new Keyboard(Keyboard.Pine_v4), bigrams);
        //Console.WriteLine(res);

        Console.WriteLine("\nroller-latest");
        res = Analyze(new Keyboard(Keyboard.RollerCoasterLatest), bigrams);
        Console.WriteLine(res);

        Console.WriteLine("\nroller");
        res = Analyze(new Keyboard(Keyboard.RollerCoaster), bigrams);
        Console.WriteLine(res);
    }


    public static Stats Analyze(Keyboard keyboard, Bigram[] bigrams)
    {
        Stats result = new Stats();
        int colPrint = 0;
        int matches = 0;

        foreach (var bigram in bigrams)
        {
            bool printed = false;
            var keys = keyboard.Get(bigram.Value);

            bool SFB = ((keys[0].col == 3 || keys[0].col == 4) && (keys[1].col == 3 || keys[1].col == 4))
                || ((keys[0].col == 5 || keys[0].col == 6) && (keys[1].col == 5 || keys[1].col == 6));

            if (keyboard.ContainsSameRowSequence(keys))
            {
                bool isNeighbour = (Math.Abs(keys[0].col - keys[1].col) == 1);
                decimal value = bigram.Frequency * (isNeighbour ? 1.5m : 1.0M);
                result.Value += value;
                matches++;

                Console.Write($"{bigram.Value} {value.ToString("0.00")}  {(isNeighbour ? "Y" : "N")}{(SFB ? "!" : " ")}");
                printed = true;
            }

            if (SFB)
            {
                result.SFB += bigram.Frequency;
                if (!printed)
                    Console.Write($"{bigram.Value} !!!!     ");
                printed = true;
            }


            if (printed)
            {
                colPrint++;

                if (colPrint % 5 == 0)
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
    asdfghjkl;'
    zxcvbnm,.-/";

    public static readonly string RollerCoaster = @"
	wfmpb  -youlz
	sinak  'therj
	xvd;,  /q.gc-";

    public static readonly string RollerCoasterLatest = @"
	wfmpb  -youlz
	sinak  'therj
	xvq;,  /d.gc-";



    public static readonly string Handsdown = @"
    wfmpv  /.q""'z
    rsntb  ,aeihj
    xcldg  -uoyk'";


    public static readonly string one_trick_roll = @"
    .dyw'  zroum/
    itscf  jnael-
    ,kvpb  xhq;g""";

    public static readonly string Pine_v4 = @"
    qlcmk  'fuoy/
    nrstw  pheai""
    jxzgv  bd;,._";







    const int RowSize = 11;

    public Key[,] Keys;
    public Keyboard(string input)
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
public class Stats()
{
    public Decimal Value = 0;
    public Decimal SFB = 0;


    public override string ToString()
    {
        return $"Total: {Value}    SFB: {SFB}%";
    }
}
public record Key(char K, Fingers finger, decimal rowPenalty, int row, int col);

public record Bigram(string Value, decimal Frequency)
{
    public override string ToString()
    {
        return "'" + Value + "' " + Frequency;
    }
}
