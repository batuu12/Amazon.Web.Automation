﻿using System;
using OpenQA.Selenium;

namespace Amazon.CaseStudy.Selenium.Data.PageObjects
{
	public class SignInPageObject
	{
        private readonly IWebDriver webDriver;

        public SignInPageObject(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public IWebElement UsernameInput => webDriver.FindElement(By.Id("ap_email"));

        public IWebElement ContinueButton => webDriver.FindElement(By.Id("continue"));

        public IWebElement PasswordInput => webDriver.FindElement(By.Id("ap_password"));

        public IWebElement SignInButton => webDriver.FindElement(By.Id("signInSubmit"));
    }
}

