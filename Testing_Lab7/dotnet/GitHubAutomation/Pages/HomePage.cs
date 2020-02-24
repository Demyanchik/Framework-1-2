using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework_1_2.Pages
{
    class HomePage
    {
        IWebDriver Browser;
        [FindsBy(How = How.Id, Using = "HMRT")]
        IWebElement RailTickets;
        [FindsBy(How = How.XPath, Using = "//*[@id='pnlIrHeader']/div/div[1]/div/div/div/div[2]/a[2]")]
        IWebElement SignIn;

        public HomePage(IWebDriver browser)
        {
            Browser = browser;
            PageFactory.InitElements(Browser, this);
        }

        public InputPage ToInputPage()
        {
            RailTickets.Click();
            return new InputPage(Browser);
        }

        public SignIn ToSignInPage()
        {
            SignIn.Click();
            return new SignIn(Browser);
        }
    }
}
