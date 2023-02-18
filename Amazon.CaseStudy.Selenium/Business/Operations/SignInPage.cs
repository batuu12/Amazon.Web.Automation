using System;
using Amazon.CaseStudy.Selenium.Data.PageObjects;
using NLog;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Amazon.CaseStudy.Selenium.Business.Operations
{
	public class SignInPage
	{
        public readonly SignInPageObject signInPageObject;
        public IWebDriver webDriver;
        private static readonly Logger Logger = LogManager.LoadConfiguration("/Users/batuhancanci/Desktop/CodeTrainings/Amazon.CaseStudy/Amazon.CaseStudy.Selenium/nLog.config").GetCurrentClassLogger();


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
            try
            {
                signInPageObject.EmailInput.Click();
                Logger.Info("Email input has been clicked.");
                signInPageObject.EmailInput.SendKeys(email);
                Logger.Info("Email input has been filled with : " + email);
                signInPageObject.ContinueButton.Click();
                Logger.Info("Continue button has been clicked.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }

        }

        public void FillPassword(string password)
        {
            try
            {
                signInPageObject.PasswordInput.Click();
                Logger.Info("Password input has been clicked.");
                signInPageObject.PasswordInput.SendKeys(password);
                Logger.Info("Email input has been filled with : " + password);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            
        }

        public void ClickSignInButton()
        {
            try
            {
                signInPageObject.SignInButton.Click();
                Logger.Info("Sign in button clicked.");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
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

