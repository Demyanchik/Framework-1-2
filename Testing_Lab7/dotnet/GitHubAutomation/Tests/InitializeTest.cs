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
    public class InitializeTest
    {
        protected IWebDriver Browser { get; set; }

        [SetUp]
        public void Setter()
        {
            Browser = Driver.GetDriver();
            Browser.Navigate().GoToUrl("https://www.internationalrail.com/");
        }

        [TearDown]
        public void ClearDriver()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string screenFolder = AppDomain.CurrentDomain.BaseDirectory + @"\screens";
                Directory.CreateDirectory(screenFolder);
                var screen = Browser.TakeScreenshot();
                screen.SaveAsFile(screenFolder + @"\screen" + DateTime.Now.ToString("yy-MM-dd_hh-mm-ss") + ".png",
                    ScreenshotImageFormat.Png);
            }

            Driver.CloseDriver();
        }
    }
}
