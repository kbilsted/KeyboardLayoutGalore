record keyb(string layout)
{
    private long score = -1;

    public static Fingers[] FingerByPos = [
        Fingers.LPinky,Fingers.LRing,Fingers.LLong,Fingers.LIndex,Fingers.LIndex,Fingers.RIndex, Fingers.RIndex,Fingers.RLong,Fingers.RRing, Fingers.RPinky, //
        Fingers.LPinky,Fingers.LRing,Fingers.LLong,Fingers.LIndex,Fingers.LIndex,Fingers.RIndex, Fingers.RIndex,Fingers.RLong,Fingers.RRing, Fingers.RPinky,Fingers.RPinky, //
        Fingers.LPinky,Fingers.LRing,Fingers.LLong,Fingers.LIndex,Fingers.LIndex,Fingers.RIndex, Fingers.RIndex,Fingers.RLong,Fingers.RRing, Fingers.RPinky,
    ];

    public static int[] RowByPos =
    [
        1, 1, 1, 1, 1, 1, 1, 1, 1, 1, //
        2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, //
        3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
    ];

    public static int[] ColByPos =
    [
        1, 2, 3, 4, 5, /**/ 6, 7, 8, 9, 10, //
        1, 2, 3, 4, 5, /**/ 6, 7, 8, 9, 10, 11, //
        1, 2, 3, 4, 5, /**/ 6, 7, 8, 9, 10,
    ];
    public static int[] ColByPosOrg =
    [
        1, 2, 3, 4, 5, /**/ 9, 10, 11, 12, 13, //
        1, 2, 3, 4, 5, /**/ 9, 10, 11, 12, 13, 14, //
        1, 2, 3, 4, 5, /**/ 9, 10, 11, 12, 13,
    ];

    public static int[] FingerStrengthByPos =
    [
        02, 03, 04, 05, 03, /**/ 03, 05, 04, 03, 02, //
        03, 04, 05, 07, 04, /**/ 04, 07, 05, 04, 03, 01, //
        01, 02, 03, 05, 03, /**/ 03, 05, 03, 02, 01,
    ];

    public static Hand[] HandByPos =
    [
        Hand.Left, Hand.Left, Hand.Left, Hand.Left, Hand.Left, Hand.Right, Hand.Right,Hand.Right,Hand.Right,Hand.Right, //
        Hand.Left, Hand.Left, Hand.Left, Hand.Left, Hand.Left, Hand.Right, Hand.Right,Hand.Right,Hand.Right,Hand.Right,Hand.Right, //
        Hand.Left, Hand.Left, Hand.Left, Hand.Left, Hand.Left, Hand.Right, Hand.Right,Hand.Right,Hand.Right,Hand.Right,
    ];

    public void Print()
    {
        Hand h = Hand.Left;
        for (int i = 0; i < layout.Length; i++)
        {
            if (HandByPos[i] != h)
            {
                h = HandByPos[i];
                if (h == Hand.Right)
                    Console.Write("  ");
                else
                    Console.WriteLine();
            }
            Console.Write(layout[i]);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("score: " + score);
        Console.WriteLine("score: " + long.MaxValue);
        Console.WriteLine($"add(\"{layout}\"); // {score}");
        Console.WriteLine();
    }

    public long Score(NGram[] grams)
    {
        if (score == -1)
            score = grams.Sum(ScoreBigram);
        return score;
    }

    public long PrintScore(NGram[] grams)
    {
        if (score == -1)
            score = grams.Sum(PrintScoreBigram);
        return score;
    }

    public long PrintScoreBigram(NGram g)
    {
        var score = ScoreBigram(g);
        if (score > 0)
            Console.WriteLine(g.Value + "  " + score);
        return score;
    }

    private Dictionary<char, decimal> charfreq = Corpus.Getmonograms();

    long ScoreBigram(NGram g)
    {
        var gram = g.Value;
        var index1 = layout.IndexOf(gram[0]);
        var index2 = layout.IndexOf(gram[1]);
        int row1 = RowByPos[index1];
        int row2 = RowByPos[index2];
        int col1 = ColByPos[index1];
        int col2 = ColByPos[index2];
        Fingers f1 = FingerByPos[index1];
        Fingers f2 = FingerByPos[index2];
        Hand h1 = HandByPos[index1];
        Hand h2 = HandByPos[index2];
        decimal charFreq1 = charfreq[g.Value[0]];
        decimal charFreq2 = charfreq[g.Value[1]];


        if ((col1 is 5 or 6) && charFreq1 > 3.5m)
            return -10;
        if ((col2 is 5 or 6) && charFreq2 > 3.5m)
            return -10;

        if ((col1 is 11) && charFreq1 > 2m)
            return -10;
        if ((col2 is 11) && charFreq2 > 2m)
            return -10;


        var result = g.FreqSquared;

        //        result = result * FingerStrengthByPos[index1] * FingerStrengthByPos[index2];
        int rowDiff = Math.Abs(row1 - row2);
        float colDiff = Math.Abs(col1 - col2);


        if (f1 != f2)
            result *= 2;

        if(rowDiff==0 )
            result *= 2;
        if (rowDiff == 0&& row1== 2)
            result *= 2;

        //if (colDiff > 1)
        //    colDiff = colDiff - 0.5f;

        if (colDiff != 0)
            result = (int)(result / colDiff);

        bool indexsamefinger = (f1 == Fingers.LIndex && f2 == Fingers.LIndex) || (f1 == Fingers.RIndex && f2 == Fingers.RIndex);
        if ((colDiff == 0 ||indexsamefinger)  && rowDiff == 1)
            return -result / 4; 
        if ((colDiff == 0||indexsamefinger) && rowDiff == 2)
            return -result / 2;


        return result;
    }


    long ScoreBigramAdvanced(NGram g)
    {
        var gram = g.Value;
        var index1 = layout.IndexOf(gram[0]);
        var index2 = layout.IndexOf(gram[1]);
        int row1 = RowByPos[index1];
        int row2 = RowByPos[index2];
        int col1 = ColByPos[index1];
        int col2 = ColByPos[index2];
        Fingers f1 = FingerByPos[index1];
        Fingers f2 = FingerByPos[index2];
        Hand h1 = HandByPos[index1];
        Hand h2 = HandByPos[index2];
        decimal charFreq1 = charfreq[g.Value[0]];
        decimal charFreq2 = charfreq[g.Value[1]];


        // prefer middle then top row then bottom row
        int rowmodifier = (row1 == 2 ? 3 : row1 == 1 ? 2 : 1) * (row2 == 2 ? 3 : row2 == 1 ? 2 : 1);
        int sameFingerModifier = f1 == f2 ? 1 : 1000;

        var both = f1 | f2;
        if (((both & Fingers.Pinky) != 0) && f1 == f2)
            return 0;

        // forbid frequent use of pinky
        // dont use too frequent keys on inner or outer columns
        if (col2 is 14 && charFreq2 > 2)
            return 0;
        if (col1 is 14 && charFreq1 > 2)
            return 0;

        if (row1 == 2)
        {
            if (col1 is 1 or 13 && charFreq1 > 6.6m)
                return 0;
        }
        else
        {
            if (col1 is 1 or 13 && charFreq1 > 2)
                return 0;
        }

        if (row2 == 2)
        {
            if ((col2 is 1 or 13) && charFreq2 > 6.6m)
                return 0;
        }
        else
        {
            if ((col2 is 1 or 13) && charFreq2 > 2)
                return 0;
        }
        if ((col1 is 5 or 9) && charFreq1 > 4)
            return 0;
        if ((col2 is 5 or 9) && charFreq2 > 4)
            return 0;

        int fingerModifier =
            (both & Fingers.Pinky) != 0
                ? 1
                : (both & Fingers.Ring) != 0
                    ? 3
                    : (both & Fingers.Index) != 0
                        ? 50
                        : 10;

        var sameRow = row1 == row2;
        var columDiff = Math.Abs(col1 - col2);
        var rowDiff = Math.Abs(row1 - row2);
        var sameCol = col1 == col2;


        if (sameRow && columDiff == 1)
        {
            return g.FreqSquared * 100 * rowmodifier * fingerModifier;
        }

        //if (sameRow && columDiff == 1)
        //{
        //    return g.FreqSquared * 100 * rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier;
        //}

        if (sameRow && columDiff == 2)
        {
            return g.FreqSquared * 12 * rowmodifier * fingerModifier; //* rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier;
        }

        if (rowDiff == 1 && columDiff == 1)
        {
            return g.FreqSquared * 7 * rowmodifier * fingerModifier;//* rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier;
        }

        //if (sameRow && columDiff == 3)
        //{
        //    return g.FreqSquared * 4 * rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier;
        //}
        //if (rowDiff == 1 && columDiff == 2)
        //{
        //    return g.FreqSquared * 2 * rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier;
        //}
        //if (sameRow)
        //{
        //    return g.FreqSquared * rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier;
        //}

        //// penalties
        //if (sameCol && rowDiff == 2)
        //{
        //    return -g.FreqSquared * rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier;
        //}

        //if (sameCol)
        //{
        //    return -g.FreqSquared * rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier;
        //}

        //if (rowDiff == 2)
        //{
        //    return -g.FreqSquared * rowmodifier * sameHandModifier * fingerModifier * sameFingerModifier / 10;
        //}

        return 0;
    }

    public keyb Mutate(int mutations)
    {
        var newlayout = layout.ToCharArray();
        for (int i = 0; i < mutations; i++)
        {
            int pos1 = Random.Shared.Next(newlayout.Length);
            int pos2 = Random.Shared.Next(newlayout.Length);
            (newlayout[pos2], newlayout[pos1]) = (newlayout[pos1], newlayout[pos2]);
        }

        return new keyb(new string(newlayout));
    }

    public override int GetHashCode()
    {
        return layout.GetHashCode();
    }

    public virtual bool Equals(keyb? other)
    {
        return layout.Equals(other.layout);
    }


    public Score TypeText(string text)
    {
        text = text.Replace(" ", "").ToLower();

        var score = new Score(new Dictionary<(int colDelta, int rowDelta), int>(), 0);


        int index = layout.IndexOf(text[0]);
        int lastRow = RowByPos[index];
        int lastCol = ColByPos[index];
        Fingers lastFinger = FingerByPos[index];
        Hand lastHand = HandByPos[index];
        score.TotalCharsTyped += 1;

        for (int i = 1; i < text.Length; i++)
        {
            index = layout.IndexOf(text[i]);
            if (index == -1)
                continue;

            int deltaRow = Math.Abs(lastRow - RowByPos[index]);
            lastRow = RowByPos[index];
            int deltaCol = Math.Abs(lastCol - ColByPos[index]);
            lastCol = ColByPos[index];
            bool newHand = lastHand != HandByPos[index];
            lastHand = HandByPos[index];

            if (newHand)
                score.Alternations += 1;

            var key = (deltaCol, deltaRow);
            score.Bigrams.TryAdd(key, 0);
            score.Bigrams[key] += 1;
            score.TotalCharsTyped += 1;

        }


        return score;
    }

}


public class Score(Dictionary<(int colDelta, int rowDelta), int> bigrams, int alternations)
{
    public Dictionary<(int colDelta, int rowDelta), int> Bigrams { get; } = bigrams;
    public int Alternations { get; set; } = alternations;
    public int TotalCharsTyped;
    public decimal AlternattionPct => (Alternations / (decimal)TotalCharsTyped) * 100M;


    public override string ToString()
    {
        var values = bigrams
            .Where(x => x.Key is not { rowDelta: 0, colDelta: 0 })
            .Where(x => x.Key.rowDelta == 0 || x.Key is { rowDelta: 1, colDelta: <= 1 })
            .OrderBy(x => x.Key.rowDelta)
            .ThenBy(x => x.Key.colDelta)
            .Select(x => x.Key + " = " + x.Value);
        return "bigram: " +
               string.Join("\n", values)
               + "\nAlternations: " + AlternattionPct;
    }
}