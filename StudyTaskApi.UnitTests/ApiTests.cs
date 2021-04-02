using NUnit.Framework;
using System.Collections.Generic;
using StudyTaskApi.Business.Services;
using FluentAssertions;

namespace StudyTaskApi.UnitTests
{
    [TestFixture]
    public class ApiTests
    {
        private CountService _countService;
        private SetGeneratorService _setGeneratorService;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        int cardinality = 2, length = 52;
        Dictionary<char, int> expectedCounts = new Dictionary<char, int>();
        List<string> expectedSet = new List<string>()
            { "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" };
        [SetUp]
        public void SetUp()
        {
            _countService = new CountService();
            _setGeneratorService = new SetGeneratorService();
            foreach (char ch in alphabet)
            {
                expectedCounts.Add(ch, 2);
            }
        }

        [Test]
        public void CountCharactersTest()
        {
            _countService.CountCharacters(expectedSet, alphabet).Should().BeEquivalentTo(expectedCounts);
        }

        [Test]
        public void GenerateSetTest() 
        {
            var set = _setGeneratorService.GenerateSet(cardinality, length, alphabet);
            foreach (var str in set) 
            {
                str.Length.Should().Be(length);
            }
            set.Count.Should().Be(cardinality);
        }
    }
}
