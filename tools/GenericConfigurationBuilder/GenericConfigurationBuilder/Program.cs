
internal class Program
{
    private static void Main(string[] args)
    {
        string cfgFolder = @"../../../../../../keymapping/configurations/";
        Compiler.CompileToFile(
                @"
                '  b  h  g  ""   #@  .:  /*  j  x  
                c  s  n  t  k    ,;  a   e   i  m  
                p  f  l  d  v    -+  u   o   y  w  
                r   ␣  ",
                Compiler.QWERTY_5_grid_2_thumb,
                [new K(["Q", "W"], ["Z"], null, KKind.Group)],
                x => Writers.HoumainKeymapper(cfgFolder+"houmain-keymapper/handsdown-rhodium.conf", x));

    }
}


