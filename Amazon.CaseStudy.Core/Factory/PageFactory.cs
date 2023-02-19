using System;
using Amazon.CaseStudy.Selenium.Business.Operations;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Core.Factory
{
    public class PageFactory
    {

        public HomePage homePage;
        public SignInPage signIn;
        public ProductListPage productList;
        public WishlistPage wishlist;
        
        public PageFactory(IWebDriver driver)
        {
            homePage = new HomePage(driver);
            signIn = new SignInPage(driver);
            productList = new ProductListPage(driver);
            wishlist = new WishlistPage(driver);
        }
    }
}




