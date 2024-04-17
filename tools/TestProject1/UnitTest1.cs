using FluentAssertions;
using KeyboardAnalyzer;
using NUnit.Framework;

namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void Test()
        {
            var bigrams = new Corpus().GetBigrams("ababac ");

            bigrams.Count().Should().Be(3);
            bigrams["ab"].Count.Should().Be(2);
        }


        [Test]
        public void Test2()
        {
            var bigrams = new Corpus().GetBigrams("ab  ab ac ");

            bigrams.Count().Should().Be(2);
            bigrams["ab"].Count.Should().Be(2);
        }
    }
}