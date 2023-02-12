using System;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Selenium.Data.PageObjects
{
	public class ProductListPageObject
	{
        private readonly IWebDriver webDriver;

        public ProductListPageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement SelectedItem => webDriver.FindElement(By.XPath("//div[@class='a-section a-spacing-base']"));

        public IWebElement AddtoCartButton => webDriver.FindElement(By.XPath("//span[@id='submit.add-to-cart-announce']"));

        public IWebElement ProductAvailableText => webDriver.FindElement(By.XPath("//div[@id='availability']"));

        public IWebElement CartButton => webDriver.FindElement(By.XPath("//a[@id='nav-cart']"));
    }
}

