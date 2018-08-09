using Microsoft.VisualStudio.TestTools.UnitTesting;
using WithoutDI.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Entities;

namespace WithoutDI.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void Index_Should_Return_List_Of_Items()
        {
            //Arrange
            HomeController controller = new HomeController();
            //Act
            var result = controller.Index() as ViewResult;
            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Item>));


        }
    }
}