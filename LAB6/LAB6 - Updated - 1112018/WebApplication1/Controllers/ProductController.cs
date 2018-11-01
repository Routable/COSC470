using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public List<Products> GetProductList()
        {
            List<Products> productList = new List<Products>();

            productList.Add(new Models.Products()
            {
                id = 1,
                name = "Apple Juice",
                cost = 1.00
            });

            productList.Add(new Models.Products()
            {
                id = 2,
                name = "Pear Juice",
                cost = 2.20
            });

            productList.Add(new Models.Products()
            {
                id = 2,
                name = "Orange Juice",
                cost = 3.10
            });

            return productList;
        }

        public ActionResult Products()
        {
            var products = from e in GetProductList()
                           orderby e.id
                           select e;

            return View(products);
        }
    }
}