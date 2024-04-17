using System.Globalization;

namespace KeyboardAnalyzer;

public class Corpus
{
    public class Fre
    {
        public int Count;
        public decimal Freq;
    }



    public Dictionary<string, Fre> GetMonoGrams(string corpus)
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
            .Replace("\"", " ")
            .Replace("\t", " ")
            .Replace("\r", "")
            .Replace("\n", " ")
            ;

        for (int i = 0; i < corpus.Length - 1; i++)
        {
            if (corpus[i] == ' ')
                continue;

            var word = $"{corpus[i]}";
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
   new ("er", 1.936M, 3.77M),
new ("re", 1.830M, 3.77M),
new ("th", 3.252M, 3.39M),
new ("ht", 0.142M, 3.39M),
new ("in", 2.479M, 2.79M),
new ("ni", 0.310M, 2.79M),
new ("he", 2.650M, 2.68M),
new ("eh", 0.026M, 2.68M),
new ("an", 1.992M, 2.30M),
new ("na", 0.309M, 2.30M),
new ("it", 1.148M, 2.26M),
new ("ti", 1.107M, 2.26M),
new ("es", 1.260M, 2.14M),
new ("se", 0.877M, 2.14M),
new ("ro", 0.729M, 2.06M),
new ("or", 1.331M, 2.06M),
new ("en", 1.282M, 2.00M),
new ("ne", 0.721M, 2.00M),
new ("on", 1.582M, 1.98M),
new ("no", 0.399M, 1.98M),
new ("ta", 0.516M, 1.89M),
new ("at", 1.379M, 1.89M),
new ("ed", 1.005M, 1.71M),
new ("de", 0.703M, 1.71M),
new ("ar", 1.084M, 1.68M),
new ("ra", 0.595M, 1.68M),
new ("to", 1.221M, 1.65M),
new ("ot", 0.428M, 1.65M),
new ("te", 1.125M, 1.59M),
new ("et", 0.468M, 1.59M),
new ("is", 1.007M, 1.54M),
new ("si", 0.531M, 1.54M),
new ("al", 1.014M, 1.50M),
new ("la", 0.485M, 1.50M),
new ("st", 1.101M, 1.47M),
new ("ts", 0.364M, 1.47M),
new ("le", 0.877M, 1.41M),
new ("el", 0.531M, 1.41M),
new ("nd", 1.328M, 1.36M),
new ("dn", 0.027M, 1.36M),
new ("fo", 0.541M, 1.34M),
new ("of", 0.802M, 1.34M),
new ("ng", 1.164M, 1.23M),
new ("gn", 0.064M, 1.23M),
new ("ou", 1.219M, 1.22M),
new ("uo", 0.006M, 1.22M),
new ("ev", 0.266M, 1.17M),
new ("ve", 0.904M, 1.17M),
new ("il", 0.521M, 1.15M),
new ("li", 0.625M, 1.15M),
new ("me", 0.793M, 1.12M),
new ("em", 0.331M, 1.12M),
new ("sa", 0.230M, 1.06M),
new ("as", 0.830M, 1.06M),
new ("ac", 0.463M, 1.03M),
new ("ca", 0.572M, 1.03M),
new ("ec", 0.449M, 1.03M),
new ("ce", 0.579M, 1.03M),
new ("ha", 0.979M, 1.00M),
new ("ah", 0.018M, 1.00M),
new ("nt", 0.941M, 0.96M),
new ("tn", 0.014M, 0.96M),
new ("ir", 0.307M, 0.95M),
new ("ri", 0.646M, 0.95M),
new ("om", 0.573M, 0.92M),
new ("mo", 0.349M, 0.92M),
new ("co", 0.749M, 0.89M),
new ("oc", 0.146M, 0.89M),
new ("am", 0.315M, 0.87M),
new ("ma", 0.558M, 0.87M),
new ("ea", 0.809M, 0.82M),
new ("ae", 0.010M, 0.82M),
new ("ci", 0.219M, 0.81M),
new ("ic", 0.589M, 0.81M),
new ("ol", 0.335M, 0.78M),
new ("lo", 0.443M, 0.78M),
new ("us", 0.500M, 0.77M),
new ("su", 0.270M, 0.77M),
new ("di", 0.437M, 0.76M),
new ("id", 0.321M, 0.76M),
new ("ur", 0.618M, 0.74M),
new ("ru", 0.120M, 0.74M),
new ("rt", 0.355M, 0.74M),
new ("tr", 0.381M, 0.74M),
new ("so", 0.439M, 0.72M),
new ("os", 0.280M, 0.72M),
new ("io", 0.611M, 0.72M),
new ("oi", 0.106M, 0.72M),
new ("hi", 0.696M, 0.70M),
new ("ih", 0.002M, 0.70M),
new ("tu", 0.226M, 0.69M),
new ("ut", 0.464M, 0.69M),
new ("ow", 0.382M, 0.64M),
new ("wo", 0.255M, 0.64M),
new ("be", 0.568M, 0.62M),
new ("eb", 0.048M, 0.62M),
new ("pe", 0.457M, 0.61M),
new ("ep", 0.152M, 0.61M),
new ("im", 0.288M, 0.58M),
new ("mi", 0.288M, 0.58M),
new ("ad", 0.360M, 0.57M),
new ("da", 0.205M, 0.57M),
new ("ch", 0.551M, 0.55M),
new ("hc", 0.003M, 0.55M),
new ("op", 0.244M, 0.55M),
new ("po", 0.306M, 0.55M),
new ("ai", 0.325M, 0.55M),
new ("ia", 0.222M, 0.55M),
new ("ho", 0.524M, 0.54M),
new ("oh", 0.019M, 0.54M),
new ("vi", 0.285M, 0.54M),
new ("iv", 0.256M, 0.54M),
new ("if", 0.223M, 0.53M),
new ("fi", 0.303M, 0.53M),
new ("ew", 0.136M, 0.52M),
new ("we", 0.387M, 0.52M),
new ("ge", 0.410M, 0.52M),
new ("eg", 0.108M, 0.52M),
new ("ap", 0.191M, 0.51M),
new ("pa", 0.319M, 0.51M),
new ("ei", 0.165M, 0.51M),
new ("ie", 0.343M, 0.51M),
new ("yo", 0.461M, 0.50M),
new ("oy", 0.039M, 0.50M),
new ("wi", 0.474M, 0.48M),
new ("iw", 0.001M, 0.48M),
new ("un", 0.394M, 0.47M),
new ("nu", 0.080M, 0.47M),
new ("ns", 0.437M, 0.47M),
new ("sn", 0.034M, 0.47M),
new ("pr", 0.421M, 0.46M),
new ("rp", 0.034M, 0.46M),
new ("od", 0.197M, 0.45M),
new ("do", 0.253M, 0.45M),
new ("ly", 0.428M, 0.45M),
new ("yl", 0.021M, 0.45M),
new ("rs", 0.442M, 0.45M),
new ("sr", 0.006M, 0.45M),
new ("wa", 0.387M, 0.45M),
new ("aw", 0.060M, 0.45M),
new ("lu", 0.130M, 0.44M),
new ("ul", 0.313M, 0.44M),
new ("ab", 0.240M, 0.44M),
new ("ba", 0.195M, 0.44M),
new ("ct", 0.383M, 0.43M),
new ("tc", 0.051M, 0.43M),
new ("ig", 0.274M, 0.42M),
new ("gi", 0.148M, 0.42M),
new ("fe", 0.245M, 0.38M),
new ("ef", 0.137M, 0.38M),
new ("va", 0.115M, 0.37M),
new ("av", 0.258M, 0.37M),
new ("wh", 0.360M, 0.37M),
new ("hw", 0.005M, 0.37M),
new ("ke", 0.327M, 0.36M),
new ("ek", 0.033M, 0.36M),
new ("ga", 0.149M, 0.36M),
new ("ag", 0.209M, 0.36M),
new ("pl", 0.316M, 0.35M),
new ("lp", 0.039M, 0.35M),
new ("nc", 0.341M, 0.34M),
new ("cn", 0.003M, 0.34M),
new ("sh", 0.321M, 0.34M),
new ("hs", 0.019M, 0.34M),
new ("ay", 0.309M, 0.33M),
new ("ya", 0.019M, 0.33M),
new ("ob", 0.086M, 0.32M),
new ("bo", 0.234M, 0.32M),
new ("cu", 0.151M, 0.31M),
new ("uc", 0.163M, 0.31M),
new ("bu", 0.230M, 0.30M),
new ("ub", 0.069M, 0.30M),
new ("ey", 0.169M, 0.30M),
new ("ye", 0.127M, 0.30M),
new ("dl", 0.034M, 0.29M),
new ("ld", 0.257M, 0.29M),
new ("rd", 0.182M, 0.29M),
new ("dr", 0.103M, 0.29M),
new ("s.", 0.272M, 0.28M),
new (".s", 0.007M, 0.28M),
new ("gr", 0.183M, 0.27M),
new ("rg", 0.087M, 0.27M),
new ("up", 0.167M, 0.26M),
new ("pu", 0.097M, 0.26M),
new ("go", 0.168M, 0.26M),
new ("og", 0.095M, 0.26M),
new ("s,", 0.261M, 0.26M),
new (",s", 0.001M, 0.26M),
new ("rc", 0.101M, 0.26M),
new ("cr", 0.160M, 0.26M),
new ("ov", 0.204M, 0.26M),
new ("vo", 0.055M, 0.26M),
new ("ps", 0.064M, 0.25M),
new ("sp", 0.190M, 0.25M),
new ("fr", 0.211M, 0.25M),
new ("rf", 0.039M, 0.25M),
new ("gh", 0.248M, 0.25M),
new ("hg", 0.001M, 0.25M),
new ("ua", 0.114M, 0.25M),
new ("au", 0.132M, 0.25M),
new ("mp", 0.229M, 0.25M),
new ("pm", 0.016M, 0.25M),
new ("fa", 0.157M, 0.25M),
new ("af", 0.089M, 0.25M),
new ("ry", 0.235M, 0.24M),
new ("yr", 0.007M, 0.24M),
new ("pi", 0.137M, 0.24M),
new ("ip", 0.102M, 0.24M),
new ("ki", 0.155M, 0.24M),
new ("ik", 0.080M, 0.24M),
new ("bl", 0.225M, 0.23M),
new ("lb", 0.010M, 0.23M),
new ("du", 0.132M, 0.23M),
new ("ud", 0.100M, 0.23M),
new ("um", 0.120M, 0.23M),
new ("mu", 0.108M, 0.23M),
new ("ls", 0.171M, 0.22M),
new ("sl", 0.053M, 0.22M),
new ("ty", 0.200M, 0.22M),
new ("yt", 0.023M, 0.22M),
new ("e.", 0.213M, 0.22M),
new (".e", 0.003M, 0.22M),
new ("ex", 0.195M, 0.22M),
new ("xe", 0.020M, 0.22M),
new ("lt", 0.114M, 0.21M),
new ("tl", 0.099M, 0.21M),
new ("ug", 0.130M, 0.21M),
new ("gu", 0.081M, 0.21M),
new ("ck", 0.202M, 0.20M),
new ("kc", 0.001M, 0.20M),
new ("bi", 0.119M, 0.19M),
new ("ib", 0.074M, 0.19M),
new ("e,", 0.189M, 0.19M),
new (",e", 0.000M, 0.19M),
new ("ak", 0.158M, 0.18M),
new ("ka", 0.025M, 0.18M),
new ("cl", 0.167M, 0.18M),
new ("lc", 0.014M, 0.18M),
new ("sc", 0.143M, 0.17M),
new ("cs", 0.025M, 0.17M),
new ("ys", 0.109M, 0.16M),
new ("sy", 0.051M, 0.16M),
new ("'s", 0.158M, 0.16M),
new ("s'", 0.001M, 0.16M),
new ("ue", 0.134M, 0.15M),
new ("eu", 0.021M, 0.15M),
new ("ds", 0.137M, 0.15M),
new ("sd", 0.012M, 0.15M),
new ("rn", 0.142M, 0.15M),
new ("nr", 0.007M, 0.15M),
new ("rm", 0.141M, 0.15M),
new ("mr", 0.007M, 0.15M),
new ("t'", 0.056M, 0.14M),
new ("'t", 0.086M, 0.14M),
new ("br", 0.117M, 0.14M),
new ("rb", 0.025M, 0.14M),
new ("nk", 0.082M, 0.14M),
new ("kn", 0.057M, 0.14M),
new ("ny", 0.124M, 0.14M),
new ("yn", 0.013M, 0.14M),
new ("ks", 0.076M, 0.13M),
new ("sk", 0.057M, 0.13M),
new ("ms", 0.081M, 0.13M),
new ("sm", 0.051M, 0.13M),
new ("rk", 0.128M, 0.13M),
new ("kr", 0.004M, 0.13M),
new ("t.", 0.128M, 0.13M),
new (".t", 0.003M, 0.13M),
new ("by", 0.116M, 0.13M),
new ("yb", 0.012M, 0.13M),
new ("qu", 0.126M, 0.13M),
new ("uq", 0.000M, 0.13M),
new ("eo", 0.080M, 0.13M),
new ("oe", 0.045M, 0.13M),
new ("fu", 0.107M, 0.12M),
new ("uf", 0.018M, 0.12M),
new ("ui", 0.110M, 0.12M),
new ("iu", 0.011M, 0.12M),
new ("ok", 0.101M, 0.11M),
new ("ko", 0.012M, 0.11M),
new ("my", 0.092M, 0.11M),
new ("ym", 0.020M, 0.11M),
new ("t,", 0.109M, 0.11M),
new (",t", 0.000M, 0.11M),
new ("lf", 0.041M, 0.11M),
new ("fl", 0.065M, 0.11M),
new ("ft", 0.092M, 0.10M),
new ("tf", 0.011M, 0.10M),
new ("y,", 0.103M, 0.10M),
new (",y", 0.000M, 0.10M),
new ("d.", 0.100M, 0.10M),
new (".d", 0.001M, 0.10M),
new ("n'", 0.099M, 0.10M),
new ("'n", 0.000M, 0.10M),
new ("n.", 0.098M, 0.10M),
new (".n", 0.001M, 0.10M),
new ("n,", 0.097M, 0.10M),
new (",n", 0.000M, 0.10M),
new ("hr", 0.084M, 0.10M),
new ("rh", 0.011M, 0.10M),
new ("nw", 0.005M, 0.09M),
new ("wn", 0.087M, 0.09M),
new ("rl", 0.079M, 0.09M),
new ("lr", 0.012M, 0.09M),
new ("y.", 0.090M, 0.09M),
new (".y", 0.001M, 0.09M),
new ("pt", 0.081M, 0.09M),
new ("tp", 0.008M, 0.09M),
new ("ju", 0.087M, 0.09M),
new ("uj", 0.001M, 0.09M),
new ("r,", 0.088M, 0.09M),
new (",r", 0.000M, 0.09M),
new ("mb", 0.082M, 0.09M),
new ("bm", 0.006M, 0.09M),
new ("d,", 0.086M, 0.09M),
new (",d", 0.000M, 0.09M),
new ("r.", 0.084M, 0.08M),
new (".r", 0.001M, 0.08M),
new ("wt", 0.005M, 0.08M),
new ("tw", 0.077M, 0.08M),
new ("oa", 0.077M, 0.08M),
new ("ao", 0.003M, 0.08M),
new ("iz", 0.058M, 0.08M),
new ("zi", 0.018M, 0.08M),
new ("nl", 0.070M, 0.08M),
new ("ln", 0.005M, 0.08M),
new ("ph", 0.073M, 0.08M),
new ("hp", 0.003M, 0.08M),
new ("sw", 0.031M, 0.07M),
new ("ws", 0.044M, 0.07M),
new ("jo", 0.059M, 0.07M),
new ("oj", 0.013M, 0.07M),
new ("rv", 0.065M, 0.07M),
new ("vr", 0.001M, 0.07M),
new ("gs", 0.063M, 0.07M),
new ("sg", 0.003M, 0.07M),
new ("xp", 0.066M, 0.07M),
new ("px", 0.000M, 0.07M),
new ("nf", 0.063M, 0.06M),
new ("fn", 0.001M, 0.06M),
new ("gl", 0.055M, 0.06M),
new ("lg", 0.005M, 0.06M),
new ("dy", 0.051M, 0.06M),
new ("yd", 0.007M, 0.06M),
new ("ze", 0.050M, 0.06M),
new ("ez", 0.006M, 0.06M),
new ("hu", 0.054M, 0.05M),
new ("uh", 0.001M, 0.05M),
new ("nv", 0.050M, 0.05M),
new ("vn", 0.000M, 0.05M),
new ("g.", 0.048M, 0.05M),
new (".g", 0.002M, 0.05M),
new ("bs", 0.040M, 0.05M),
new ("sb", 0.010M, 0.05M),
new ("xi", 0.027M, 0.05M),
new ("ix", 0.022M, 0.05M),
new ("wr", 0.033M, 0.05M),
new ("rw", 0.016M, 0.05M),
new ("xt", 0.047M, 0.05M),
new ("tx", 0.001M, 0.05M),
new ("xa", 0.024M, 0.04M),
new ("ax", 0.021M, 0.04M),
new ("l,", 0.045M, 0.04M),
new (",l", 0.000M, 0.04M),
new ("cy", 0.034M, 0.04M),
new ("yc", 0.011M, 0.04M),
new ("g,", 0.044M, 0.04M),
new (",g", 0.000M, 0.04M),
new ("l.", 0.044M, 0.04M),
new (".l", 0.001M, 0.04M),
new ("ej", 0.003M, 0.04M),
new ("je", 0.040M, 0.04M),
new ("lk", 0.027M, 0.04M),
new ("kl", 0.016M, 0.04M),
new ("m.", 0.039M, 0.04M),
new (".m", 0.004M, 0.04M),
new ("hy", 0.041M, 0.04M),
new ("yh", 0.001M, 0.04M),
new ("e'", 0.041M, 0.04M),
new ("'e", 0.000M, 0.04M),
new ("eq", 0.041M, 0.04M),
new ("qe", 0.000M, 0.04M),
new ("i'", 0.041M, 0.04M),
new ("'i", 0.000M, 0.04M),
new ("yi", 0.038M, 0.04M),
new ("iy", 0.002M, 0.04M),
new ("az", 0.020M, 0.04M),
new ("za", 0.019M, 0.04M),
new ("aj", 0.010M, 0.04M),
new ("ja", 0.028M, 0.04M),
new ("py", 0.015M, 0.04M),
new ("yp", 0.022M, 0.04M),
new ("'r", 0.024M, 0.04M),
new ("r'", 0.012M, 0.04M),
new ("nh", 0.009M, 0.03M),
new ("hn", 0.024M, 0.03M),
new ("tm", 0.029M, 0.03M),
new ("mt", 0.003M, 0.03M),
new ("lm", 0.025M, 0.03M),
new ("ml", 0.005M, 0.03M),
   };
    }

}
