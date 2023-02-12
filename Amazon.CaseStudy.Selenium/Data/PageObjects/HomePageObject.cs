using System;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Selenium.Data.PageObjects
{
	public class HomePageObject
	{
        private readonly IWebDriver webDriver;

        public HomePageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement HomepageButton => webDriver.FindElement(By.Id("nav-logo"));

        public IWebElement SignInButton => webDriver.FindElement(By.XPath("//span[text()='Merhaba, Giriş yapın']"));

        public IWebElement SearchInput => webDriver.FindElement(By.XPath("//div[@class='nav-search-field']"));

        public IWebElement SearchButton => webDriver.FindElement(By.Id("nav-search-submit-button"));

    }
}

