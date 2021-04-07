using NUnit.Framework;
using System.Collections.Generic;
using StudyTaskApi.Business.Services;
using FluentAssertions;

namespace StudyTaskApi.UnitTests
{
    [TestFixture]
    public class CountServiceTests
    {
        private CountService _countService;
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        Dictionary<char, int> expectedCounts = new Dictionary<char, int>();
        List<string> expectedSet = new List<string>()
            { "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" };
        [SetUp]
        public void SetUp()
        {
            _countService = new CountService();
            foreach (char ch in alphabet)
            {
                expectedCounts.Add(ch, 2);
            }
        }

        [Test]
        public void CountCharactersShouldReturnExpectedDictionary()
        {
            _countService.CountCharacters(expectedSet, alphabet).Should().BeEquivalentTo(expectedCounts);
        }
    }
}
