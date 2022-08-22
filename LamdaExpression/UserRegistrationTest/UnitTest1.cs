using LambdaUserRegistration;

namespace UserRegistrationTest
{
    public class Tests
    {
        UserRegistrationDetails user;
        [SetUp]
        public void Setup()
        {
            user = new UserRegistrationDetails();
        }

        [Test]
        public void FirstName()
        {
            // Arrange 
            bool expected = true;
            string name = "Madhu";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Shivakumar";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateLastName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Email()
        {
            // Arrange 
            bool expected = true;
            string email = "madhums41175@gmail.com";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void MobileNumber()
        {
            // Arrange 
            bool expected = true;
            string mobile = "91 9632355684";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateMobileNumber(mobile);

            // Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Password()
        {
            // Arrange 
            bool expected = true;
            string password = "madhumS4@";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void EmailTest()
        {
            string EMail1 = "abc@gamil.com";
            string EMail2 = "abc.bcd@gmail.com";
            string EMail3 = "abc.bdc100@gmail.com";
            string EMail4 = "abc.ghj111@gmail.com";
            string EMail5 = "abc.efgh@gmail.com";
            bool result1 = user.ValidateEmail(EMail1);
            bool result2 = user.ValidateEmail(EMail2);
            bool result3 = user.ValidateEmail(EMail3);
            bool result4 = user.ValidateEmail(EMail4);
            bool result5 = user.ValidateEmail(EMail5);
            Assert.AreEqual(true, result1);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
        }

    }
}