using HelionWebSiteTest.POM;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace HelionWebSiteTest.Steps
{
    [Binding]
    public sealed class SearchDS
    {
        SearchPOM _search= new SearchPOM(RegistrationOnWebSite.Environment.Driver);
        

        [Given(@"User is on page: ""(.*)""")]
        public void GivenUserIsOnPage(string p0)
        {
            RegistrationOnWebSite.Environment.Driver.Navigate().GoToUrl(p0);
        }

        [Given(@"User enters ""(.*)"" is Search box")]
        public void GivenUserEntersIsSearchBox(string p1)
        {
            _search.searchbox.SendKeys(p1);
        }

        [Given(@"User Click search button")]
        public void GivenUserClickSearchButton()
        {
            _search.btnSearch.Click();
        }

        [Given(@"User Click ""(.*)""")]
        public void GivenUserClick(string p0)
        {
            ((IJavaScriptExecutor)RegistrationOnWebSite.Environment.Driver).ExecuteScript("arguments[0].scrollIntoView();", _search.book);

            _search.book.Click();
         }

        [Then(@"user should bo on page: ""(.*)""")]
        public void ThenUserShouldBoOnPage(string p2)
        {
            Assert.AreEqual(p2, RegistrationOnWebSite.Environment.Driver.Url);
        }



    }
}
