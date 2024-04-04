# Case C# code analysis vs keyloging
This page describes actual cases of code bases compared to keyloggers


Conclusions so far:

* Cursor movement, `Backspace`, `Enter` and `.`, `,` are used a lot and should be easily accessible on the main layout. Currently they often reside in the outermost of the keyboard and should be moved to better real estate.
  * `.` and `shift-.` was pressed 1.51% and `,` and `shift-,` was pressed 1.30% of the time
  * `b` and `shift-b` was pressed 0.52% and `j` 0.03% of the time
  
* Top characters from file analysis and keylogger almost match - even when disregarding comments
  *  `E N T R S I A O` (Analysis)
  *  `E I R N S O A C` (Keylogger)
  *  `E T A O I N S R` (English language frequency from wikipedia)


## Case 1. a character frequency analyzer
I wrote a small program to do simple frequency analysis of `.cs` files. While I coded, I used a keylogger to track the actual keyboard usage (see https://github.com/kbilsted/KeyboordUsage)


For reference the code under analysis can be found here [CodeFrequencyAnalyzer](tools/CodeFrequencyAnalyzer/Program.cs). Notice that this reflects an end result - not the whole process of doing and re-doing parts of the code, changing datastructures etc. 

Also note that this was a small coding session. 

From the table below we observe the following


### Top Code characters from *file analysis*

    . ( ) = ; , " 
    
totalling 2.28 + 2.20 + 2.20 + 1.94 + 1.36 = **9.98%**
    

### Top code characters from *keylogger*

    . ( = , { & ; 

totalling 1.43 + 1.30 + 1.15 + 0.83 + 0.55 + 0.52 +0.47 + 0.47 = **6.72%**

The reason we don't see `)` and `}` is due to editor auto completion. The lower percentages is due to the navigation keys.



### Top naviation characters from *keylogger*
    
    RETURN DOWN UP BACKSPACE LEFT

totalling 6.19 +6.17 + 5.39 + 3.77 + 3.75 = **25.27%**



### Raw data

The table below consists of several columns
* *Version A* represents raw character count. It is here for reference and perhaps the least useful in understanding the usage
* *Version B* we trim each line since all whitespace at the start of the lines are autocompleted by the editor. Also we skip all `using` and `namespace` declarations since they too are autocompleted by the IDE
* *Version C* We ignore all spaces since most spaces are inserted when reformating the code in the editor.
* *Version D* is the keylogger data

`ñ` represents newline



The below table analyses just this simple p

|A|Freq A|B|Freq B|C|Freq C|D |Freq D|
|-|-|-|-|-|-|-|-|
|                      | 29,62%|                     e|  9,07%|                     e| 10,37%|                Return|  6,19%|
|                     e|  7,02%|                      |  8,68%|                     n|  6,70%|                  Down|  6,17%|
|                     n|  4,52%|                     n|  5,86%|                     a|  6,17%|      RShiftKey, Shift|  5,57%|
|                     s|  4,15%|                     a|  5,40%|                     s|  5,92%|                    Up|  5,39%|
|                     a|  4,10%|                     s|  5,18%|                     i|  5,89%|                 Space|  3,90%|
|                     i|  3,97%|                     i|  5,16%|                     r|  5,48%|                  Back|  3,77%|
|                     r|  3,67%|                     r|  4,79%|                     t|  5,17%|                  Left|  3,75%|
|                     t|  3,58%|                     t|  4,52%|                     l|  4,42%|  LControlKey, Control|  3,12%|
|                     l|  2,94%|                     l|  3,87%|                     o|  4,34%|                     E|  2,76%|
|                    \n|  2,92%|                    \n|  3,79%|                     c|  3,42%|                 Right|  2,47%|
|                     o|  2,90%|                     o|  3,79%|                     u|  3,00%|                     I|  2,39%|
|                     c|  2,26%|                     c|  2,99%|                     g|  2,83%|         Left, Control|  2,34%|
|                     u|  2,06%|                     u|  2,63%|                     .|  2,64%|                   Tab|  2,19%|
|                     g|  1,95%|                     g|  2,48%|                     d|  2,58%|                     R|  2,11%|
|                     .|  1,84%|                     .|  2,31%|                     (|  2,47%|        Right, Control|  2,11%|
|                     d|  1,71%|                     d|  2,26%|                     )|  2,47%|                     N|  2,08%|
|                     (|  1,63%|                     (|  2,16%|                     =|  1,95%|                     S|  2,06%|
|                     )|  1,63%|                     )|  2,16%|                     ;|  1,72%|                     O|  1,90%|
|                     =|  1,29%|                     =|  1,70%|                     m|  1,61%|LControlKey, Control, Alt|  1,90%|
|                     ;|  1,19%|                     ;|  1,51%|                     f|  1,50%|            RMenu, Alt|  1,90%|
|                     m|  1,12%|                     m|  1,41%|                     y|  1,50%|                     A|  1,87%|
|                     y|  1,05%|                     f|  1,31%|                     "|  1,50%|                     C|  1,64%|
|                     p|  0,99%|                     y|  1,31%|                     p|  1,47%|      LShiftKey, Shift|  1,48%|
|                     f|  0,99%|                     "|  1,31%|                     ,|  1,39%|             OemPeriod|  1,43%|
|                     "|  0,99%|                     p|  1,29%|                     w|  1,03%|                   End|  1,38%|
|                     ,|  0,92%|                     ,|  1,22%|                    \\|  1,03%|             D8, Shift|  1,30%|
|                     w|  0,68%|                     w|  0,90%|                     b|  0,89%|                     T|  1,30%|
|                    \\|  0,68%|                    \\|  0,90%|                     x|  0,81%|                     U|  1,17%|
|                     x|  0,61%|                     b|  0,78%|                     v|  0,78%|             D0, Shift|  1,15%|
|                     b|  0,59%|                     x|  0,71%|                     h|  0,78%|                     L|  1,12%|
|                     v|  0,51%|                     v|  0,68%|                     {|  0,69%|  RControlKey, Control|  0,88%|
|                     h|  0,51%|                     h|  0,68%|                     }|  0,69%|                     G|  0,83%|
|                     {|  0,46%|                     {|  0,61%|                     >|  0,58%|              Oemcomma|  0,83%|
|                     }|  0,46%|                     }|  0,61%|                     z|  0,56%|                     F|  0,83%|
|                     >|  0,39%|                     >|  0,51%|                     [|  0,56%|            S, Control|  0,78%|
|                     z|  0,37%|                     z|  0,49%|                     ]|  0,56%|                     D|  0,73%|
|                     [|  0,37%|                     [|  0,49%|                     k|  0,47%|         Back, Control|  0,73%|
|                     ]|  0,37%|                     ]|  0,49%|                     +|  0,47%|           Down, Shift|  0,68%|
|                     k|  0,31%|                     k|  0,41%|                    \||  0,42%|                     M|  0,62%|
|                     +|  0,31%|                     +|  0,41%|                     <|  0,39%|      D7, Control, Alt|  0,55%|
|                    \||  0,28%|                    \||  0,36%|                     '|  0,39%|                Delete|  0,55%|
|                     <|  0,26%|                     <|  0,34%|                     q|  0,36%|             D6, Shift|  0,52%|
|                     '|  0,26%|                     '|  0,34%|                     &|  0,33%|                     B|  0,49%|
|                     q|  0,24%|                     q|  0,32%|                     /|  0,31%|                     W|  0,49%|
|                     &|  0,22%|                     &|  0,29%|                     0|  0,28%|       Oemcomma, Shift|  0,47%|
|                     /|  0,20%|                     /|  0,27%|                     *|  0,22%|                     V|  0,47%|
|                     0|  0,18%|                     0|  0,24%|                     !|  0,19%|             D9, Shift|  0,47%|
|                     *|  0,15%|                     *|  0,19%|                     j|  0,17%|                Escape|  0,47%|
|                     j|  0,13%|                     !|  0,17%|                     1|  0,14%|                  Home|  0,44%|
|                     !|  0,13%|                     j|  0,15%|                     2|  0,08%|      D8, Control, Alt|  0,44%|
|                     1|  0,09%|                     1|  0,12%|                     @|  0,06%|                     P|  0,39%|
|                     2|  0,06%|                     2|  0,07%|                     :|  0,06%|                     H|  0,36%|
|                     @|  0,04%|                     @|  0,05%|                     -|  0,06%|          Space, Shift|  0,36%|
|                     :|  0,04%|                     :|  0,05%|                     $|  0,06%|             D7, Shift|  0,36%|
|                     -|  0,04%|                     -|  0,05%|                     6|  0,03%|            V, Control|  0,36%|
|                     $|  0,04%|                     $|  0,05%|                     %|  0,03%|           OemQuestion|  0,34%|
|                     6|  0,02%|                     6|  0,02%|                     ?|  0,03%|               Oemplus|  0,31%|
|                     %|  0,02%|                     %|  0,02%|                  |        |                     X|  0,31%|
|                     ?|  0,02%|                     ?|  0,02%|                  |        |OemBackslash, Control, Alt|  0,29%|
|                  |        |                  |        |                  |        |                     Y|  0,26%|
|                  |        |                  |        |                  |        |                    D1|  0,23%|
|                  |        |                  |        |                  |        |              OemMinus|  0,21%|
|                  |        |                  |        |                  |        |          Right, Shift|  0,21%|
|                  |        |                  |        |                  |        | Right, Shift, Control|  0,18%|
|                  |        |                  |        |                  |        |            C, Control|  0,18%|
|                  |        |                  |        |                  |        |             D2, Shift|  0,18%|
|                  |        |                  |        |                  |        |                    D2|  0,18%|
|                  |        |                  |        |                  |        |OemOpenBrackets, Control, Alt|  0,18%|
|                  |        |                  |        |                  |        |                    F5|  0,18%|
|                  |        |                  |        |                  |        |    OemQuestion, Shift|  0,16%|
|                  |        |                  |        |                  |        |       Delete, Control|  0,16%|
|                  |        |                  |        |                  |        |                    D0|  0,16%|
|                  |        |                  |        |                  |        |            End, Shift|  0,16%|
|                  |        |                  |        |                  |        |   OemBackslash, Shift|  0,16%|
|                  |        |                  |        |                  |        |            X, Control|  0,16%|
|                  |        |                  |        |                  |        |              I, Shift|  0,13%|
|                  |        |                  |        |                  |        |            LMenu, Alt|  0,13%|
|                  |        |                  |        |                  |        |      D9, Control, Alt|  0,13%|
|                  |        |                  |        |                  |        |        Space, Control|  0,13%|
|                  |        |                  |        |                  |        |              M, Shift|  0,13%|
|                  |        |                  |        |                  |        |             Up, Shift|  0,13%|
|                  |        |                  |        |                  |        |                     Q|  0,10%|
|                  |        |                  |        |                  |        |                     Z|  0,10%|
|                  |        |                  |        |                  |        |              U, Shift|  0,10%|
|                  |        |                  |        |                  |        |                     K|  0,10%|
|                  |        |                  |        |                  |        |          OemBackslash|  0,10%|
|                  |        |                  |        |                  |        |             D5, Shift|  0,10%|
|                  |        |                  |        |                  |        |             D1, Shift|  0,10%|
|                  |        |                  |        |                  |        |           Left, Shift|  0,10%|
|                  |        |                  |        |                  |        |      D0, Control, Alt|  0,10%|
|                  |        |                  |        |                  |        |            K, Control|  0,10%|
|                  |        |                  |        |                  |        |  Left, Shift, Control|  0,10%|
|                  |        |                  |        |                  |        |RShiftKey, Shift, Control|  0,10%|
|                  |        |                  |        |                  |        |RControlKey, Shift, Control|  0,08%|
|                  |        |                  |        |                  |        |      OemPeriod, Shift|  0,08%|
|                  |        |                  |        |                  |        |              C, Shift|  0,05%|
|                  |        |                  |        |                  |        |              A, Shift|  0,05%|
|                  |        |                  |        |                  |        |           Oem7, Shift|  0,05%|
|                  |        |                  |        |                  |        |           Back, Shift|  0,05%|
|                  |        |                  |        |                  |        |             D3, Shift|  0,05%|
|                  |        |                  |        |                  |        |            D, Control|  0,05%|
|                  |        |                  |        |                  |        |            G, Control|  0,05%|
|                  |        |                  |        |                  |        |              N, Shift|  0,05%|
|                  |        |                  |        |                  |        |                    D8|  0,05%|
|                  |        |                  |        |                  |        |        Oemplus, Shift|  0,05%|
|                  |        |                  |        |                  |        |              R, Shift|  0,05%|
|                  |        |                  |        |                  |        |       OemOpenBrackets|  0,05%|
|                  |        |                  |        |                  |        |              X, Shift|  0,05%|
|                  |        |                  |        |                  |        |                  Oem1|  0,05%|
|                  |        |                  |        |                  |        |                    D5|  0,05%|
|                  |        |                  |        |                  |        |           Oem1, Shift|  0,05%|
|                  |        |                  |        |                  |        |               Capital|  0,05%|
|                  |        |                  |        |                  |        |              F, Shift|  0,03%|
|                  |        |                  |        |                  |        |              D, Shift|  0,03%|
|                  |        |                  |        |                  |        |           Return, Alt|  0,03%|
|                  |        |                  |        |                  |        |                    D9|  0,03%|
|                  |        |                  |        |                  |        |                     J|  0,03%|
|                  |        |                  |        |                  |        |            Z, Control|  0,03%|
|                  |        |                  |        |                  |        |            T, Control|  0,03%|
|                  |        |                  |        |                  |        |              G, Shift|  0,03%|
|                  |        |                  |        |                  |        |              L, Shift|  0,03%|
|                  |        |                  |        |                  |        |              W, Shift|  0,03%|
|                  |        |                  |        |                  |        |      D4, Control, Alt|  0,03%|
|                  |        |                  |        |                  |        |    Oem1, Control, Alt|  0,03%|
|                  |        |                  |        |                  |        |          Tab, Control|  0,03%|
|                  |        |                  |        |                  |        |           Up, Control|  0,03%|
|                  |        |                  |        |                  |        |                PageUp|  0,03%|
|                  |        |                  |        |                  |        |                  Next|  0,03%|
|                  |        |                  |        |                  |        |      D2, Control, Alt|  0,03%|
|                  |        |                  |        |                  |        |              B, Shift|  0,03%|
|                  |        |                  |        |                  |        |              Tab, Alt|  0,03%|
|                  |        |                  |        |                  |        |            Right, Alt|  0,03%|
|                  |        |                  |        |                  |        |            L, Control|  0,03%|
|                  |        |                  |        |                  |        |           F5, Control|  0,03%|
|                  |        |                  |        |                  |        |                    D4|  0,03%|
|                  |        |                  |        |                  |        |                    D6|  0,03%|
|                  |        |                  |        |                  |        |                Scroll|  0,03%|
|                  |        |                  |        |                  |        |                   F12|  0,03%|
