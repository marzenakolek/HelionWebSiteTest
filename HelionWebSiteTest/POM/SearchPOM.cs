using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelionWebSiteTest.POM
{
    class SearchPOM
    {
        private IWebDriver Driver { get; set; }
        public SearchPOM(IWebDriver Driver)
        {
            PageFactory.InitElements(RegistrationOnWebSite.Environment.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "inputSearch")]
        public IWebElement searchbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='szukanie']/fieldset/a/button")]
        public IWebElement btnSearch { get; set; }
        [FindsBy(How = How.ClassName, Using = "as24w4-link")]
        public IWebElement book { get; set; }
    }
}
