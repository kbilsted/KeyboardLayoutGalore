using System.Globalization;

namespace KeyboardAnalyzer;

public class Corpus
{
    public class Fre
    {
        public int Count;
        public decimal Freq;
    }

    public Dictionary<string, Fre> GetBigrams(string corpus)
    {
        Dictionary<string, Fre> grams = new Dictionary<string, Fre>();

        corpus = corpus
            .Replace("0", " ")
            .Replace("1", " ")
            .Replace("2", " ")
            .Replace("3", " ")
            .Replace("4", " ")
            .Replace("5", " ")
            .Replace("6", " ")
            .Replace("7", " ")
            .Replace("8", " ")
            .Replace("9", " ")
            .Replace("(", " ")
            .Replace(")", " ")
            .Replace("-", " ")
            .Replace(";", " ")
            .Replace(":", " ")
            .Replace(".", " ")
            .Replace(",", " ")
            .Replace("r", " ")
            .Replace("\"", " ")
            .Replace("\t", " ")
            .Replace("\r", "")
            .Replace("\n", " ")
            ;

        for (int i = 0; i < corpus.Length - 1; i++)
        {
            if (corpus[i] == ' ' || corpus[i + 1] == ' ')
            {
                continue;
            }

            if (corpus[i] == corpus[i + 1])
            {
                continue;
            }

            var word = "" + corpus[i] + corpus[i + 1];
            if (!grams.TryGetValue(word, out var val))
            {
                grams.Add(word, new Fre() { Count = 1 });
            }
            else
            {

                val.Count = val.Count + 1;
            }
        }

        var total = grams.Sum(x => x.Value.Count);
        foreach (var gra in grams)
        {
            gra.Value.Freq = gra.Value.Count * 100M / (decimal)total;
        }

        return grams;
    }


    public Bigram[] ReadCorpus()
    {
        return new Bigram[]
        {

            new Bigram("th", 3.857M),
new Bigram("he", 3.142M),
new Bigram("in", 2.940M),
new Bigram("an", 2.362M),
new Bigram("on", 1.875M),
new Bigram("at", 1.635M),
new Bigram("nd", 1.575M),
new Bigram("en", 1.520M),
new Bigram("es", 1.494M),
new Bigram("to", 1.448M),
new Bigram("ou", 1.445M),
new Bigram("ng", 1.380M),
new Bigram("it", 1.362M),
new Bigram("te", 1.334M),
new Bigram("ti", 1.313M),
new Bigram("st", 1.305M),
new Bigram("al", 1.202M),
new Bigram("is", 1.194M),
new Bigram("ed", 1.192M),
new Bigram("ha", 1.161M),
new Bigram("nt", 1.116M),
new Bigram("ve", 1.072M),
new Bigram("le", 1.040M),
new Bigram("se", 1.040M),
new Bigram("as", 0.985M),
new Bigram("ea", 0.960M),
new Bigram("of", 0.951M),
new Bigram("me", 0.941M),
new Bigram("co", 0.888M),
new Bigram("ne", 0.855M),
new Bigram("de", 0.833M),
new Bigram("hi", 0.826M),
new Bigram("li", 0.741M),
new Bigram("io", 0.725M),
new Bigram("ic", 0.698M),
new Bigram("ce", 0.687M),
new Bigram("om", 0.679M),
new Bigram("ca", 0.678M),
new Bigram("be", 0.674M),
new Bigram("ma", 0.661M),
new Bigram("ch", 0.654M),
new Bigram("fo", 0.641M),
new Bigram("el", 0.630M),
new Bigram("si", 0.630M),
new Bigram("ho", 0.621M),
new Bigram("il", 0.618M),
new Bigram("ta", 0.612M),
new Bigram("us", 0.593M),
new Bigram("la", 0.575M),
new Bigram("wi", 0.562M),
new Bigram("et", 0.555M),
new Bigram("ut", 0.551M),
new Bigram("ac", 0.549M),
new Bigram("yo", 0.547M),
new Bigram("pe", 0.542M),
new Bigram("ec", 0.532M),
new Bigram("lo", 0.525M),
new Bigram("so", 0.520M),
new Bigram("ns", 0.519M),
new Bigram("di", 0.518M),
new Bigram("ly", 0.507M),
new Bigram("ot", 0.507M),
new Bigram("ge", 0.486M),
new Bigram("no", 0.473M),
new Bigram("un", 0.467M),
new Bigram("wa", 0.459M),
new Bigram("we", 0.459M),
new Bigram("ct", 0.454M),
new Bigram("ow", 0.454M),
new Bigram("ts", 0.432M),
new Bigram("wh", 0.427M),
new Bigram("ad", 0.427M),
new Bigram("mo", 0.413M),
new Bigram("ie", 0.407M),
new Bigram("nc", 0.404M),
new Bigram("ol", 0.397M),
new Bigram("em", 0.393M),
new Bigram("ke", 0.388M),
new Bigram("ai", 0.386M),
new Bigram("id", 0.381M),
new Bigram("sh", 0.381M),
new Bigram("pa", 0.378M),
new Bigram("pl", 0.375M),
new Bigram("am", 0.374M),
new Bigram("ul", 0.371M),
new Bigram("ni", 0.367M),
new Bigram("na", 0.367M),
new Bigram("ay", 0.367M),
new Bigram("po", 0.363M),
new Bigram("fi", 0.360M),
new Bigram("im", 0.342M),
new Bigram("mi", 0.341M),
new Bigram("vi", 0.338M),
new Bigram("os", 0.332M),
new Bigram("ig", 0.325M),
new Bigram("su", 0.321M),
new Bigram("ev", 0.316M),
new Bigram("av", 0.306M),
new Bigram("ld", 0.305M),
new Bigram("iv", 0.303M),
new Bigram("wo", 0.302M),
new Bigram("do", 0.300M),
new Bigram("gh", 0.294M),
new Bigram("fe", 0.290M),
new Bigram("op", 0.289M),
new Bigram("ab", 0.285M),
new Bigram("bo", 0.278M),
new Bigram("sa", 0.273M),
new Bigram("bu", 0.273M),
new Bigram("mp", 0.272M),
new Bigram("tu", 0.268M),
new Bigram("bl", 0.267M),
new Bigram("if", 0.264M),
new Bigram("ia", 0.263M),
new Bigram("ci", 0.259M),
new Bigram("ag", 0.247M),
new Bigram("da", 0.243M),
new Bigram("ov", 0.242M),
new Bigram("ck", 0.240M),
new Bigram("ty", 0.237M),
new Bigram("od", 0.234M),
new Bigram("ex", 0.231M),
new Bigram("ba", 0.231M),
new Bigram("ap", 0.226M),
new Bigram("sp", 0.226M),
new Bigram("ls", 0.203M),
new Bigram("ey", 0.200M),
new Bigram("go", 0.200M),
new Bigram("up", 0.198M),
new Bigram("cl", 0.198M),
new Bigram("ei", 0.196M),
new Bigram("uc", 0.194M),
new Bigram("ak", 0.187M),
new Bigram("'s", 0.187M),
new Bigram("fa", 0.186M),
new Bigram("ki", 0.184M),
new Bigram("ep", 0.180M),
new Bigram("cu", 0.179M),
new Bigram("ga", 0.177M),
new Bigram("gi", 0.175M),
new Bigram("oc", 0.173M),
new Bigram("sc", 0.169M),
new Bigram("ht", 0.168M),
new Bigram("pi", 0.163M),
new Bigram("ds", 0.163M),
new Bigram("ef", 0.163M),
new Bigram("ew", 0.161M),
new Bigram("ue", 0.159M),
new Bigram("du", 0.157M),
new Bigram("au", 0.156M),
new Bigram("lu", 0.155M),
new Bigram("ug", 0.154M),
new Bigram("ye", 0.151M),
new Bigram("qu", 0.150M),
new Bigram("ny", 0.147M),
new Bigram("um", 0.142M),
new Bigram("bi", 0.141M),
new Bigram("by", 0.137M),
new Bigram("va", 0.137M),
new Bigram("ua", 0.136M),
new Bigram("lt", 0.135M),
new Bigram("ui", 0.131M),
new Bigram("ys", 0.129M),
new Bigram("mu", 0.128M),
new Bigram("eg", 0.128M),
new Bigram("fu", 0.126M),
new Bigram("oi", 0.126M),
new Bigram("ip", 0.122M),
new Bigram("ok", 0.120M),
new Bigram("ud", 0.119M),
new Bigram("n'", 0.118M),
new Bigram("tl", 0.117M),
new Bigram("pu", 0.115M),
new Bigram("og", 0.112M),
new Bigram("ft", 0.110M),
new Bigram("my", 0.109M),
new Bigram("af", 0.105M),
new Bigram("ju", 0.104M),
new Bigram("wn", 0.103M),
new Bigram("'t", 0.102M),
new Bigram("ob", 0.101M),
new Bigram("mb", 0.097M),
new Bigram("nk", 0.097M),
new Bigram("pt", 0.096M),
new Bigram("ms", 0.096M),
new Bigram("gu", 0.096M),
new Bigram("eo", 0.095M),
new Bigram("ik", 0.095M),
new Bigram("nu", 0.095M),
new Bigram("tw", 0.092M),
new Bigram("oa", 0.091M),
new Bigram("ks", 0.091M),
new Bigram("ib", 0.087M),
new Bigram("ph", 0.086M),
new Bigram("nl", 0.083M),
new Bigram("ub", 0.082M),
new Bigram("xp", 0.078M),
new Bigram("fl", 0.077M),
new Bigram("ps", 0.076M),
new Bigram("gn", 0.075M),
new Bigram("gs", 0.075M),
new Bigram("nf", 0.074M),
new Bigram("aw", 0.072M),
new Bigram("jo", 0.071M),
new Bigram("iz", 0.069M),
new Bigram("sk", 0.068M),
new Bigram("kn", 0.068M),
new Bigram("t'", 0.067M),
new Bigram("gl", 0.066M),
new Bigram("vo", 0.065M),
new Bigram("hu", 0.064M),
new Bigram("sl", 0.063M),
new Bigram("tc", 0.061M),
new Bigram("sm", 0.061M),
new Bigram("dy", 0.061M),
new Bigram("sy", 0.060M),
new Bigram("ze", 0.060M),
new Bigram("nv", 0.060M),
new Bigram("eb", 0.057M),
new Bigram("xt", 0.056M),
new Bigram("oe", 0.053M),
new Bigram("ws", 0.052M),
new Bigram("hy", 0.049M),
new Bigram("e'", 0.049M),
new Bigram("eq", 0.048M),
new Bigram("lf", 0.048M),
new Bigram("i'", 0.048M),
new Bigram("bs", 0.048M),
new Bigram("je", 0.048M),
new Bigram("oy", 0.047M),
new Bigram("lp", 0.046M),
new Bigram("yi", 0.045M),
new Bigram("sn", 0.041M),
new Bigram("dl", 0.041M),
new Bigram("cy", 0.040M),
new Bigram("ek", 0.039M),
new Bigram("sw", 0.037M),
new Bigram("tm", 0.034M),
new Bigram("lv", 0.033M),
new Bigram("ja", 0.033M),
new Bigram("u'", 0.032M),
new Bigram("dg", 0.032M),
new Bigram("lk", 0.032M),
new Bigram("dn", 0.032M),
new Bigram("xi", 0.032M),
new Bigram("eh", 0.031M),
new Bigram("lm", 0.030M),
new Bigram("cs", 0.030M),
new Bigram("ka", 0.030M),
new Bigram("xa", 0.029M),
new Bigram("hn", 0.028M),
new Bigram("gy", 0.028M),
new Bigram("dv", 0.027M),
new Bigram("yt", 0.027M),
new Bigram("xc", 0.027M),
new Bigram("yp", 0.027M),
new Bigram("ix", 0.027M),
new Bigram("yl", 0.025M),
new Bigram("eu", 0.025M),
new Bigram("ax", 0.025M),
new Bigram("nm", 0.024M),
new Bigram("'m", 0.024M),
new Bigram("xe", 0.024M),
new Bigram("az", 0.024M),
new Bigram("ym", 0.023M),
new Bigram("ya", 0.023M),
new Bigram("ox", 0.022M),
new Bigram("oh", 0.022M),
new Bigram("za", 0.022M),
new Bigram("hs", 0.022M),
new Bigram("y'", 0.022M),
new Bigram("'v", 0.022M),
new Bigram("uf", 0.022M),
new Bigram("ah", 0.021M),
new Bigram("hl", 0.021M),
new Bigram("zi", 0.021M),
new Bigram("uy", 0.021M),
new Bigram("lw", 0.020M),
new Bigram("sf", 0.019M),
new Bigram("pm", 0.019M),
new Bigram("'l", 0.019M),
new Bigram("kl", 0.019M),
new Bigram("py", 0.017M),
new Bigram("nj", 0.017M),
new Bigram("tn", 0.017M),
new Bigram("dm", 0.017M),
new Bigram("lc", 0.016M),
new Bigram("oj", 0.015M),
new Bigram("yn", 0.015M),
new Bigram("wl", 0.015M),
new Bigram("gt", 0.015M),
new Bigram("ko", 0.015M),
new Bigram("sd", 0.014M),
new Bigram("iq", 0.014M),
new Bigram("yb", 0.014M),
new Bigram("iu", 0.014M),
new Bigram("tf", 0.013M),
new Bigram("ky", 0.013M),
new Bigram("fy", 0.013M),
new Bigram("yc", 0.013M),

        };
    }

}
