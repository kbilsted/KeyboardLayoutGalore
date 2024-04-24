using FluentAssertions;
using KeyboardAnalyzer;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {
        string subset = @"The ability to adjust to different environments, unexpected changes, people and circumstances is highly important for your personal growth and success. Thanks to a high level of adaptability, leaders stay strong, relevant and optimistic during hard times. These hard times including periods of failure, financial problems, family or work issues, and bankruptcy.
Regardless of the situation, leaders aim to shape their new environments and turn their failures into opportunities. If you're unwilling to adapt to something new, here are a few baby steps to- try- in order to become more adaptable in life.
What do you do when something terrible happens? Say, I'll handle it,or God, it's the end of the world and my life '?
Majority of people start whining as soon as they find themselves in a difficult situation. It's normal but this reaction leads to nowhere.
If you're one of, learn to accept the situation, adapt to it and move on.
Eliminate wrongbeliefs from your life. We used to believe that many things are wrongand must be avoided, but it's not the case if you want to be successful.
Be bold enough to try things that others run away from. This trait has helped many successful people build companies, corporations, and fortune.
The way you deal with personal and professional setbacks may significantly affect your future success. Discover your coping mechanism and consider changing some aspects of it.
If you usually switch strategies to overcome various life challenges, try to forge ahead";

       

        [Test]
        public void TestNGramBi()
        {
            var bigrams = new Corpus().GetNgrams(subset,2);
            bigrams.Count().Should().Be(256);
            bigrams["ng"].Count.Should().Be(16);
            bigrams["al"].Count.Should().Be(8);
        }

        [Test]
        public void TestNGramTri()
        {
            var bigrams = new Corpus().GetNgrams(subset, 3);
            bigrams["nal"].Count.Should().Be(3);
        }


        [Test]
        public void TestNGram()
        {
            var bigrams = new Corpus().GetNgrams(subset, 2);

            bigrams.Count().Should().Be(256);
            bigrams["ng"].Count.Should().Be(16);
            bigrams["al"].Count.Should().Be(8);
        }


        [Test]
        public void Test()
        {
            var bigrams = new Corpus().GetNgrams("ababac ", 2);

            bigrams.Count().Should().Be(3);
            bigrams["ab"].Count.Should().Be(2);
        }


        [Test]
        public void Test2()
        {
            var bigrams = new Corpus().GetNgrams("ab  ab ac ", 2);

            bigrams.Count().Should().Be(2);
            bigrams["ab"].Count.Should().Be(2);
        }
    }
}