using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_1_2.Util
{
    class Functions
    {
        static WebDriverWait wait;

        public static void WaitTillDisappear(IWebDriver Browser, IWebElement element)
        {
            while (true)
            {
                if (element.GetCssValue("display") == "block")
                    wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(30));
                else
                    return;

            }
        }

        public static void Wait(IWebDriver Browser)
        {
            wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(30));
        }
    }
}
