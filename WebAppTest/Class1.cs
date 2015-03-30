using FirstMVCProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Xunit;

namespace WebAppTest
{
    public class Class1
    {
        [Fact]

        public void SomeTest()
        {
            var homeController = new HomeController();
            var viewController = homeController.About();
            var theView = (ViewResult)viewController;
            Assert.NotNull(theView);
        }

    }
}
