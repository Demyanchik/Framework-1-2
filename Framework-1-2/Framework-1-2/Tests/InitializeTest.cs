using System;
using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework.Interfaces;
using System.Threading;
using Framework.Driver;

namespace Framework_1_2.Tests
{
    class InitializeTest
    {
        protected IWebDriver Browser { get; set; }

        [SetUp]
        public void Setter()
        {
            Browser = Driver.GetDriver();
            Browser.Navigate().GoToUrl("https://www.internationalrail.com/");
        }
    }
}
