using System;
using Amazon.CaseStudy.Selenium.Data.PageObjects;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Selenium.Business.Operations
{
	public class ProductListPage
	{
        public readonly HomePageObject homePage;
        public readonly ProductListPageObject productListPage;
        public IWebDriver webDriver;



        public ProductListPage(IWebDriver webDriver)
        {
            homePage = new HomePageObject(webDriver);
            productListPage = new ProductListPageObject(webDriver);
            this.webDriver = webDriver;
        }


        public void SearchDesiredProduct(string productName)
        {
            homePage.SearchInput.Click();
            homePage.SearchInput.SendKeys(productName);
            homePage.SearchButton.Click();
        }

        public void AddtoCart()
        {
            productListPage.SelectedItem.Click();
            productListPage.AddtoCartButton.Click();
        }

        public bool ValidateAddedItem()
        {
            productListPage.CartButton.Click();
            return productListPage.SelectedItem.Displayed;
        }
    }
}

