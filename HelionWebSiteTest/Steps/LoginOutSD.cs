using HelionWebSiteTest.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;


namespace HelionWebSiteTest.Steps
{ 

    [Binding]
    public sealed class LoginOutSD
    {
        LogInOutPOM _loginoutpage = new LogInOutPOM(RegistrationOnWebSite.Environment.Driver);

        [Given(@"User is on page:""(.*)""")]
        public void GivenUserIsOnPage(string p0)
        {
            RegistrationOnWebSite.Environment.Driver.Navigate().GoToUrl(p0);
        }

        [Given(@"User enters ""(.*)"" as e-mail")]
        public void GivenUserEntersAsE_Mail(string p1)
        {
            _loginoutpage.txtemail.SendKeys(p1);
        }

        [Given(@"User enters ""(.*)"" as password")]
        public void GivenUserEntersAsPassword(string p2)
        {
            _loginoutpage.txtpassword.SendKeys(p2);
        }

        [Given(@"User click on Log in button")]
        public void GivenUserClickOnLogInButton()
        {
            _loginoutpage.btnLogIn.Click();
        }

        [When(@"User is Log in on Helion page: ""(.*)""")]
        public void WhenUserIsLogInOnHelionPage(string p3)
        {
            Assert.AreEqual(p3, RegistrationOnWebSite.Environment.Driver.Url);
        }

        [Then(@"massage is shown: ""(.*)""")]
        public void ThenMassageIsShown(string p4)
        {
            Assert.AreEqual(p4, _loginoutpage.txtTitle.Text);
        }

       
        

        [Given(@"User is on website: ""(.*)""")]
        public void GivenUserIsOnWebsite(string p7)
        {
            RegistrationOnWebSite.Environment.Driver.Navigate().GoToUrl(p7);
        }

        [Given(@"User enters ""(.*)""  e-mail")]
        public void GivenUserEntersE_Mail(string p8)
        {
            _loginoutpage.txtemail.SendKeys(p8);
        }

        [Given(@"User enters ""(.*)""  password")]
        public void GivenUserEntersPassword(string p9)
        {
            _loginoutpage.txtpassword.SendKeys(p9);
        }

        [Given(@"User click on Sign Button")]
        public void GivenUserClickOnSignButton()
        {
            _loginoutpage.btnLogIn.Click();
        }


        [When(@"User is on website: ""(.*)""")]
        public void WhenUserIsOnWebsite(string p10)
        {
            Assert.AreEqual(p10, RegistrationOnWebSite.Environment.Driver.Url);
        }

        [Then(@"unsucessful log in message is shown: ""(.*)""")]
        public void ThenUnsucessfulLogInMessageIsShown(string p11)
        {
            Assert.AreEqual(p11, _loginoutpage.txtnapis.Text);
        }


    }
}
