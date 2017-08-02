using HelionWebSiteTest.POM;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace HelionWebSiteTest.Steps
{
    [Binding]
    public sealed class LogOut
    {
        LogInOutPOM _loginoutpage = new LogInOutPOM(RegistrationOnWebSite.Environment.Driver);

        [Given(@"He is on page:""(.*)""")]
        public void GivenHeIsOnPage(string p12)
        {
            RegistrationOnWebSite.Environment.Driver.Navigate().GoToUrl(p12);
        }

       [Given(@"He is on site: ""(.*)""")]
        public void GivenHeIsOnSite(string p55)
        {
            Assert.AreEqual(p55, RegistrationOnWebSite.Environment.Driver.Url);

        }


        [Given(@"He hoovers on Twoje konto")]
        public void GivenHeHooversOnTwojeKonto()
        {
            _loginoutpage.txtTwojeKonto.Click();
        }

        [Given(@"He click on Log out")]
        public void GivenHeClickOnLogOut()
        {
            _loginoutpage.txtLogout.Click();
        }

        [When(@"He is on page:""(.*)""")]
        public void WhenHeIsOnPage(string p5)
        {
            Assert.AreEqual(p5, RegistrationOnWebSite.Environment.Driver.Url);
        }

        [Then(@"message is onpage:""(.*)""")]
        public void ThenMessageIsOnpage(string p6)
        {
            Assert.AreEqual(p6, _loginoutpage.CorrectLogoutMessage.Text);
        }
    }

    }
