using System;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Selenium.Data.PageObjects
{
	public class WishlistObjects
	{
        private readonly IWebDriver webDriver;

        public WishlistObjects(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement AccountandLists => webDriver.FindElement(By.XPath("//span[text()='Hesap ve Listeler']"));

        public IWebElement WishlistName => webDriver.FindElement(By.XPath("//span[contains(text(),'Alışveriş Listesi')]"));

        public IWebElement FirstItemDelete => webDriver.FindElement(By.XPath("//ul[@id='g-items']/li[2]//input[@name='submit.deleteItem']"));

        public IWebElement SecondItemDelete => webDriver.FindElement(By.XPath("//ul[@id='g-items']/li[3]//input[@name='submit.deleteItem']"));

    }

}

