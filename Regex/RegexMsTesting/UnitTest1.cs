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
        [TestMethod]
        public void Validating_Lastname()
        {
            //Arrange
            string lastname = "Kamble";
            person = new Validation();

            //Act
            string expected = "Kamble";
            string actual = person.ValidateLastName(lastname);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validating_EmailID()
        {
            //Arrange
            string Email_ID = "kundan@gmail.com";
            person = new Validation();

            //Act
            string expected = "kundan@gmail.com";
            string actual = person.EmailID(Email_ID);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validating_PhoneNumber()
        {
            //Arrange
            string phonenumber = "91 1234567890";
            person = new Validation();

            //Act
            string expected = "91 1234567890";
            string actual = person.Phonenumber(phonenumber);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Validating_Password()
        {
            //Arrange
            string password = "kundank@#$1234";
            person = new Validation();

            //Act
            string expected = "Kundank@#$1234";
            string actual = person.Password(password);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}