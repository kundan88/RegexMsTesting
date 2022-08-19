using Microsoft.VisualStudio.TestTools.UnitTesting;

using RegexPattern;

namespace UnitTest1
{
    [TestClass]
    public class Tests
    {
        Validation person;
        [TestMethod]
        public void Setup()
        {
            person = new Validation();
        }

        [TestMethod]
        public void Validating_Firstname()
        {
            //Arrange
            string firstname = "Kundan";
            person = new Validation();

            //Act
            string expected = "Kundan";
            string actual = person.ValidateFirstName(firstname);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}