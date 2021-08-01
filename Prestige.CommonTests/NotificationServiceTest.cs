using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Common;

namespace Prestige.CommonTests
{
    [TestClass]
    public class NotificationServiceTest
    {
        [TestMethod]
        public void TestNotifyTalent()
        { 
            //Arrange
            var expected = "Notifying talent: Test";
            //Act
            string actual = NotificationService.NotifyTalent("Test");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
