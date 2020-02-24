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
    class TrainResults
    {
        IWebDriver Browser;

        [FindsBy(How = How.XPath, Using = "//*[@id='MainContent_ucSResultEvolvi_rptoutEvolvi_DivTr_0']/div[2]/div[1]/label/span")]
        public IWebElement Ticket;
        [FindsBy(How = How.Id, Using = "MainContent_ucSResultEvolvi_rptoutEvolvi_btnContinueBooking_0")]
        public IWebElement Search;
        [FindsBy(How = How.Id, Using = "MainContent_ucSResultEvolvi_rptoutEvolvi_DivTr_0")]
        public IWebElement Field;

        [FindsBy(How = How.Id, Using = "MainContent_updProgress")]
        IWebElement Background;

        WebDriverWait wait;


        public TrainResults(IWebDriver browser)
        {
            Browser = browser;
            PageFactory.InitElements(Browser, this);
        }

        public bool GetFirstTicket()
        {
            Ticket.Click();
            Search.Click();
            return true;
        }

    }
}
