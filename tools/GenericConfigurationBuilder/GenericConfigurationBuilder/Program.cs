
internal class Program
{
    private static void Main(string[] args)
    {
        string cfgFolder = @"../../../../../../keymapping/configurations/";

        Compiler.CompileToFile(
            null,
        @"
        '  b  h  g  ""   #@  .:  /*  j  x  
        c  s  n  t  k    ,;  a   e   i  m  
        p  f  l  d  v    -+  u   o   y  w  
                    r    ␣  ",

        Compiler.QWERTY_5_grid_2_thumb,
        [new K(["Q", "W"], ["Z"], null, KKind.Group)],
        (doc, x) => Writers.HoumainKeymapper(doc, cfgFolder + "houmain-keymapper/handsdown-rhodium.conf", x));

        var s = File.ReadAllText(@"c:\temp\backslah.txt");


        Compiler.CompileToFile(
            @"from https://github.com/MicahElliott/flowrist
        combo keys are not fully mapped!!
",
        @"
            ` . b f p x   y w o u '
            ^ l r s t m   . . e i a
            q g k c d v   n h / . ,
                      ␣   \n ",
        Compiler.QWERTY_105_6by5_grid_2_thumb,
        [
            new K(["V", "B"], ["J"], null, KKind.Group),
            new K(["X", "C"], ["Z"], null, KKind.Group),
            new K(["Space", "K"], ["N"], null, KKind.Sequence),
            new K(["Any", "K"], ["H"], null, KKind.Sequence),
        ],
       (doc, x) => Writers.HoumainKeymapper(doc, cfgFolder + "houmain-keymapper/flowrist.conf", x));


    }
}


