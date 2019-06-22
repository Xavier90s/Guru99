using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Guru99
{
    public class Guru99Demo
    {

        IWebDriver driver;
        private string expectedtext= "Business Software Reviews, SaaS & Cloud Applications Directory | GetApp®";

        [SetUp]
        public void OpenBrowserPage()
        {
            driver = new ChromeDriver();
            driver.Url = "http://www.getapp.com";
        }

        [Test]
        public void TestTitle() => Assert.AreEqual(expectedtext, driver.Title);

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
        }

    }
}
