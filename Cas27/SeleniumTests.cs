using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace Cas27
{
    class SeleniumTests
    {
        IWebDriver driver;

        [SetUp]
        public void Init()
        {
            // If we want to use Firefox
            //driver = new FirefoxDriver();

            // If we want to use Chrome
            driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            System.Threading.Thread.Sleep(5000);
            driver.Navigate().GoToUrl("https://www.google.com/");
            System.Threading.Thread.Sleep(2000);
            IWebElement search = driver.FindElement(By.Name("q"));
            search.SendKeys("C# selenium tutorials");
            System.Threading.Thread.Sleep(2000);
            search.SendKeys(Keys.Enter);
            System.Threading.Thread.Sleep(10000);
        }

        [TearDown]
        public void Destroy()
        {
            driver.Close();
        }


    }
}
