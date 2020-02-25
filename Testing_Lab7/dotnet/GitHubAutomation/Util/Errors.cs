using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_1_2.Util
{
    class Errors
    {
        public static string errorStyle = "rgba(255, 237, 238, 1)";

        public static string GetError(IWebElement element)
        {
            return element.GetCssValue("background-color");
        }
    }
}
