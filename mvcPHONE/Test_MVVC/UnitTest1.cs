using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_MVC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestControllerExistePhoneExists()
        {
            var controller = new apiPhone.Controllers.PhonesController();

            bool response = controller.PhoneExists(-1);

            Assert.AreEqual(false, response);
        }
    }
}
