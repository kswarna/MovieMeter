using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectManhattan;
using ProjectManhattan.Controllers;

namespace ProjectManhattan.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            AboutController controller = new AboutController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
