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

        public IWebElement SelectedItem => webDriver.FindElement(By.XPath("//div[@data-cel-widget='search_result_2']"));

        public IWebElement SelectedItem2 => webDriver.FindElement(By.XPath("//div[@data-cel-widget='search_result_3']"));

        public IWebElement AddtoCartButton => webDriver.FindElement(By.Id("add-to-cart-button"));

        public IWebElement AddtoWishlistButton => webDriver.FindElement(By.Id("wishListMainButton"));

        public IWebElement ProductAvailableText => webDriver.FindElement(By.XPath("//div[@id='availability']"));

        public IWebElement CartButton => webDriver.FindElement(By.Id("nav-cart"));

        public IWebElement ProductAddedCartText => webDriver.FindElement(By.XPath("//span[contains(text(),'Sepete Eklendi')]"));

        public IWebElement RemoveFirstItem => webDriver.FindElement(By.XPath("//div[@data-item-count=1]//input[@value='Sil']"));

        public IWebElement RemoveSecondItem => webDriver.FindElement(By.XPath("//div[@data-item-count=2]//input[@value='Sil']"));

        public IWebElement CartIsEmptyText => webDriver.FindElement(By.XPath("//h1[contains(text(),'Amazon sepetiniz boş')]"));

    }
}

