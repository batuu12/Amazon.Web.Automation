using System;
using Amazon.CaseStudy.Selenium.Data.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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

        public void FillEmail(string email)
        {
            signInPageObject.EmailInput.Click();
            signInPageObject.EmailInput.SendKeys(email);
            signInPageObject.ContinueButton.Click();

        }

        public void FillPassword(string password)
        {
            signInPageObject.PasswordInput.Click();
            signInPageObject.PasswordInput.SendKeys(password);
            
        }

        public void ClickSignInButton()
        {
            signInPageObject.SignInButton.Click();
        }

        public void ChooseAllChars()
        {
            Actions actions = new Actions(webDriver);
            actions.SendKeys(Keys.Command + "a");
        }

        public bool IsThereWrongPasswordMessage()
        {
            return signInPageObject.WrongPasswordMessage.Displayed;
        }

        public bool IsThereBlankPasswordMessage()
        {
            return signInPageObject.BlankPasswordMessage.Displayed;
        }

        public bool IsThereBlankEmailMessage()
        {
            return signInPageObject.BlankEmailWarnMessage.Displayed;
        }

        public bool IsThereWrongEmailMessage()
        {
            return signInPageObject.WrongEmailWarnMessage.Displayed;
        }
    }
}

