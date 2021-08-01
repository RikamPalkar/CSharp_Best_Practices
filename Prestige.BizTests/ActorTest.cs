using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz.Console;

namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        /// <summary>
        /// Tests if occupation is an Actor
        /// </summary>
        [TestMethod]
        public void TestGetOccupation()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "Actor";
            //Act
            string result = currentActor.GetOccupation();
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Testing parameterized constructor for an Actor
        /// </summary>
        [TestMethod]
        public void TestParameterizedConstructor()
        {
            //Arrange
            var currentActor = new Actor("Rikam");
            var expected = "Rikam";
            //Act
            string result = currentActor.ActorName;
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Testing method overloading
        /// </summary>
        [TestMethod]
        public void TestMethodChaningAndOverloading()
        {
            //Arrange
            var currentActor = new Actor("Rikam");
            var expected = string.Empty;
            //Act
            string result = currentActor.BookActor();
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Failed method demo as Actor name should be greater than 3 for Property's Validating incoming value  
        /// </summary>
        [TestMethod]
        public void TestFormattingOnSetterForBookActorFailTest()
        {
            //Arrange
            var currentActor = new Actor("Ri");
            bool expected = true;
            //Act
            bool result = currentActor.CheckIfActorIsAvailable(currentActor);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Pass method demo where Actor name is greater than 3 for Property's Validating incoming value  
        /// </summary>
        [TestMethod]
        public void TestFormattingOnSetterForBookActorPassTest()
        {
            //Arrange
            var currentActor = new Actor("Rikam");
            bool expected = true;
            //Act
            bool result = currentActor.CheckIfActorIsAvailable(currentActor);
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Testing of Auto property : ActorDescription
        /// </summary>
        [TestMethod]
        public void TestAutoPropActorDescription()
        {
            //Arrange
            var currentActor = new Actor { ActorName = "Alex"};
            var expected = "Regular Actor";
            //Act
            string result = currentActor.ActorDesciption;
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Testing of Auto property : ActorAge
        /// </summary>
        [TestMethod]
        public void TestAutoPropInitActorAge()
        {
            //Arrange
            var currentActor = new Actor { ActorName = "Alex", ActorAge = 22 };
            var expected = 22;
            //Act
            int result = currentActor.ActorAge;
            //Assert
            Assert.AreEqual(expected, result);
        }


        /// <summary>
        /// Testing of Object Property
        /// </summary>
        [TestMethod]
        public void TestSettingObjectProperty()
        {
            //Arrange
            var currentActor = new Actor();
            currentActor.ActorName = "Rikam";
            currentActor.ActorAge = 22;
            var expected = 22;
            //Act
            int result = currentActor.ActorAge;
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Testing of getting an agency's name of an Actor
        /// </summary>
        [TestMethod]
        public void TestGetAgency()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "Prestige Talent";
            //Act
            string result = currentActor.GetAgencyName();
            //Assert
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Testing of getting an agency's name of an Actor with Agency as an property
        /// </summary>
        [TestMethod]
        public void TestGetAgencyWithProperty()
        {
            //Arrange
            var currentActor = new Actor();
            var expected = "Prestige Talent";
            //Act
            string result = currentActor.GetAgencyName();
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
