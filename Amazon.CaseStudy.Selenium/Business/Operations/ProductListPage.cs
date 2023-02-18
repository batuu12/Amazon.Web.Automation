using System;
using Amazon.CaseStudy.Selenium.Data.PageObjects;
using NLog;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Selenium.Business.Operations
{
	public class ProductListPage
	{
        public readonly HomePageObject homePage;
        public readonly ProductListPageObject productListPage;
        public IWebDriver webDriver;
        private static readonly Logger Logger = LogManager.LoadConfiguration("/Users/batuhancanci/Desktop/CodeTrainings/Amazon.CaseStudy/Amazon.CaseStudy.Selenium/nLog.config").GetCurrentClassLogger();



        public ProductListPage(IWebDriver webDriver)
        {
            homePage = new HomePageObject(webDriver);
            productListPage = new ProductListPageObject(webDriver);
            this.webDriver = webDriver;
        }


        public void SearchDesiredProduct(string productName)
        {
            try
            {
                homePage.SearchInput.Click();
                Logger.Info("Search input has been clicked.");
                homePage.SearchInputText.SendKeys(productName);
                Logger.Info("Searched item : " + productName);
                homePage.SearchButton.Click();
                Logger.Info("Search button has been clicked.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void GoCart()
        {
            try
            {
                productListPage.CartButton.Click();
                Logger.Info("Going to cart..");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void AddtoCart()
        {
            try
            {
                productListPage.SelectedItem.Click();
                Logger.Info("Desired item selected.");
                productListPage.AddtoCartButton.Click();
                Logger.Info("Selected item added to cart.");
                ValidateAddedItem();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void AddtoCart2()
        {
            try
            {
                productListPage.SelectedItem2.Click();
                Logger.Info("Second desired item selected.");
                productListPage.AddtoCartButton.Click();
                Logger.Info("Second selected item added to cart.");
                ValidateAddedItem();

            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void RemoveFirstProductFromCart()
        {
            try
            {
                productListPage.RemoveFirstItem.Click();
                Logger.Info("First item has beed removed from cart.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void RemoveSecondProductFromCart()
        {
            try
            {
                productListPage.RemoveSecondItem.Click();
                Logger.Info("Second item has beed removed from cart.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public bool ValidateEmptyCart()
        {
            try
            {
                if (productListPage.CartIsEmptyText.Displayed)
                {
                    Logger.Info("Cart is empty!");
                    return true;
                }
                return productListPage.CartIsEmptyText.Displayed;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
        }

        private bool ValidateAddedItem()
        {
            try
            {
                if (productListPage.ProductAddedCartText.Displayed==true)
                {
                    Logger.Info("Product has been added to cart successfully.");
                    return productListPage.ProductAddedCartText.Displayed;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                return false;
            }
            return true;
        }
    }
}

