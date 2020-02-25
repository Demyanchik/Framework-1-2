using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Framework_1_2.Tests;
using Framework_1_2.Pages;
using Framework_1_2.Model;

namespace Framework_1_2
{
    [TestClass]
    class TransportTest: InitializeTest
    {
        [TestMethod]
        public void FromIsEmpty()
        {
            InputPage InputPage = new HomePage(Browser)
                .ToInputPage()
                .InputWithoutFrom(new Data("London Paddington", "Cardiff Central"));
            Assert.AreEqual("rgba(255, 237, 238, 1)", InputPage.GetError(InputPage.From));
        }

        [TestMethod]
        public void ToIsEmpty()
        {
            IWebDriver Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            //Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("https://www.internationalrail.com/");

            IWebElement RailTickets = Browser.FindElement(By.Id("HMRT"));
            RailTickets.Click();
            IWebElement From = Browser.FindElement(By.Id("txtFrom"));
            From.SendKeys("London Paddington");
            IWebElement To = Browser.FindElement(By.Id("txtTo"));
            IWebElement Date = Browser.FindElement(By.Id("MainContent_txtDepartureDate"));
            Date.Click();
            IWebElement DatePicker = Browser.FindElement(By.XPath("//*[@id='ui-datepicker-div']/table/tbody/tr[5]/td[6]/a"));
            DatePicker.Click();

            IWebElement Search = Browser.FindElement(By.Id("MainContent_btnCheckout"));
            Search.Click();

            string result = To.GetCssValue("background-color");
            Browser.Quit();

            Assert.AreEqual("rgba(255, 237, 238, 1)", result);

        }
    }
}
