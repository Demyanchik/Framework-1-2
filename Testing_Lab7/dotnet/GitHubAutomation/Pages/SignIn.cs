using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using Framework_1_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_1_2.Pages
{
    class SignIn
    {
        IWebDriver Browser;

        [FindsBy(How = How.Id, Using = "MainContent_txtEmail")]
        public IWebElement Email;
        [FindsBy(How = How.Id, Using = "MainContent_txtPassword")]
        public IWebElement Password;
        [FindsBy(How = How.Id, Using = "MainContent_btnSubmit")]
        public IWebElement Login;

        [FindsBy(How = How.Id, Using = "MainContent_updProgress")]
        IWebElement Background;

        WebDriverWait wait;

        public string GetError(IWebElement element)
        {
            return element.GetCssValue("background-color");
        }

        public SignIn(IWebDriver browser)
        {
            Browser = browser;
            PageFactory.InitElements(Browser, this);
        }

        public SignIn LoginWithoutInfo()
        {
            Login.Click();
            return this;
        }

    }
}
