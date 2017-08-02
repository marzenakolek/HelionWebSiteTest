using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RegistrationOnWebSite;
using TechTalk.SpecFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelionWebSiteTest.POM
{
    class LogInOutPOM
    {
        private IWebDriver Driver { get; set; }
        public LogInOutPOM(IWebDriver Driver) 
            
        {
            PageFactory.InitElements(RegistrationOnWebSite.Environment.Driver, this);
        }
        //Log In
        [FindsBy( How = How.XPath, Using="//*[@id='content']/div/section/div[2]/div/form/fieldset/div[1]/input")]
        public IWebElement txtemail { get; set; }
        [FindsBy( How = How.XPath, Using = "//*[@id='content']/div/section/div[2]/div/form/fieldset/div[2]/input")]
        public IWebElement txtpassword { get; set; }
        [FindsBy( How = How.XPath, Using= "//*[@id='content']/div/section/div[2]/div/form/fieldset/p[1]/button")]
        public IWebElement btnLogIn { get; set; }
        [FindsBy(How = How.Id, Using = "page-title")]
        public IWebElement txtTitle { get; set; }

        //Log Out
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div[2]/div[1]/p/a")]
        public IWebElement txtTwojeKonto { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div[2]/div[2]/p/a")]
        public IWebElement txtLogout { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/section/div[2]/div/form/fieldset/div[1]/font/h4")]
        public IWebElement txtnapis { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/section/div[2]/div/div[1]/p")]
        public IWebElement CorrectLogoutMessage { get; set; }
       
    }
}
