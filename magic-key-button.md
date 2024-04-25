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


One interesting impact of magic is that I can fix a lot of bad combos trivially. Like that is all know and knew,


So, I could put k and w on the same finger, if I were so inclined




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

It only declares FC as a bigram, you don't declare FA, AC or anything else. You can type as many vowels + y between the declared FC pair while still keeping the output of the bigram key to C, so you can type FAC, FOC, FEC, FEEC etc.. Which keys are allowed between the bigram letters is defined in the switch case in is_ignore_letter function (this has the A you are looking for).

To be more clear, after pressing F, the next bigram key press will output C. But you can type any number of vowels + y after F and the bigram key will still output C. When you type F it enters the "skip_bigram_mode" which sets the output of the bigram key to C. Iine 114 tells it to not disable the bigram mode when the "ignore letters" are typed.


I've been using it in addition to adaptive keys successfully and just wanted to share incase anyone else finds it useful.

https://github.com/anantoghosh/My-QMK/blob/ananto-lily58/keyboards/lily58/rev1/keymaps/vial/skip_bigrams.c


## Magic key as repeat key
https://www.reddit.com/r/KeyboardLayouts/comments/1cb2v3l/showcasing_my_implementation_of_hybrid_repeat/

i!✨ Over the last month and a half I've been playing with (and settling on) a concept for repeat and magic keys that more evenly distributes workload between the two keys, and improves in-rolling for any layout by ~2.5% at no cost (assuming you use repeat and magic keys)!

This is done by hybridising both keys so that their specific function--repeat or magic--is determined by which hand presses the preceding key. I'll call them the hybrid key for the rest of this post.

USAGE
If the preceding key is on the same hand as the hybrid key, it acts as a repeat key. This creates an inward roll for any letter that must repeat: finger->thumb. Double letters make up ~2.5% of all bigrams, so now instead of being neither an alternate or a roll, they're a much-beloved inward roll.

If the preceding key is from the opposite hand as the hybrid key, it acts as magic, which will look very different from person-to-person.

Personally, I treat magic similarly to combos, where for them to feel worthwhile, they must save time, usually by decreasing the total number of keys being pressed, such as sending multi-character strings or a keyboard shortcut. I didn't find the usual SFB-reducing possibilities of magic to be elegant enough to be worthwhile.

SHOWCASE
Here is a video showcasing the way these work in practice, typing on the Nordrassil layout! https://www.youtube.com/watch?v=P8a-Mzgbl8c

The innermost thumb keys are the hybrid keys, and each use of them in this video is for the repeat functionality only. This hopefully shows that the rhythm gained by this implementation is quite nice and feels very flowy. I found that having my left hand be responsible for all repeats was noticeably taxing, and splitting it between both hands like this solved that, and feels a lot nicer too!

As an aside, my key labelled j is currently set to backspace because I'm currently experimenting with alternate key positions for it (lateral pinky is a bad default, and I was quite fatigued with it on my thumb).

IMPLEMENTATION
My simple implementation is to define two custom alternate repeat keys (one for each hand) and manually define a library of outputs. This is very human-readable and easy to understand and configure, but the initial setup could be a bother. I haven't set up a repository for my keymap on Github, but here's a pastebin copy of my keymap.c, which contains everything you'll need: https://pastebin.com/j0pfKzBR

I will also gladly help anyone with this implementation if they run into issues! 💜

I'm sure the wizards among you can find a way to base their function on matrix positions and actually call repeat or magic case-by-case, and I will leave that possibility in your very capable hands.

CAVEATS
Layouts with a thumb-alpha, such as Maltron or Nordrassil will have to have said alpha as an alternate instead of an in-roll, to avoid the SFB. I've had no issues with this in practice (muscle memory is doing its job), but mentally it's a bother due to inconsistency. Alas, to live is to suffer.

My hybrid keys are set are on opposite off-home thumb keys. They're symmetrically placed and intuitive to read as sisters or equivalents. The hybrid concept may not work so cleanly if your implementation looks more like Magic Sturdy, where repeat is part of the alphas' 10x3.

And that's about it!! I hope at the very least this has been an interesting read! I'd love to hear your thoughts about this concept, and how you use repeat and magic!