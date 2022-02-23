
using FilterSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilterSortTests
{
    [TestClass]
    public class CharacterRepetitionCounterTests
    {
        [TestMethod]
        public void Count_String_ReturnsStringWithCountedCharacterRepetition()
        {
            //Arrange
            var word = "sssoomerrrraandddommword";
            var expectedResult = "s3o4m3e1r5a2n1d4w1";
            //Act
            var actualResult = new CharachterRepetitionCounter().Count(word);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}