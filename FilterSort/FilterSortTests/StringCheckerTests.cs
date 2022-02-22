
using FilterSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilterSortTests
{
    [TestClass]
    public class StringCheckerTests
    {
        [TestMethod]
        public void GetResult_UserInputA_CallsCharacterRepetitionCounterMethodCount()
        {
            //Arrange
            var userInput = "eeexxammplee";
            var choosenMethod = "a";
            var expectedResult = new CharachterRepetitionCounter().Count(userInput);
            //Act
            var actualResult = new StringChecker().GetResult(choosenMethod, userInput);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetResult_UserInputB_CallsCharacterRepetitionCounterMethodCount()
        {
            //Arrange
            var userInput = "eeexxammplee";
            var choosenMethod = "b";
            var expectedResult = new StringFilter().Filter(userInput);
            //Act
            var actualResult = new StringChecker().GetResult(choosenMethod, userInput);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void GetResult_UserInputAnythingButAandB_ReturnsErrorMessage()
        {
            //Arrange
            var userInput = "eeexxammplee";
            var choosenMethod = "something";
            var expectedResult = "You didn't choose the method well!";
            //Act
            var actualResult = new StringChecker().GetResult(choosenMethod, userInput);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}