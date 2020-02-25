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

        [Test]
        public void FromIsEmpty()
        {
            InputPage InputPage = new HomePage(Browser)
                .ToInputPage()
                .InputInfo(Insert.GetInfoWithoutFrom());
            Assert.AreEqual(Errors.errorStyle, Errors.GetError(InputPage.From));
        }

        [Test]
        public void ToIsEmpty()
        {
            InputPage InputPage = new HomePage(Browser)
                .ToInputPage()
                .InputInfo(Insert.GetInfoWithoutTo());
            Assert.AreEqual(Errors.errorStyle, Errors.GetError(InputPage.To));

        }

        [Test]
        public void WithoutReturning()
        {
            InputPage InputPage = new HomePage(Browser)
                .ToInputPage()
                .InputWithoutReturning(Insert.GetStandardInfo());
            Assert.AreEqual(Errors.errorStyle, Errors.GetError(InputPage.ReturnDate));

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
           
            Assert.AreEqual(Errors.errorStyle, SingInPage.GetError(SingInPage.Email));
        }

        [Test]
        public void GetTicket()
        {
            Assert.IsTrue(new HomePage(Browser)
                .ToInputPage()
                .InputAndGoNext(Insert.GetStandardInfo())
                .CheckPage());
        }

        [Test]
        public void InputWithoutFirstname()
        {
            TrainResults TrainsPage = new HomePage(Browser)
                .ToInputPage()
                .InputAndGoNext(Insert.GetStandardInfo())
                .GetFirstTicket()
                .InsertInfo(Insert.GetInfoWithoutFirstname());

            Assert.AreEqual(Errors.errorStyle, Errors.GetError(TrainsPage.FirstName));
        }

        [Test]
        public void InputWithoutTitle()
        {
            TrainResults TrainsPage = new HomePage(Browser)
                .ToInputPage()
                .InputAndGoNext(Insert.GetStandardInfo())
                .GetFirstTicket()
                .InsertInfo(Insert.GetInfoWithoutTitle());

            Assert.AreEqual(Errors.errorStyle, Errors.GetError(TrainsPage.Title));
        }
    }
}
