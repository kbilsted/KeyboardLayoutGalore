# The rollercoaster keyboard layout 

The Roller Coaster keyboard layout is a new layout that emphaises on bringing the fun into typing.

The design philosophy of the layout is that we get the most joy out of typing letter that are placed on the keyboard to the left or right of the currently pressed key. The closer the two keys are to eachother, the more we enjoy it. Thus by induction, if it is nice to type two letters close to each other, it is nicer to type with a layout where all keys exhibit this property! Switching rows is not preferable, unless the next key is placed diagonally (one to the side and one down/up).  From well-established character frequency analysis, we then let the most frequent bigrams and trigrams to form the layout.  

Modern layouts take a different approach. Vovels and consonants are placed on opposite sides. This forces continually alternation of hands while typing. A principle formulated by Dvorak in 1936. Since common trigrams involve both consonants and vowels, keeping most consonants away from the vowels minimizes one-handed trigrams. This separation also makes it easier to achieve very low same finger bigrams. Personlly, I think one handed trigrams are fun to type and should be embraced rather than avoided.

Since this is so different to any of the other layouts out there, what we are doing is either ingenious or borderline crazy! Time will tell.

Now, there are a number of other factors in determining whether a layout is comfortable to type on. Most notable are

* Rolls and hand alternation
* Finger strength - placing most frequent letters on the strongest fingers 
* Same finger bigraam - reduce the situation where the same finger is used twice in a row 
* Lateral movement - reduce the amount of lateral/horizontal movement 
* Computer assisted keyboard analysis
* Overall feel 

We will go through each of these after introducing the layout 


## The layout 

The layout as I use it day-to-day is what we present here, we have alternatives presented later with lower same finger bigrams, or more bigram rolls, respectively. See appendix.

    qpldy  bfuoj
	ainsc  kther
	.,wgz  -mv;x
	
 


While there are other factors that come into play, the emphasis on rolls have a direct impact on alternations between hands. As documented in https://docs.google.com/document/d/1_a5Nzbkwyk1o0bvTctZrtgsee9jSP-6I0q3A0_9Mzm0/edit too little hands alternation may lead to very long same hand sequences. Judging from  the existing modern layouts (like the onces sited in the link) alternation have been a priority. Perhaps because it makes it easier to reduce same finger bigrams. 

For a long time we did not pay much attention to reducing same finger bigrams - mostly because we wanted to explore and experiment with high rolls. This culminated with version 1 of the roller coaster layout.


There are a number of other factoer but we get back to those in a moment. 


If placing keys often used to

They are fun to type because the they are 
 

Take a second to reflect on what series of keys you enjoy typing on a QWERTY layout. For me is When reflecting on v



# Work journal for the Roller Coaster layout
This page journals the development of the layout, perhaps mostly interesting too me on my journey. For motivations for learning the layout see xxx.

## Initial idea
We optimize for most common bigrams TH, ER, HE, IS IN, AN by placing those letters on the home row. 
OU was inspired from Canay and Hands Down, the rest of the keys are starting of from the Hands down (e.g. w,j,b,z,x)

Some of the most fun words to type on qwerty is
* POWER
* RETRY
* FEVER

	wpoum  'lydkz
	anisb  'rethj
	xcf;,  /q.gv-


## reduce pinky (anis -> sina)
It quickly became apparent that having S caused undue strain on the pinky finger when typing. To reduce load on the pinky finger, swap the letters such that the bigrams are still on the home row

	wpoum  'lydkz
	sinab  'rethj
	xcf;,  /q.gv-


## reduce strain right index (ly -> yl)

I think there is too much strain on the right index finger with 'ly' on the top. We swap since Y is much less frequent than L.

	wpoum  'yldkz
	sinab  'rethj
	xcf;,  /q.gv-



## reduce pinky (reth -> ethr)
	wpoum  'yldkz
	sinab  'ethrj
	xcf;,  /q.gv-


## reduce lowrow and weird scisors with f and make bigram OF same row! 
(swap f<->k)

	wpoum  'yldfz
	sinab  'ethrj
	xck;,  /q.gv-



## remove SFB O-N 1.76%   vs  I-N (2.43%)  vs A-N (1.99%)
(WPOUM -> WOUMP)

	woump  'yldfz
	sinab  'ethrj
	xck;,  /q.gv-


## Too much trampolining with R on pinky.. 
we put R it there to reduce pinky but broke ER (2.05%)
support TH + HE + ER  and same row for AL (1.09) + LE (0.83) + LI (0.62)
(swap R<->L)

	woump  'yrdfz
	sinab  'ehtlj
	xck;,  /q.gv-


## remove weird gymnastics of c key (C<->V)

	woump  'yrdfz
	sinab  'ehtlj
	xvk;,  /q.gc-


## Less trambolining with TH-E (EHT -> THE)

	woump  'yrdfz
	sinab  'thelj
	xvk;,  /q.gc-


## more bigram by moving r to pinky again
(swap R<->L)

	woump  'yldfz
	sinab  'therj
	xvk;,  /q.gc-


## Move OU to stronger hand (7.6%+2.73%)
(swap OU<->LD)

	wldmp  'youfz
	sinab  'therj
	xvk;,  /q.gc-


## Improve SFB for ND (1.35% ) + MA (0.57%)
(SWAP D<->M)

	wlmdp  'youfz
	sinab  'therj
	xvk;,  /q.gc-


## more rolling but with more finger movements
 we swap B-P since P is more frequent 
(SWAP D<->B<->P)

	wlmpb  'youfz
	sinad  'therj
	xvk;,  /q.gc-


## remove lateral stress 
move D<->K

	wlmpb  'youfz
	sinak  'therj
	xvd;,  /q.gc-

## make more like HD
(L<->F)

	wfmpb  'youlz
	sinak  'therj
	xvd;,  /q.gc-

## optimize ND (1.56%) and place D on a stronger finger
(D<->Q)

	wfmpb  'youlz
	sinak  'therj
	xvq;,  /d.gc-


## optimize and place V (1.05%) on a stronger finger Q (0.12)
(D<->Q)

	wfmpb  'youlz
	sinak  'therj
	xqv;,  /d.gc-



## more rolls with g on homerow - but yields more SFB
('<->G)

	wfmpb  'youlz
	sinak  gtherj
	xqv;,  /d.*c-
	
	

## more rolls with V on top 
(5 more bigrams but 0.1% SFB)
(V<->B) .. but i remember not liking V up here.. lets try for a bit..

	wfmpv  'youlz
	sinak  gtherj
	xqb;,  /d.*c-
	

## optimize home row?
Can we reverse the "THER" to "REHT" and get a better result? 
T is 9,28% and R is 6.28% so we would increase pinky by 3%!


## you inward rolls
(G<->K) move work to other finger - works really nice with G on index) possibly due to trigram "ING"
(J<->W) 
(reverse Y-O-U - nicer place for O and gives inward roll on "found", "you" etc rather than outward rolls
using our optimizer we accidently placed F on top row

	jcmpb  'luofz
	sinag  ytherw
	xqd.-  ,kv./*
	
OR and RO isnt that bad.. words like "and", hand is so nice would
"found" is pretty cool "roof".. also 
AGAIn is uncomfortable



## more movement for index--but many more bigrams.. lets evaluate

	jcmpb  'luofz
	sinad  gtherw
	xqy.,  -kv./*";

!!! Didn't like it ! Too much index Going back!


## old layout again

	jcmpb  'luofz
	sinag  ytherw
	xqd.-  ,kv./*


## support 3rd most trigram AND

Write "AND" (1.2%) using 3 fingers rather than 2 fingers.. and place C as qwerty
and improve SFB
and make other words easier eg "AD" (0.5%) 
(C<->D)

	jdmpb  'luofz
	sinag  ytherw
	xqc.-  ,kv./*


## support 5th trigram "FOR" (0.6%) better 
and DIRECT 7th trigram "YOU" (0.6%) 
"ly","by" also much easier to type
and improve SFB
(F<->Y)

	jdmpb  'luoyz
	sinag  ftherw
	xqc.-  ,kv./*


## miniscule improvement and make it look more like qwerty
(X<->Z)

	jdmpb  'luoyx
	sinag  ftherw
	zqc.-  ,kv./*


## More rolls for C

slightly worse.. but want to move C to top due to it being more frequent
hurts "AC" (1%), 
improves "OC" (0.8%), "CU" (0.3%), "NC (0.3%) easier
move "V" since the spot is much easier to reach on a stagered keyboard

(C<->P)
(V<->.) costs 1% SFB! but so easier to hit

	jdmcb  'luoyx
	sinag  ftherw
	zqp,-  .k.v/*


## X was odd in upper right
(Z<->X) feels more natural 

	jdmcb  'luoyz
	sinag  ftherw
	xqp,-  .k.v/*


## improve rolls by 0.6%
Tempting to swap Y-W but it yields more sfb, breaks the trigram and reduces bigrams
(P<->K)

	jdmcb  'luoyz
	sinag  ftherw
	xqk,-  .p.v/*

wonderful change! much better rolls!
eg "thanks", "pasted" "stops", "key" 


## Upprove bigram rolls for upper and mid row

change upperrow for more bigrams, we look at the bigrams by searching for `".?(q|v|k|p|x|j|f|g|w|l|b|j|c)`


b
be = 0.62M
ab = 0.44M
bo = 0.32M
bu = 0.30M
bi = 0.19M
br = 0.14M
homerow=1.68
bl = 0.23
by = 0.13
mb = 0.09
upper = 0.45


c
ca = 1.03
ec = 1.03
ic = 0.81
ch = 0.55
ct = 0.43
nc = 0.34
cr = 0.26
> homerow 4.4 - 1.1 = 3.3
uc 0.31
co 0.89

d
de = 1.62 
nd = 1.28 
id = 0.72
ad = 0.53
od = 0.43
ld = 0.28
rd = 0.27


f
of = 1.50
fu = 0.12
>move f to upper
fi = 0.50
fe = 0.36
fr = 0.28
fa = 0.23
> homerow=0.9


g
ng = 1.23
ge = 0.52
ig = 0.42

ag = 0.36
gr = 0.27
>homerow=2.8
go = 0.26


j
ju = 0.08
jo = 0.07
je = 0.04



k
ke = 0.327M, 0.36M
> K so low frequency we leave it


l
al = 1.50
le = 1.41
li = 1.15
> homerow=4.06
ol = 0.78
ly = 0.45
ul = 0.44
ld = 0.29
> upper=1.95
pl = 0.316M, 0.35M


m
me = 1.12
ma = 0.87
im = 0.58
rm = 0.15
ms = 0.13
>home 2.85
om = 0.92
mp = 0.25
um = 0.23
my = 0.11
mb = 0.08
>top 1.59




p
> right
pe = 0.61M
pr = 0.46M
pt = 0.09M
ph = 0.08M
> left
sp = 0.25M
pa = 0.51M
> home=2.0
pl = 0.35M
po = 0.55M
up = 0.26M
>upperrow=1.16


q
qe = 0.04
qi = 0.01


v
ve = 1.17
vi = 0.54
av = 0.37
>homerow=2.34
ov = 0.26
v to homerow (v=1.05% vs W 1.68% - reduce pinky by putting W on index on V on pinky
but more inroll with V on index..



w
we = 0.52
wi = 0.48
wa = 0.45
wh = 0.37
> homerow=1.8
ow = 0.64
 
 



y
yo = 0.50
ly = 0.45
> top 0.95
ay = 0.33
ey = 0.30
ry = 0.24
ty = 0.22
ys = 0.16
ny = 0.14
> home 1.39

x
xe = 0.20
xp = 0.06




upperrow P,B, L, - more pinky! but better than dvorak
homerow  C, G, W ,
low k, x,v, f
(P<->C) - this is the best position as "Y" only rolls with YO/LY
(C<->F) - this possition supports "CA/CT"
(K<->K) - we swap since "FO" is 1.34% while next bigram is FI 0.53% - so we avoid the scissors FO

	jdmpb  'luoyz
	sinag  ctherw
	xqf,-  .k.v/*




## more like qwerty

(J<->Z)
(Z<->X) swap so Z bigrams (IZ 0.08%, ZE 0.06%) are a bit easier to type
(Q<->X) swap so we place keys more like QWERTY

	qdmpb  'luoyj
	sinag  ctherw
	zxf,-  .k.v/*

J so nice with words like "just" inward roll rather than alternation
Q in "question" reasonable
F-K seem a bit weird..should be swapped perhaps


## Moving L from index
(L<->M) i never liked L on index and gives more balanced left-right hand usage
(W<->V) V has more bigrams on homerow than W - w still is nice for

	qdlpb  'muoyj
	sinag  ctherv
	zxf,-  .w.k/*

i like the placement of l and m



# this is pure danger
we swap YOU to the other side
optimize for ING, AND AL,NO
it also places almost all vovels on one side which leads us down the path of looking like all the other keyboard layouts..
 
not sure if its a good idea of moving away from homerow for g... lets try it

	yulo,  'dmpqj
	sinag  ctherv
	zxk.*  fwb;.*

we get much better SFB - but we loose a lot of the rolls!



# Back on track..
we move W to lower left to avoid OW scisors, and avoid WH, WE 
i dont like B... so we swap and add delete and newline for ergonomics

	qdlpb ↵muoyj
	sinag  ctherv
	zxwk⌫ f*,.-


# outer rolls for the win! kA is esier than WA!
quite against common knowlege outer rolls are sometimes much easier than inner rolls!
e.g. KA is easier than WA. KA is less frequent so we swap


ak = 0.17
wa = 0.42 (and bigram was/way = 0.3)
(K<->W)

after using it a bit im happy

	qdlpb ↵muoyj
	sinag  ctherv
	zxkw⌫ f*,.-


## More rolls with W at top
(Q<->W) to get more rolls with W
(Q<->K) K is more frequent and easier spot to hit
(F<->P) move F to top row since F and O have very high bigram frequency. f is on the left side rather than the right side since moving M to the other side has more SFB - also MO is 0.83 and FO is 1.27. "UOF" rather than "UOY" is also problematic for writing the trigram "FOR" which is very common
(B<->*) More infrequent B to a bad spot to make room for an adaptive key for later use
(J to low row) move J down since it was a huge distance for the pinky to reach in the upper coner

when we move D to the home row we get a lot of trambolining and stuff.. it did not feel nice. perhaps 
too much action for the index?? need to experiment more

	wdlpf↵ bmuoy
	sinag  ctherv
	zxqk⌫  j.-


i really like the LD and LF rolls.. like in couLD and haLF
"if only she could she would half to herself whisper and shiver"
 


## Try moving D down to make top row less crowded with high frequency letters

i did not like this too much.. the  D on the low row was breaking up some nive rolls.. i also tried replacing G with D
which also wasnt nice

	wdlpf  bmuoy'
	sinag  ctherj
	zxqk,  .vd
	

## Too much upper row trafic with both F and P
(F-P-Q)
we swap P and F and move move P down to the low row. Since Q is very often followed by a U 
we put them on the same row. the spot Q takes is one of the worst spots so it makes sense to populate the infrequent Q and B

(Y-J-K)
EY and RY was very difficult. So was the roll YOU at higher speeds. The most frequent bigram with Y is YO (0.50) so that is unfortunate,
but moving it to the right hand makes it still ok to type YOU and it evens out the hand usage a bit more
.. it also turns Y from a pinky to an index.

J is very infrequent, so we place it at the top instead this makes it 1 key closer 

V is on the bottom row again since we do gain rolls placing it next to R but it makes for a stretch
and there are some strange rolls with VE, VR

	wdlfq bmuoj
	sinag cther'
	zxpy⌫ -vk,.


## less pinky stretch by swapping W with something less frequent
stretching the pinky less by moving w to homerow.. v was a bad spot here but VE is more common than WE
so we give it a try

also p on the low row breaks many flows or maybe im passing judgement too soon

we dont want k in the upper corner since it is a very frequent letter in nordic languages

	bdlfy pmuoq'
	sinag ctherj
	zxv*⌫ -wk,.

  


----

starting all over.. almost..
ve 1.11
vo 0.24
wo 0.60
we 0.49
wh 0.35
w on right center is more probable than on the right


vi 0.51
va 0.35
wi 0.45
wa 0.42
wn 0.09
w on left center is more probable than on the right..

so W is most probable both places - but we have va=SFB=0.35 with v on the left. V is more "natural" on the left since it is the same as qwerty almost.. 
we can swap.. but then we have SFB AW - so it really makes no difference
we choose to have ve close since it has the score of 1.11 

also we more G down so it mirrors the pattern A-N-D when typing I-N-G

	qdlfy  bmuoj
	sinaw  vther
	zpxg'  ;ck,.

C on the low row was a bad idea - too much stretching



## Moving j-b-q closer together to make room for y

B and Q uses the U the most. Most frequent bigram of b*, q* , j* is "BE" hence B must be easily reachable and 
hence not on the right pinky. Also B is placed on the QWERTY-Y positiion which on a staggered keyboard is the worst spot

P is on the home row since it gives a nice flow when typing - perhaps also because fingers are not trained to using the qwerty-x key and hence placing P there was odd

	bdlfy  jmuoq
	sinap  cther'
	zxvg/  ;wk,.


only thing i dont like now i C - it breaks the rythm often during typing


# moving C to upper

much more fluent

	bdlfy  jcuoq
	sinap  vther'
	zxmg/  ;wk,.


# engram was right
after some more study i think the engram philosophy is correct. the two innermost rows are not 
comfortable to type. perhaps even the top pinky rows are even worse than bottom pinky rows! 

this layout is really nice to type on. it is really easy to reach the letters Y,F,C,Q,G


there are however some few things not working! 

	bdlyx  jfuow
	sinav  pther'
	zkmg;  *c,.q

* the OW is too hard
* the M and K are not great at the bottom - perhaps my hands are not trained enough for them to be there 


moving the more frequent keys to the stronger fingers. most central positions are homerow + fglm

moving , and . around to give room for keys 
L<->F
Y<->C
X<->Q
M<->P

	bdcfq  kluoy
	sinax  wther
	z,pg-  .mv.j



# breaking the bigam is + an
perhaps we had run into a local maximum in terms of the layot.
the bigrams ING, AND and FOR combines with the bigrams IS and AN severily 
limited our options for further discovery. But a simple permutation
opens up for many wonderful new opportunities

the current layout has a very low SFB of 1.04 

	qpldb  kfuoy
	ainsc  wther
	.,xgz  ;mv/j


# moving w for comfort 
moving w to an easier spot. this in turn moves k to a better spot too
we also swap j and x. this gives more rolls to both.
sfb 1.06


	qpldb  jfuoy
	ainsc  kther
	.,wgz  ;mv/x





# OPTIONAL moving y away from pinky
hard to do fast typing with YOU, also made it hard to type RY and EY 

also z is placed better on a staggered keyboard 1.12

	qpldy  bfuoj
	ainsc  kther
	.,wg;  zmv/x




x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-xx-x-x-

lowest sfb.. we can achieve below 1% sfb but i think it compromises typing comfort

SFB 0.94
	qpldb  kguoy
	ainsc  wther
	.,xfz  ;mv'j



x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-xx-x-x-

x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-xx-x-x-

x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-xx-x-x-




..........................
older notes and ideas

# simulating a magic key with T
T is a magic key that types "the" this removes the need for H on 
the home row since it becomes rarely used. and bigram "TH" is only a 21th spot 

	qdlfy *mpuj/
	sinag  ctoerb
	zxhk⌫ vw,.b


stats



	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("er", 1.663M, 3.43M),
	new ("re", 1.767M, 3.43M),
	new ("**", 2.727M, 2.73M),
	new ("in", 2.394M, 2.69M),
	new ("ni", 0.299M, 2.69M),
	new ("an", 1.923M, 2.22M),
	new ("na", 0.299M, 2.22M),
	new ("it", 1.109M, 2.18M),
	new ("ti", 1.069M, 2.18M),
	new ("es", 1.176M, 2.02M),
	new ("se", 0.847M, 2.02M),
	new ("t@", 1.994M, 2.00M),
	new ("@t", 0.002M, 2.00M),
	new ("ro", 0.703M, 1.99M),
	new ("or", 1.285M, 1.99M),
	new ("on", 1.527M, 1.91M),
	new ("no", 0.385M, 1.91M),
	new ("en", 1.200M, 1.90M),
	new ("ne", 0.696M, 1.90M),
	new ("ta", 0.498M, 1.83M),
	new ("at", 1.331M, 1.83M),
	new ("ed", 0.970M, 1.65M),
	new ("de", 0.678M, 1.65M),
	new ("ar", 1.047M, 1.62M),
	new ("ra", 0.574M, 1.62M),
	new ("to", 1.179M, 1.59M),
	new ("ot", 0.413M, 1.59M),
	new ("te", 1.086M, 1.54M),
	new ("et", 0.450M, 1.54M),
	new ("is", 0.972M, 1.48M),
	new ("si", 0.513M, 1.48M),
	new ("al", 0.979M, 1.45M),
	new ("la", 0.468M, 1.45M),
	new ("st", 1.063M, 1.41M),
	new ("ts", 0.352M, 1.41M),
	new ("le", 0.847M, 1.36M),
	new ("el", 0.512M, 1.36M),
	new ("nd", 1.282M, 1.31M),
	new ("dn", 0.026M, 1.31M),
	new ("fo", 0.522M, 1.30M),
	new ("of", 0.775M, 1.30M),
	new ("th", 1.146M, 1.28M),
	new ("ht", 0.137M, 1.28M),
	new ("ng", 1.124M, 1.19M),
	new ("gn", 0.061M, 1.19M),
	new ("ou", 1.177M, 1.18M),
	new ("uo", 0.006M, 1.18M),

 
stats https://norvig.com/mayzner.html                           https://spjdrpedia.dk/wiki/Frekvensanalyse
                                                                danish
	BI  COUNT   PERCENT graph     LETTER  COUNT   PERCENT          
	TH  100.3 B (3.56%)                E 445.2 B  12.49%        e	16.70%	    
	HE   86.7 B (3.07%)                T 330.5 B   9.28%        r	7.61%	
	IN   68.6 B (2.43%)                A 286.5 B   8.04%        n	7.55%	
	ER   57.8 B (2.05%)                O 272.3 B   7.64%        d	7.24%	
	AN   56.0 B (1.99%)                I 269.7 B   7.57%        t	7.03%	
	RE   52.3 B (1.85%)                N 257.8 B   7.23%        a	6.01%	
	ON   49.6 B (1.76%)                S 232.1 B   6.51%        s	5.67%	
	AT   41.9 B (1.49%)                R 223.8 B   6.28%        i	5.55%	
	EN   41.0 B (1.45%)                H 180.1 B   5.05%        l	4.85%	
	ND   38.1 B (1.35%)                L 145.0 B   4.07%        g	4.56%	
	TI   37.9 B (1.34%)                D 136.0 B   3.82%        o	4.14%	
	ES   37.8 B (1.34%)                C 119.2 B   3.34%        m	3.40%	
	OR   36.0 B (1.28%)                U  97.3 B   2.73%        k	3.07%	
	TE   34.0 B (1.20%)                M  89.5 B   2.51%        v	2.88%	
	OF   33.1 B (1.17%)                F  85.6 B   2.40%        f	2.27%	
	ED   32.9 B (1.17%)                P  76.1 B   2.14%        h	1.88%	
	IS   31.8 B (1.13%)                G  66.6 B   1.87%        u	1.85%	
	IT   31.7 B (1.12%)                W  59.7 B   1.68%        b	1.41%	
	AL   30.7 B (1.09%)                Y  59.3 B   1.66%        p	1.33%	
	AR   30.3 B (1.07%)                B  52.9 B   1.48%        j	1.11%	
	ST   29.7 B (1.05%)                V  37.5 B   1.05%        å	1.03%
	TO   29.4 B (1.04%)                K  19.3 B   0.54%        æ	0.93%	
	NT   29.4 B (1.04%)                X   8.4 B   0.23%        ø	0.84%	
	NG   26.9 B (0.95%)                J   5.7 B   0.16%        y	0.72%	
	SE   26.3 B (0.93%)                Q   4.3 B   0.12%        c	0.29%	
	HA   26.1 B (0.93%)                Z   3.2 B   0.09%        w	0.02%	
	AS   24.6 B (0.87%)                                         x	0.02%	
	OU   24.5 B (0.87%)                                         z	0.02%	
	IO   23.5 B (0.83%)                                         q	0.01%	
	LE   23.4 B (0.83%)  
	VE   23.3 B (0.83%)  
	CO   22.4 B (0.79%)  
	ME   22.4 B (0.79%)  
	DE   21.6 B (0.76%)  
	HI   21.5 B (0.76%)  
	RI   20.5 B (0.73%)  
	RO   20.5 B (0.73%)  
	IC   19.7 B (0.70%)  
	NE   19.5 B (0.69%)  
	EA   19.4 B (0.69%)  
	RA   19.3 B (0.69%)  
	CE   18.4 B (0.65%)  
	LI   17.6 B (0.62%)  
	CH   16.9 B (0.60%)  
	LL   16.3 B (0.58%)  
	BE   16.2 B (0.58%)  
	MA   15.9 B (0.57%)  
	SI   15.5 B (0.55%)  
	OM   15.4 B (0.55%)  
	UR   15.3 B (0.54%) 
	
	
trigrams
	the 2.699
	ing 1.283
	and 1.224
	ion 0.683
	ent 0.607
	for 0.583
	you 0.565
	tio 0.548
	hat 0.489
	







































with magic key t* -> the

e: 10.510
t: 9.222
a: 8.227
o: 7.881
i: 7.364
n: 7.022
s: 6.637
r: 6.249
l: 4.279
d: 3.754
c: 3.201
h: 3.090
u: 2.983
m: 2.511
f: 2.205
p: 2.170
g: 2.116
y: 1.990
w: 1.861
b: 1.546
.: 1.133
v: 1.107
,: 1.039
k: 0.829
': 0.270
x: 0.223
j: 0.180
q: 0.106
z: 0.100
?: 0.055
!: 0.047
/: 0.029
$: 0.014
%: 0.010
&: 0.010
+: 0.007
*: 0.006
>: 0.005
=: 0.004
#: 0.003
@: 0.002
<: 0.001

	
	
	
	

Training material
-----------------
> write long english sentenses using only letters s,i,n.a,t,h,e,r



> write long english sentenses using only letters s,i,n.a,t,h,e,r, y,k,j, w,m,c,d,b,l,u,o,f,z


* John confidently assured Kimberly that his new custom-made blue car would last many fruitful years.
* The lumberjack with sturdy hands skillfully modified the broken furniture to enhance its robustness.
* The clown's funny performance dazzled the crowd making them burst into laughter and joyful cheers.
* Before dawn, Michael observed the silent forest fully aware of the subtle hum of nature around him.
* On the warm sunny beach, the children joyously built castles while their mothers chatted under colorful umbrellas.
* Liz found herself mesmerized by the stunning artwork displayed in the museum's contemporary hall.
* During the cold winter nights, the old farmhouse creaked ominously but it remained a cozy refuge for the stranded travelers.

	