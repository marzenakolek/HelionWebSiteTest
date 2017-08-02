using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelionWebSiteTest.POM
{
    class AddToBascetPOM
    {
        private IWebDriver Driver { get; set; }
        public AddToBascetPOM(IWebDriver Driver)
        {
            PageFactory.InitElements(RegistrationOnWebSite.Environment.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "inputSearch")]
        public IWebElement searchbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='szukanie']/fieldset/a/button")]
        public IWebElement btnSearch { get; set; }
        [FindsBy(How = How.ClassName, Using = "cshpk3-link")]
        public IWebElement book { get; set; }
        [FindsBy(How = How.Id, Using = "addToBasket_cshpk3")]
        public IWebElement btnbascet { get; set; }
        [FindsBy(How = How.ClassName, Using = "hideFixed")]
        public IWebElement basceticon { get; set; }
        [FindsBy(How = How.Id, Using = "koszyk")]
        public IList <IWebElement> bascetforitems { get; set; }

    }
}
