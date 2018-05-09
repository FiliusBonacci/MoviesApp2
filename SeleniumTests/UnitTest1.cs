using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTests
{
    [TestClass]
    public class UnitTest1
    {

        private IWebDriver driver;
        //IWebDriver ieDriver = new IEDriver();


        [TestInitialize]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:57930/");
        }


        [TestMethod]
        public void TestgetTitle()
        {
           // IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://localhost:57930/");
            IWebElement element = driver.FindElement(By.LinkText("Katalog filmów"));
            element.Click();
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(driver.Title.Contains("movies"));

        }


        [TestMethod]
        public void TestCreateNewMovie()
        {
            // IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://localhost:57930/");
            IWebElement element = driver.FindElement(By.LinkText("Katalog filmów"));
            element.Click();

            IWebElement createBtn = driver.FindElement(By.LinkText("Create New Movie"));
            createBtn.Click();

            // wypełniamy formularz
            driver.FindElement(By.Name("Title")).SendKeys("tytul nowy");

            driver.FindElement(By.Name("Description")).SendKeys("opis filmu");

            driver.FindElement(By.Name("ReleaseDate")).SendKeys("2018");
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();


            string table = driver.FindElement(By.ClassName("table")).Text;

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(
                table.Contains("tytul nowy"));

        }

    // nie wypełnij tytulu
    // test



      // zrob jakies inne bledy przy dodawaniu filmu


     // edytul dodany film







        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
