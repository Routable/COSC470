using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace LAB9
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Url = "https://www.mail.com/int/";
            IWebElement element = driver.FindElement(By.Id("login-button"));
            element.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement element2 = driver.FindElement(By.Name("username"));
            element2.SendKeys("cosc470@mail.com");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            IWebElement element3 = driver.FindElement(By.Name("password"));
            element3.SendKeys("P@ssw0rd!");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.ClassName("login-submit")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.SwitchTo().Frame("thirdPartyFrame_home");
            driver.FindElement(By.PartialLinkText("Compose E-mail")).Click();
            System.Threading.Thread.Sleep(5000);
            driver.SwitchTo().DefaultContent();
            System.Threading.Thread.Sleep(5000);
            driver.SwitchTo().Frame("thirdPartyFrame_mail");
            IWebElement element5 = driver.FindElement(By.ClassName("select2-input"));
            element5.SendKeys("Whatever2@gmail.com");
            IWebElement element6 = driver.FindElement(By.Id("id58"));
            element6.SendKeys("Whatever3");
            IWebElement element7 = driver.FindElement(By.Id("id20"));
            element7.Click();
        }
    }
}
