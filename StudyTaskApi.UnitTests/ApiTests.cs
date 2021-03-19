using NUnit.Framework;
using System.Collections.Generic;
using StudyTaskApi.Business.Services;
using FluentAssertions;

namespace StudyTaskApi.UnitTests
{
    [TestFixture]
    public class ApiTests
    {
        private SetGeneratorService _setGeneratorService;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        Dictionary<char, int> expectedCounts = new Dictionary<char, int>();
        List<string> strings = new List<string>()
            { "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" };
        [SetUp]
        public void SetUp()
        {
            foreach (char ch in alphabet)
            {
                expectedCounts.Add(ch, 2);
            }
        }
        [Test]
        public void CountCharactersTest()
        {
            _setGeneratorService.CountCharacters(strings).Should().BeEquivalentTo(expectedCounts);
        }
    }
}
