using System;
using OpenQA.Selenium;
using Framework_1_2.Tests;
using Framework_1_2.Pages;
using Framework_1_2.Model;
using Framework.Driver;
using NUnit.Framework;
using Framework_1_2.Util;

namespace Framework_1_2
{
    public class TransportTest : InitializeTest
    {
        string errorStyle = "rgba(255, 237, 238, 1)";

        [Test]
        public void FromIsEmpty()
        {
            InputPage InputPage = new HomePage(Browser)
                .ToInputPage()
                .InputInfo(Insert.GetInfoWithoutFrom());
            Assert.AreEqual(errorStyle, InputPage.GetError(InputPage.From));
        }

        [Test]
        public void ToIsEmpty()
        {
            InputPage InputPage = new HomePage(Browser)
                .ToInputPage()
                .InputInfo(Insert.GetInfoWithoutTo());
            Assert.AreEqual(errorStyle, InputPage.GetError(InputPage.To));

        }

        [Test]
        public void WithoutReturning()
        {
            InputPage InputPage = new HomePage(Browser)
                .ToInputPage()
                .InputWithoutReturning(Insert.GetStandardInfo());
            Assert.AreEqual(errorStyle, InputPage.GetError(InputPage.ReturnDate));

        }

        [Test]
        public void NoneOfPeople()
        {
            Assert.IsTrue(new HomePage(Browser)
                .ToInputPage()
                .InputNoneOfPeople(Insert.GetStandardInfo()));
        }

        [Test]
        public void SignInWithoutInfo()
        {
            SignIn SingInPage = new HomePage(Browser)
                .ToSignInPage()
                .LoginWithoutInfo();
           
            Assert.AreEqual(errorStyle, SingInPage.GetError(SingInPage.Email));
        }

        [Test]
        public void GetTicket()
        {
            Assert.IsTrue(new HomePage(Browser)
                .ToInputPage()
                .InputAndGoNext(Insert.GetStandardInfo())
                .GetFirstTicket());
        }
    }
}
