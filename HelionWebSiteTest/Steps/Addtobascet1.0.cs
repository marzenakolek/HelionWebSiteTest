using HelionWebSiteTest.POM;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;



namespace HelionWebSiteTest.Steps
{
    [Binding]
    public sealed class Addtobascet10

    {
        AddToBascetPOM _addtobascet = new AddToBascetPOM(RegistrationOnWebSite.Environment.Driver);

        public object item { get; private set; }

        [Given(@"User is on webpage: ""(.*)""")]
        public void GivenUserIsOnWebpage(string p0)
        {
            RegistrationOnWebSite.Environment.Driver.Navigate().GoToUrl(p0);
        }

       
        [When(@"User enters ""(.*)""")]
        public void WhenUserEnters(string p1)
        {
            _addtobascet.searchbox.SendKeys(p1);
        }

        [When(@"Click Search button")]
        public void WhenClickSearchButton()
        {
            _addtobascet.btnSearch.Click();
        }

        [When(@"Click searched item")]
        public void WhenClickSearchedItem()
        {
            ((IJavaScriptExecutor)RegistrationOnWebSite.Environment.Driver).ExecuteScript("arguments[0].scrollIntoView();", _addtobascet.book);
            _addtobascet.book.Click();
        }

        [When(@"Clik Add to bascet button")]
        public void WhenClikAddToBascetButton()
        {
            Thread.Sleep(5000);
            _addtobascet.btnbascet.Click();
        }
        [When(@"Click bascet ikon and goes to bascet")]
        public void WhenClickBascetIkonAndGoesToBascet()
        {
            _addtobascet.basceticon.Click();
        }
        [Then(@"Check if item : ""(.*)"" is in bascet")]
        public void ThenCheckIfItemIsInBascet(string itemDisplayTextExpected)
        {
            Assert.AreEqual("http://helion.pl/zakupy/edit.cgi", RegistrationOnWebSite.Environment.Driver.Url);
            Assert.AreEqual(true, _addtobascet.bascetforitems.Any((item) => item.Text.Contains(itemDisplayTextExpected)));
        }

    }
}
