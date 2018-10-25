using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab4.Controllers;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var controller = new HomeController();
        var result = controller.Details(2) as ViewResult;
        //Asert.AreEqual(result.Model, result.Model);
        Assert.IsNotNull(result);
        }
}
