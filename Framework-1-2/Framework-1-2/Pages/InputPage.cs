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
    class InputPage
    {
        IWebDriver Browser;

        [FindsBy(How = How.Id, Using = "txtFrom")]
        public IWebElement From;
        [FindsBy(How = How.Id, Using = "txtTo")]
        public IWebElement To;
        
        [FindsBy(How = How.Id, Using = "MainContent_rdBookingType_0")]
        IWebElement OneWay;
        [FindsBy(How = How.Id, Using = "MainContent_rdBookingType_1")]
        IWebElement Return;

        [FindsBy(How = How.Id, Using = "MainContent_txtDepartureDate")]
        public IWebElement DepDate;
        [FindsBy(How = How.XPath, Using = "//*[@id='ui-datepicker-div']/table/tbody/tr[5]/td[6]/a")]
        IWebElement DepDatePicker;

        [FindsBy(How = How.Id, Using = "MainContent_txtReturnDate")]
        public IWebElement ReturnDate;

        [FindsBy(How = How.Id, Using = "MainContent_ddlAdult")]
        IWebElement Adults;

        [FindsBy(How = How.Id, Using = "MainContent_btnCheckout")]
        IWebElement Search;

        public string GetError(IWebElement element)
        {
            return element.GetCssValue("background-color");
        }

        public InputPage(IWebDriver browser)
        {
            Browser = browser;
            PageFactory.InitElements(Browser, this);
        }

        public InputPage InputWithoutFrom(Data data)
        {
            To.SendKeys(data.To);
            DepDate.Click();
            DepDatePicker.Click();

            Search.Click();
            return this;
        }

    }
}
