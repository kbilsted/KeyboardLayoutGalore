
begining - optimize for RE TH IN IS (w,j,b,z,x from HD)
	wpoum  'lydkz
	anisb  'rethj
	xcf;,  /q.gv-


reduce pinky (anis -> sina)
	wpoum  'lydkz
	sinab  'rethj
	xcf;,  /q.gv-


reduce strain right index (ly -> yl)
	wpoum  'yldkz
	sinab  'rethj
	xcf;,  /q.gv-


reduce pinky (reth -> ethr)
	wpoum  'yldkz
	sinab  'ethrj
	xcf;,  /q.gv-


reduce lowrow and weird scisors with f and make bigram OF same row! 
(swap f<->k)
	wpoum  'yldfz
	sinab  'ethrj
	xck;,  /q.gv-



remove SFB O-N 1.76%   vs  I-N (2.43%)  vs A-N (1.99%)
(WPOUM -> WOUMP)
	woump  'yldfz
	sinab  'ethrj
	xck;,  /q.gv-


Too much trampolining with R on pinky.. we put R it there to reduce pinky but broke ER (2.05%)
support TH + HE + ER  and same row for AL (1.09) + LE (0.83) + LI (0.62)
(swap R<->L)
	woump  'yrdfz
	sinab  'ehtlj
	xck;,  /q.gv-


remove weird gymnastics of c key (C<->V)
	woump  'yrdfz
	sinab  'ehtlj
	xvk;,  /q.gc-


Less trambolining with TH-E (EHT -> THE)
	woump  'yrdfz
	sinab  'thelj
	xvk;,  /q.gc-


more bigram by moving r to pinky again
(swap R<->L)
	woump  'yldfz
	sinab  'therj
	xvk;,  /q.gc-


Move OU to stronger hand (7.6%+2.73%)
(swap OU<->LD)
	wldmp  'youfz
	sinab  'therj
	xvk;,  /q.gc-


Improve SFB for ND (1.35% ) + MA (0.57%)
(SWAP D<->Mb
	wlmdp  'youfz
	sinab  'therj
	xvk;,  /q.gc-


more rolling but with more finger movements
then we swap B-P since P is more frequent 
(SWAP D<->B<->P)
	wlmpb  'youfz
	sinad  'therj
	xvk;,  /q.gc-


remove lateral stress 
move D<->K
	wlmpb  'youfz
	sinak  'therj
	xvd;,  /q.gc-

make more like HD
(L<->F)

	wfmpb  'youlz
	sinak  'therj
	xvd;,  /q.gc-

optimize ND (1.56%) and place D on a stronger finger
(D<->Q)
	wfmpb  'youlz
	sinak  'therj
	xvq;,  /d.gc-


optimize and place V (1.05%) on a stronger finger Q (0.12)
(D<->Q)
	wfmpb  'youlz
	sinak  'therj
	xqv;,  /d.gc-



more rolls with g on homerow - but yields more SFB
('<->G)
	wfmpb  'youlz
	sinak  gtherj
	xqv;,  /d.*c-
	
	

more rolls with V on top (5 more bigrams but 0.1% SFB)
(V<->B) .. but i remember not liking V up here.. lets try for a bit..
	wfmpv  'youlz
	sinak  gtherj
	xqb;,  /d.*c-
	

Can we reverse the "THER" to "REHT" and get a better result? 
T is 9,28% and R is 6.28% so we would increase pinky by 3%!


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



more movement for index--but many more bigrams.. lets evaluate

	jcmpb  'luofz
	sinad  gtherw
	xqy.,  -kv./*";

!!! Didn't like it ! Too much index Going back!


old layout again

	jcmpb  'luofz
	sinag  ytherw
	xqd.-  ,kv./*


support 3rd most trigram "AND" (1.2%) for 3 fingers rather than 2 fingers
.. and place C as qwerty
and improve SFB
and make other words easier eg "AD" (0.5%) 
(C<->D)
	jdmpb  'luofz
	sinag  ytherw
	xqc.-  ,kv./*


support 5th trigram "FOR" (0.6%) better 
and DIRECT 7th trigram "YOU" (0.6%) 
"ly","by" also much easier to type
and improve SFB
(F<->Y)

	jdmpb  'luoyz
	sinag  ftherw
	xqc.-  ,kv./*


miniscule improvement and make it look more like qwerty
(X<->Z)

	jdmpb  'luoyx
	sinag  ftherw
	zqc.-  ,kv./*



slightly worse.. but want to move C to top due to it being more frequent
hurts "AC" (1%), 
improves "OC" (0.8%), "CU" (0.3%), "NC (0.3%) easier
move "V" since the spot is much easier to reach on a stagered keyboard

(C<->P)
(V<->.) costs 1% SFB! but so easier to hit
	jdmcb  'luoyx
	sinag  ftherw
	zqp,-  .k.v/*


(Z<->X) feels more natural 
	jdmcb  'luoyz
	sinag  ftherw
	xqp,-  .k.v/*


improve rolls by 0.6%
(P<->K)
Tempting to swap Y-W but it yields more sfb, breaks the trigram and reduces bigrams

	jdmcb  'luoyz
	sinag  ftherw
	xqk,-  .p.v/*

wonderful change! much better rolls!
eg "thanks", "pasted" "stops", "key" 


---

change upperrow for more bigrams ".?(q|v|k|p|x|j|f|g|w|l|b|j|c)

p
-- right
pe = 0.61M
pr = 0.46M
pt = 0.09M
ph = 0.08M
--left
sp = 0.25M
pa = 0.51M
> home=2.0
pl = 0.35M
po = 0.55M
up = 0.26M
>upperrow=1.16

b
be = 0.62M
ab = 0.44M
bo = 0.32M
bu = 0.30M
bi = 0.19M
br = 0.14M
homerow=1.68
bl = 0.23M
by = 0.13M
mb = 0.09M
upper=0.45

f
of = 0.802M, 1.34M
>move f to upper
fi =0.53M
fe =0.38M
> homerow=0.9

l
al =1.50M
le =1.41M
li =1.15M
> homerow=4.06
ol = 0.78M
ly = 0.45M
ul = 0.44M
ld = 0.29M
> upper=1.95
pl = 0.316M, 0.35M

c
new ("ca", 0.572M, 1.03M),
new ("ec", 0.449M, 1.03M),
new ("ic", 0.589M, 0.81M),
new ("ch", 0.551M, 0.55M),
new ("ct", 0.383M, 0.43M),
new ("nc", 0.341M, 0.34M),
new ("cr", 0.160M, 0.26M),
> homerow 4.4 - 1.1 = 3.3
new ("uc", 0.163M, 0.31M),
new ("co", 0.749M, 0.89M),


g
ng = 1.23M
ge = 0.52M
ig = 0.42M
ag = 0.36M
gr = 0.27M
go = 0.26M
>homerow=3.06

w
ow = 0.64M
we = 0.52M
wi = 0.48M
wa = 0.45M
wh = 0.37M
> homerow=2.46
 
v
ve = 1.17M
vi = 0.54M
av = 0.37M
ov = 0.26M
>homerow=2.34
v to homerow (v=1.05% vs W 1.68% - reduce pinky by putting W on index on V on pinky
but more inroll with V on index..

k
ke = 0.327M, 0.36M
> K so low frequency we leave it


y
new ("yo", 0.461M, 0.50M),
new ("ly", 0.428M, 0.45M),
> upper 0.95
new ("ay", 0.309M, 0.33M),
new ("ey", 0.169M, 0.30M),
new ("ry", 0.235M, 0.24M),
new ("ty", 0.200M, 0.22M),
new ("ys", 0.109M, 0.16M),
new ("ny", 0.124M, 0.14M),
> home 1.39

upperrow P,B, L, - more pinky! but better than dvorak
homerow  C, G, W ,
low k, x,v, f
(P<->C) - this is the best position as "Y" only rolls with YO/LY
(C<->F) - this possition supports "CA/CT"
(K<->K) - we swapsince "FO" is 1.34% while next bigram is FI 0.53% - so we avoid the scissors FO
	jdmpb  'luoyz
	sinag  ctherw
	xqf,-  .k.v/*






(J<->Z)
(Z<->X) swap so Z bigrams (IZ 0.08%, ZE 0.06%) are a bit easier to type
(Q<->X) swap so we place keys more like QWERTY
	qdmpb  'luoyj
	sinag  ctherw
	zxf,-  .k.v/*













--> old 

Going through an analyser we can increase right hand usage from 41% to 46%

(D<->F  to move work to other finger - works really nice-- words like "would", "should")

https://cyanophage.github.io/magic.html?layout=wmcdb%27luoyzsinagktherjxqp%2F%3B-fv.%2C%5C%5E&mode=ergo

sfb 2.50 roll out 7,55 roll in 3,88

	wdmpb  'luoyz
	sinag  ktherj
	xqc.,  -fv./*



PERHAPS!!!! C to top!
2.80, out 7,26 in 3,68
	wdmcb  'luoyz
	sinag  ktherj
	xqp.,  -fv./*

OR
(DMP<->MCD) Moving around due to begger SFB (2.44% vs 2.74)
(P<->C) Moving C up due to being more frequent
2.54, out 6.26, in 4.00
	wmcdb  'luoyz
	sinag  ktherj
	xqp.,  -fv./*


OR 
(Y<->G) moving Y to put G on a better spot
(F<->G) moving F up due to being more frequent
(P<->C) Moving C up due to being more frequent
(DMP<->MCD) Moving around due to begger SFB (2.44% vs 2.74)
sfb 2,59, out 5.25, in 2,35
	wmcdb  'luofz
	sinay  ktherj
	xqp.,  -gv./*






MAGIC BUTTON configuration
	L* -> LF
	I* -> IC



	I* -> ID  (we use that in programming alot!)
	Q* -> QUE
	E* -> EY
	B* -> BA
	D* -> DI
	
	W* -> WI
	R* -> RY
	S* -> SC
	O* -> OF
	N* -> NC
    SPACE* -> <Backspace> ',' <Space>
	A* -> AB (more common than AG)






stats https://norvig.com/mayzner.html

	BI  COUNT   PERCENT graph     LETTER  COUNT   PERCENT
	TH  100.3 B (3.56%)                E 445.2 B  12.49%         
	HE   86.7 B (3.07%)                T 330.5 B   9.28% 
	IN   68.6 B (2.43%)                A 286.5 B   8.04% 
	ER   57.8 B (2.05%)                O 272.3 B   7.64% 
	AN   56.0 B (1.99%)                I 269.7 B   7.57% 
	RE   52.3 B (1.85%)                N 257.8 B   7.23% 
	ON   49.6 B (1.76%)                S 232.1 B   6.51% 
	AT   41.9 B (1.49%)                R 223.8 B   6.28% 
	EN   41.0 B (1.45%)                H 180.1 B   5.05% 
	ND   38.1 B (1.35%)                L 145.0 B   4.07% 
	TI   37.9 B (1.34%)                D 136.0 B   3.82% 
	ES   37.8 B (1.34%)                C 119.2 B   3.34% 
	OR   36.0 B (1.28%)                U  97.3 B   2.73% 
	TE   34.0 B (1.20%)                M  89.5 B   2.51% 
	OF   33.1 B (1.17%)                F  85.6 B   2.40% 
	ED   32.9 B (1.17%)                P  76.1 B   2.14% 
	IS   31.8 B (1.13%)                G  66.6 B   1.87% 
	IT   31.7 B (1.12%)                W  59.7 B   1.68% 
	AL   30.7 B (1.09%)                Y  59.3 B   1.66% 
	AR   30.3 B (1.07%)                B  52.9 B   1.48% 
	ST   29.7 B (1.05%)                V  37.5 B   1.05% 
	TO   29.4 B (1.04%)                K  19.3 B   0.54% 
	NT   29.4 B (1.04%)                X   8.4 B   0.23% 
	NG   26.9 B (0.95%)                J   5.7 B   0.16% 
	SE   26.3 B (0.93%)                Q   4.3 B   0.12% 
	HA   26.1 B (0.93%)                Z   3.2 B   0.09% 
	AS   24.6 B (0.87%)  
	OU   24.5 B (0.87%)  
	IO   23.5 B (0.83%)  
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

* She has three thin shirts in her neat suitcase.
* He is near the stairs, listening as the rain intensifies.
* There is an ant here, and it insists on entering the tent.
* The rain is intense as it thrashes against the earth.
* She enters the train, then she sits there, staring at her hands.
* He rinses his shirt near the stream, then hangs it in the sunshine.
* Tina has an interest in art; she paints rather intense scenes at night.

> write long english sentenses using only letters s,i,n,a,t,h,e,r, y,k,j,
* There, in the kitchen, Jenny hastily jerks the shiny jar, as it strikes another.
* Katherine enjoys her tiny, shiny kayak near the jetty as the sun rises.
* He thinks the rainy sky threatens his journey as he treks near the stark hills.
* She just takes her knitting yarn, starts knitting, then enjoys her tea by the hearth.
* The risky journey near the stark, rainy highlands tests her anxiety.
* Jenny and Katherine share their interest in arts, yarn, and shiny trinkets.
* The jester’s antics in the throne room entertain the harsh, stern king.



> write long english sentenses using only letters s,i,n.a,t,h,e,r, y,k,j, w,m,c,d,b,l,u,o,f,z


* John confidently assured Kimberly that his new custom-made blue car would last many fruitful years.
* The lumberjack with sturdy hands skillfully modified the broken furniture to enhance its robustness.
* The clown's funny performance dazzled the crowd making them burst into laughter and joyful cheers.
* Before dawn, Michael observed the silent forest fully aware of the subtle hum of nature around him.
* On the warm sunny beach, the children joyously built castles while their mothers chatted under colorful umbrellas.
* Liz found herself mesmerized by the stunning artwork displayed in the museum's contemporary hall.
* During the cold winter nights, the old farmhouse creaked ominously but it remained a cozy refuge for the stranded travelers.

	