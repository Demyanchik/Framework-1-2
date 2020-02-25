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
        [FindsBy(How = How.Id, Using = "MainContent_ucSResultEvolvi_pnlQuckLoad")]
        public IWebElement Field;

        [FindsBy(How = How.Id, Using = "MainContent_ucSResultEvolvi_rptPassengerDetails_ddlTitle_0")]
        public IWebElement Title;
        [FindsBy(How = How.Id, Using = "MainContent_ucSResultEvolvi_rptPassengerDetails_txtFirstname_0")]
        public IWebElement FirstName;
        [FindsBy(How = How.Id, Using = "MainContent_ucSResultEvolvi_rptPassengerDetails_txtLastname_0")]
        public IWebElement LastName;
        [FindsBy(How = How.XPath, Using = "//*[@id='MainContent_ucSResultEvolvi_btnContinue']")]
        public IWebElement Continue;

        [FindsBy(How = How.Id, Using = "MainContent_updProgress")]
        IWebElement Background;

        WebDriverWait wait;


        public TrainResults(IWebDriver browser)
        {
            Browser = browser;
            PageFactory.InitElements(Browser, this);
        }

        public bool CheckPage()
        {
            try
            {
                GetFirstTicket();
                return true;
            }
            catch
            {
                return false;
            }
        }


        public TrainResults GetFirstTicket()
        {
                Ticket.Click();
                Search.Click();
                return this;
        }

        public void GetTitle(string title)
        {
            int iterations;
            switch (title)
            {
                case "Dr.":
                    iterations = 1;
                    break;
                case "Mr.":
                    iterations = 2;
                    break;
                case "Miss":
                    iterations = 3;
                    break;
                case "Mrs.":
                    iterations = 4;
                    break;
                case "Ms.":
                    iterations = 5;
                    break;

                default:
                    iterations = 0;
                    break;
            }

            Title.Click();
            for (int i = 0; i < iterations; i++)
            {
                Title.SendKeys(OpenQA.Selenium.Keys.ArrowDown);
            }
            
        }

        public TrainResults InsertInfo(TicketInfo info)
        {
            GetTitle(info.Title);
            FirstName.SendKeys(info.FirstName);
            LastName.SendKeys(info.LastName);
            Continue.Click();

            return this;
        }
    }
}
