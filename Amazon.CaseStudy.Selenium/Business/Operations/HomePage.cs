using System;
using Amazon.CaseStudy.Selenium.Data.PageObjects;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Amazon.CaseStudy.Selenium.Business.Operations
{
	public class HomePage
	{
        public readonly HomePageObject homePage;
        public IWebDriver webDriver;
        private static readonly Logger Logger = LogManager.LoadConfiguration("/Users/batuhancanci/Desktop/CodeTrainings/Amazon.CaseStudy/Amazon.CaseStudy.Selenium/nLog.config").GetCurrentClassLogger();

        public HomePage(IWebDriver webDriver)
        {
            homePage = new HomePageObject(webDriver);
            this.webDriver = webDriver;
        }


        public void GoSignIn()
        {
            homePage.HomepageButton.Click();
            Logger.Info("HomePage button clicked.");
            homePage.SignInButton.Click();
            Logger.Info("Sign In button clicked");
        }

        public bool IsLoggedInSuccessfully()
        {
            Logger.Info("Logged in successfully");
            return homePage.MyAccountButton.Displayed;
        }
    }
}

