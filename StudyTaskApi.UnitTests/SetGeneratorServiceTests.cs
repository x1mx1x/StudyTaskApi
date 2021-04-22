using FluentAssertions;
using NUnit.Framework;
using StudyTaskApi.Business.Services;

namespace StudyTaskApi.UnitTests
{
    [TestFixture]
    public class SetGeneratorServiceTests
    {
        [Test]
        public void GenerateSetShouldReturnSetWithLength52Cardinality2()
        {
            //arrange
            SetGeneratorService _setGeneratorService = new SetGeneratorService();
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            int cardinality = 2, length = 52;

            //act
            var set = _setGeneratorService.GenerateSet(cardinality, length, alphabet);

            //assert
            foreach (var str in set)
            {
                str.Length.Should().Be(length);
            }
            set.Count.Should().Be(cardinality);
        }
    }
}
