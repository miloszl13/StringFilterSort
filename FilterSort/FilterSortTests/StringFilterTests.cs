using FilterSort;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilterSortTests
{
    [TestClass]
    public class StringFilterTests
    {
        [TestMethod]
        public void Filter_String_ReturnsFilteredString()
        {
            //Arrange 
            var word = "ssommeradnomwwwordd";
            var expectedResult = "someradnw";
            //Act
            var actualResult = new StringFilter().Filter(word);
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}