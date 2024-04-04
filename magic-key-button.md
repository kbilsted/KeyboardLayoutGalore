# Magic Key button
Unedited notes from discussions on the "Alt keyboard layouts" discord 


    // th
    ␣☆      ⇒ th
    ␣☆␣     ⇒ the␣
    ␣☆✪     ⇒ them
    ␣☆y     ⇒ they

    // SFBs
    u☆      ⇒ ue
    e☆      ⇒ eu
    o☆      ⇒ oa
    a☆      ⇒ ao
    s☆      ⇒ sc
    c☆      ⇒ cs
    r☆      ⇒ rl
    g☆      ⇒ gs
    w☆      ⇒ ws
    p☆      ⇒ pt

    // Scissors
    h✪      ⇒ ho
    b☆      ⇒ bl
    l☆      ⇒ lp
    ␣p☆     ⇒ pl

    // Common ngrams
    k✪      ⇒ king
    k☆      ⇒ ked
    i✪      ⇒ ion
    i☆      ⇒ ious
    y✪      ⇒ ying
    v✪      ⇒ ving
    v☆      ⇒ ver
    q☆      ⇒ qu
    z☆      ⇒ zone
    z✪      ⇒ zation
    t☆      ⇒ tch

    // t☆ overrides
    nt☆     ⇒ ntment
    rt☆     ⇒ rtment
    st☆     ⇒ stment
    eat☆    ⇒ eatment
    uit☆    ⇒ uitment
    mit☆    ⇒ mitment

    ☆ is magic key, ✪ is repeat key, which I have on thumb. (edited)





Oh, one other cool trick I added that shows off the effortless power of sequence-transform:

    ⎵n      ⇒ the
    ⎵n👆     ⇒ then
    ⎵nr⎵     ⇒ there◯
    ⎵nor     ⇒ thorough
    ⎵n👍     ⇒ through
    ...

    ⎵👆           ⇒ n
    ⎵👆👍         ⇒ not
    ⎵👆👍v        ⇒ never
    ⎵👆👍t        ⇒ nation
    ⎵👆👍d        ⇒ need
    ...

What that accomplishes is swapping the n and magic1 keys after wordbreaks


In Magic Sturdy (as opposed to @Guillaume is typing... 's layout), n is more common than magic1, except on the first key after a wordbreak.
So, I use rules to effectively swap them after a wordbreak


What I love about the conditional key swapping feature is that it's a super powerful feature in its own right, and I was able to accomplish it by total accident in about 2 minutes without needing to add any feature to the library.
Autocorrect, leader keys, repeat key, macros, many more features are all covered.

Earlier someone was asking about delaying output to remove the need to have rules use backspaces. That is also now available:

    ⎵s👍         ⇒ s
    ⎵s👍∀        ⇒ some◯
    ⎵s👍t        ⇒ sometimes
    ⎵s👍g        ⇒ something
    ⎵s👍h        ⇒ somehow
    ⎵s👍w        ⇒ somewhere
    ⎵s👍y        ⇒ system


The some rule will only output ome after you hit another key that doesn't trigger a different rule`

So, after typing _s@ I still only see s, then, if i type anything that isn't t, g, h, w, or y (etc. for other rules), it completes with ome
So, _s@y doesn't need to backspace over ome, it just outputs ystem


Yeah, hitting the thumb key after _s doesn't output anything. It isn't strictly better than preemptively outputting stuff that might need to be backspaced later, but it definitely is in some cases. Like, the delay on some is good, but I still have 
    j@d -> judge
    j@dt -> judgment
    for instance

And all the verbs that end in e get output right away, even though following them with g does a backspace plus ing



Most users gravitate towards having two magic keys. One on the vowel hand index and the other on the non-space thumb.


The index magic key does most of the sfb / scissor elimination, and the thumb magic key defaults to repeat but it's also used heavily for word completions


## Magic keys with Bigrams

[BUV]
Hi all, I had implemented this feature to optimize skip bigram typing since I had trouble with the increased distance my left hand fingers had to travel between rows with neu. This lets you type skip bigrams with a "bigram key". So for e.g., in MNL stack, typing
    M > BIGRAM_KEY will type ML.
    M > A > BIGRAM_KEY will type MAL.
    M > E > A > BIGRAM_KEY will type MEAL.
    M > A > BIGRAM_KEY > BIGRAM_KEY will type MALL.

Similarly for FSC column
    F > A > BIGRAM_KEY > T will type FACT.
    etc.


This is not time based.
I've been using it in addition to adaptive keys successfully and just wanted to share incase anyone else finds it useful.

https://github.com/anantoghosh/My-QMK/blob/ananto-lily58/keyboards/lily58/rev1/keymaps/vial/skip_bigrams.c