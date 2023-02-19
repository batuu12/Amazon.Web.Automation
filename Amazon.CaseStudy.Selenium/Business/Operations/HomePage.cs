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


        public void ClickHomePageButton()
        {
            try
            {
                homePage.HomepageButton.Click();
                Logger.Info("HomePage button clicked.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void GoSignIn()
        {
            try
            {
                homePage.SignInButton.Click();
                Logger.Info("Sign In button clicked");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            
        }

        public void Logout()
        {
            try
            {
                homePage.LogoutButton.Click();
                Logger.Info("Logout button has been clicked.");
                Thread.Sleep(TimeSpan.FromSeconds(5));
                IsLoggedOutSuccessfully();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public bool IsLoggedInSuccessfully()
        {
            try
            {
                Logger.Info("Logged in successfully");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            return homePage.MyAccountButton.Displayed;

        }

        private bool IsLoggedOutSuccessfully()
        {
            try
            {
                if (homePage.ValidateLogout.Displayed)
                {
                    Logger.Info("Logout process has been successfully");
                }
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
        }
    }
}

