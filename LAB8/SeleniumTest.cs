using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumLab
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://blog.testproject.io/";
            IWebElement element = driver.FindElement(By.LinkText("Contact Us"));
            element.Click();

            IWebElement element2 = driver.FindElement(By.Name("your-name"));
            element2.SendKeys("Steven");

            IWebElement element3 = driver.FindElement(By.Name("your-email"));
            element3.SendKeys("Steven@gmail.com");

            IWebElement element4 = driver.FindElement(By.Name("your-subject"));
            element4.SendKeys("hello");

            driver.FindElement(By.XPath("//input[@value='Send']")).Submit();


            driver.Close();
        }
    }
}
