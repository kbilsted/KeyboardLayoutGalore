# Keyboard Layouts Galore

This site tries to encompas notes on how to choose and design  keyboard layouts. A large part of modern layouts is doing *layers*, *combos*, *macros*, tap, tap-hold etc. 



# 1. Layouts are more alike thank you think! 

When first being to different keyboard layouts one is quickly overwhelmed by the  great variety. However, upon further scruitiny, the *similarities* of the homerow is surprising! Let's have a look at some keyboards layouts:


### Sorted homerow of selected layouts
|Name          | | | | | | | | | | | | | | | | | | | | | | |
|-             |-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|-|
|Qwerty        |'|;|A| | |D| |F|G|H| |J|K|L| | | | |S| | | |
|Dvorak        |-| |A| | |D|E| | |H|I| | | |N|O| | |S|T|U| |
|Colemak       |'| |A| | |D|E| | |H|I| | | |N|O| |R|S|T|
|Three Layout  | | |A| | |D|E| | |H|I| | | |N|O| |R|S|T|
|Hands Down Neu|,| |A|B| | |E| | |H|I|J| | |N| | |R|S|T|
|Engram        |,|.|A| |C| |E| | |H|I| | | |N| |Q| |S|T|
|Workman       |'| |A| | | |E| |G|H|I| | | |N|O| | |S|T| |Y|
|Canary        |'| |A| |C| |E|F|G| |I| | | |N| | |R|S|T|


Notice a great similarity among them  - of course with QWERTY being the most different to the rest.

Also notice the choice of infrequent letters:

* **Dvorak** prioritizing *U, -*
* **Colemak** prioritizing *'*
* **Workman** prioritizing *Y, '*
* **HandsDown** prioritizing *B, J* 
* **Engram** prioritizing *Q, C*
* **Canary** prioritizing *C, F*


### Actual homerow of selected layouts
|Name ||||||||||||
|-|-|-|-|-|-|-|-|-|-|-|-|
|Qwerty|A|S|D|F|G|H|J|K|L|;|'|
|Dvorak|A|O|E|U|I|D|H|T|N|S|-|
|Colemak|A|R|S|T|D|H|N|E|I|O|'|
|Workman|A|S|H|T|G|Y|N|E|O|I|'|
|Canary|C|R|S|T|G|F|N|E|I|A|' |
|Hands Down Neu|R|S|N|T|B|,|A|E|I|H|J|
|Engram|C|I|E|A|,|.|H|T|S|N|Q|
|Three Layout|O|H|E|A|I|D|R|T|N|S| |


### English Letter frequencies
Since the real estate of the home row is king, we should expect the most frequently used keys here. Of course there are considerations such as finger travel, same finger usage etc  never the less it is interesting to compare with the letter frequencies of english. (source: https://en.wikipedia.org/wiki/Letter_frequency).

|Letter|Frequency
|-| -|
|E|	12.7%	|
|T|	9.1%	|
|A|	8.2%	|
|O|	7.5%	|
|I|	7.0%	|
|N|	6.7%	|
|S|	6.3%	|
|H|	6.1%	|
|R|	6.0%	|
|D|	4.3%	|
|L|	4.0%	|
|C|	2.8%	|
|U|	2.8%	|
|M|	2.4%	|





### Pitfalls of letter frequencies
 
A note on frequencies. There are a number of issues when turning to letter frequences during keyboard layout design

First, frequences reveals a lot about the language we *read*, but **nothing** about the language we *edit*. Editing is a big part of writing, so in order to design and choose a keyboard, one must understand how we interact with the keyboard while editing. E.g.  `backspace` is probably one of the most used keys along with cursor keys! Use a keylogger! On windows a free privacy centered logger is https://github.com/kbilsted/KeyboordUsage 

Second, there are differences between frequencies used in texts/books, and just ploving through dictionaries. Frequencies are also very language dependent E.g. the letter *E* is used more often in english than in german.

Third, the majority of people who are interested in tweaking their keyboard do programming activities, where frequencies of symbols such as `( { [ < , $ " \ : ; > ] } )` should be taken into consideration.


### C# symbol and number frequencies
These frequencies are from a smallish personal collection. They are very scewed. For example, in the editor pressing `///` will type out 9 slashes! When typing an open parenthesis such as `(` the editor will auto complete `)`.

Finally AI models auto complete more and more code these days.. We must advice to use a keylogger to get real editing experiences

| symbol | Count | Frequnecy |
| -      | -     |         - |
|  | 477098 | 23,43% |
|\n| 278341 | 13,67% |
| /| 190978 | 9,38% |
| .| 133025 | 6,53% |
| )| 104010 | 5,11% |
| (| 104005 | 5,11% |
| ;| 76137 | 3,74% |
| "| 70453 | 3,46% |
| ,| 67650 | 3,32% |
| \|| 63009 | 3,09% |
| >| 61351 | 3,01% |
| <| 56574 | 2,78% |
| -| 39304 | 1,93% |
| _| 36189 | 1,78% |
| }| 35930 | 1,76% |
| {| 35887 | 1,76% |
| 2| 25278 | 1,24% |
| 0| 24924 | 1,22% |
| 1| 18393 | 0,90% |
| 3| 13470 | 0,66% |
| [| 13393 | 0,66% |
| ]| 13387 | 0,66% |
| 4| 8573  | 0,42% |
| +| 8555  | 0,42% |



# Layouts notes


## Dvorak
source: https://en.wikipedia.org/wiki/Dvorak_keyboard_layout

```
    '   ,   .   p   y      f   g   c   r   l   /
    a   o   e   u   i      d   h   t   n   s   -
    ;   q   j   k   x      b   m   w   v   z   `
```

Next to QWERTY it is the most well known layout. 


# Canary
Source: https://github.com/Apsu/Canary

```
w l y p k z x o u ; [ ] \
 c r s t b f n e i a '
  j v d g q m h / , .
```

ortha

```
w l y p b z f o u '
c r s t g m n e i a
q j v d k x h / , . 
```

## Engram 
Source: https://engram.dev/

```
    B   Y   O   U   '    L   D   W   V   Z
    C   I   E   A   ,    H   T   S   N   Q
    G   X   J   K   -    R   M   F   P
```

Engram is fairly similar to Dvorak making the transition from one to the other fairly easy. Here we analyze where letters are found on the same row.

```
   Y                     L
   A   E   I             H   T   N   S
   J   K   X             M
```




# Keyboard layering
A very easy to understand and "low tech" approach is to remap the ALT keys as shown in the "Red-BLUE" layout. https://www.youtube.com/watch?v=92pRAQeRIak&ab_channel=RomanStrakhov



 # Appendix

## 3L Three Layout
Source: https://github.com/jackrosenthal/threelayout


 Various stuff that I've been using to generate this page. Will be moved soon as irrelevant to most.


 helper code

*homerow*

 ```
string join(IEnumerable<object> s) => string.Join("", s.Select(x => x.ToString()));

(string, string)[] kb = [("Qwerty", "ASDFGHJKL;"), ("Dvorak", "AOEUIDHTNS-"), ("Colemak", "ARSTDHNEIO'"), ("Workman", "ASHTGYNEOI'"), ("Hands Down Neu", "RSNTB,AEIHJ"), ("Engram", "CIEA,.HTSNQ"), ("Three Layout", "OHEAIDRTNS "),];
string sorted = $"|Name {join(kb.Select(x=>"|"))}\n{join(kb.Select(x=>"|-"))}|\n{string.Join("\n", kb.Select(x => $"|{x.Item1}|{string.Join("|", x.Item2.OrderBy(c => c))}|"))}";
string raw = $"|Name {join(kb.Select(x => "|"))}\n{join(kb.Select(x => "|-"))}|\n{string.Join("\n", kb.Select(x => $"|{x.Item1}|{string.Join("|", x.Item2.Select(c => c))}|"))}";
Console.WriteLine($"{sorted}\n\n{raw}");```



