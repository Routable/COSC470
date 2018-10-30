using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4.Controllers;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using Lab4.Models;

namespace Lab4.Controllers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Product> prodlist;
            ProductListController pd = new ProductListController();
            prodlist = pd.GetProductList2();

            Assert.IsNotNull(prodlist);
        }
    }
}

