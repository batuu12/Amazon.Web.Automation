using System;
using Amazon.CaseStudy.Selenium.Data.PageObjects;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Selenium.Business.Operations
{
	public class SignInPage
	{
        public readonly SignInPageObject signInPageObject;
        public IWebDriver webDriver;


        public SignInPage(IWebDriver webDriver)
        {
            signInPageObject = new SignInPageObject(webDriver);
            this.webDriver = webDriver;
        }


        public void SignInProcess(string username,string password)
        {
            signInPageObject.EmailInput.Click();
            signInPageObject.EmailInput.SendKeys(username);
            signInPageObject.ContinueButton.Click();
            signInPageObject.PasswordInput.Click();
            signInPageObject.PasswordInput.SendKeys(password);
            signInPageObject.SignInButton.Click();
        }

        public void FillUsername(string fakeEmail)
        {
            signInPageObject.EmailInput.Click();
            signInPageObject.EmailInput.SendKeys(fakeEmail);

        }

        public bool IsThereWarnMessage()
        {
            return signInPageObject.BlankEmailWarnMessage.Displayed;
        }
    }
}

