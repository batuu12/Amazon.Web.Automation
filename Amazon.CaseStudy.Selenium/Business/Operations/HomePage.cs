using System;
using Amazon.CaseStudy.Selenium.Data.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Amazon.CaseStudy.Selenium.Business.Operations
{
	public class HomePage
	{
        public readonly HomePageObject homePage;
        public IWebDriver webDriver;



        public HomePage(IWebDriver webDriver)
        {
            homePage = new HomePageObject(webDriver);
            this.webDriver = webDriver;
        }


        public void GoSignIn()
        {
            homePage.HomepageButton.Click();
            homePage.SignInButton.Click();
        }

        public bool IsLoggedInSuccessfully()
        {
            return homePage.MyAccountButton.Displayed;
        }
    }
}

