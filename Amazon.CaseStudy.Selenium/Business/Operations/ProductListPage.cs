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

        public void SelectItem()
        {
            try
            {
                productListPage.SelectedItem.Click();
                Logger.Info("Desired item selected.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void SelectSecondItem()
        {
            try
            {
                productListPage.SelectedItem2.Click();
                Logger.Info("Desired item selected.");
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
                productListPage.AddtoCartButton.Click();
                Logger.Info("Selected item added to cart.");
                Thread.Sleep(TimeSpan.FromSeconds(10));
                if (productListPage.CloseCartPopUp.Displayed==true)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(10));
                    productListPage.CloseCartPopUp.Click();
                    Logger.Info("Navigating to cart..");
                }
                else
                {
                    Thread.Sleep(TimeSpan.FromSeconds(10));
                    homePage.HomepageButton.Click();
                    Logger.Info("Navigating to homepage..");
                }
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
                Logger.Info("First item has been removed from cart.");
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
                Logger.Info("Second item has been removed from cart.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void AddtoWishlist()
        {
            try
            {
                IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
                js.ExecuteScript("window.scrollBy(0,100)","");

                productListPage.AddtoWishlist.Click();
                Logger.Info("Product has been added to wishlist.");
                Thread.Sleep(TimeSpan.FromSeconds(10));
                productListPage.CloseWishlistPopUp.Click();
                Logger.Info("Wishlist popup has beed closed.");

                js.ExecuteScript("window.scrollBy(0,-100)", "");
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

