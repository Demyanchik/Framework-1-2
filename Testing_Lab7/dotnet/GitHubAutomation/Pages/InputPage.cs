﻿using OpenQA.Selenium;
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
        [FindsBy(How = How.XPath, Using = "//*[@id='MainContent_rdBookingType']/tbody/tr/td[2]/label")]
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

        [FindsBy(How = How.Id, Using = "MainContent_updProgress")]
        IWebElement Background;

        WebDriverWait wait;


        public string GetError(IWebElement element)
        {
            return element.GetCssValue("background-color");
        }

        public InputPage(IWebDriver browser)
        {
            Browser = browser;
            PageFactory.InitElements(Browser, this);
        }

        public InputPage InputInfo(Data data)
        {
            From.SendKeys(data.From);
            To.SendKeys(data.To);
            DepDate.Click();
            DepDatePicker.Click();
            Search.Click();
            return this;
        }

        public TrainResults InputAndGoNext(Data data)
        {
            From.SendKeys(data.From);
            To.SendKeys(data.To);
            DepDate.Click();
            DepDatePicker.Click();
            Search.Click();
            return new TrainResults(Browser);
        }

        public bool InputNoneOfPeople(Data data)
        {
            try
            {
                From.SendKeys(data.From);
                To.SendKeys(data.To);
                DepDate.Click();
                DepDatePicker.Click();

                Adults.Click();
                Adults.SendKeys(OpenQA.Selenium.Keys.NumberPad0);

                Search.Click();
                Wait();
            }
            catch (OpenQA.Selenium.UnhandledAlertException e)
            {
                return true;
            }
            return false;
        }


        public InputPage InputWithoutReturning(Data data)
        {
            From.SendKeys(data.From);
            To.SendKeys(data.To);
            Return.Click();
            Wait();
            DepDatePicker.Click();

            Search.Click();
            return this;
        }

        public void Wait()
        {
            while (true)
            {
                if (Background.GetCssValue("display") == "block")
                    wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(30));
                else
                    return;
                
            }
        }

    }
}
