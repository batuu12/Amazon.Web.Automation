using System;
using Amazon.CaseStudy.Selenium.Data.PageObjects;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Amazon.CaseStudy.Selenium.Business.Operations
{
	public class WishlistPage
	{
        public readonly WishlistObjects wishlist;
        public IWebDriver webDriver;
        private static readonly Logger Logger = LogManager.LoadConfiguration("/Users/batuhancanci/Desktop/CodeTrainings/Amazon.CaseStudy/Amazon.CaseStudy.Selenium/nLog.config").GetCurrentClassLogger();

        public WishlistPage(IWebDriver webDriver)
        {
            wishlist = new WishlistObjects(webDriver);
            this.webDriver = webDriver;
        }

        public void MoveToMyAccTab()
        {
            try
            {
                Actions action = new Actions(webDriver);
                action.MoveToElement(wishlist.AccountandLists).Perform();
                Logger.Info("Moving to My Account tab..");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void GoWishlist()
        {
            try
            {
                wishlist.WishlistName.Click();
                Logger.Info("Going to wishlist page..");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void RemoveProductFromWishlist()
        {
            try
            {
                wishlist.FirstItemDelete.Click();
                Logger.Info("First item has been removed.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }

        public void RemoveSecondProductFromWishlist()
        {
            try
            {
                wishlist.SecondItemDelete.Click();
                Logger.Info("Second item has been removed.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }
    }
}

