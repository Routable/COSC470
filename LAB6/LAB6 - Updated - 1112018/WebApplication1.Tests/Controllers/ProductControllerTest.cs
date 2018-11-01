using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication1.Controllers;
using WebApplication1.Models;

namespace WebApplication1.Tests.Controllers
{
    public class ProductControllerTest
    {

        [TestMethod]
        public void Products()
        {
            // Arrange
            ProductController controller = new ProductController();

            // Act
            List<Products> result = controller.GetProductList();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
