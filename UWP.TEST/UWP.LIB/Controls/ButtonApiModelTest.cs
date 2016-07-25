using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using UWP.LIB.Controls.Button;

namespace UWP.TEST.UWP.LIB.Controls
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreation()
        {
            ButtonApiModel model = new ButtonApiModel();
        }

        [TestMethod]
        public void TestCanClickDefault()
        {
            ButtonApiModel model = new ButtonApiModel();
            Assert.AreEqual(true,model.CanClick);
        }

        [TestMethod]
        public void TestClick()
        {
            ButtonApiModel model = new ButtonApiModel();
            model.Click();
        }
    }
}
