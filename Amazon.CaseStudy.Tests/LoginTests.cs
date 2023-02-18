using System;
using Amazon.CaseStudy.Core.Factory;
using Amazon.CaseStudy.Core.Model;
using Amazon.CaseStudy.Selenium.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Amazon.CaseStudy.Tests
{
    [TestClass]
    public class LoginTests
    {
        PageFactory factory = new PageFactory(AmazonDriver.WebDriver);

        [TestMethod]
        public void FillEmailasBlank()
        {
            factory.homePage.GoSignIn();
            factory.signIn.FillEmail(TestBenchInstance.TestBench.FakeLogin.BlankEmail);
            Assert.IsTrue(factory.signIn.IsThereBlankEmailMessage());
        }

        [TestMethod]
        public void FillEmailFakeCredentials()
        {
            factory.signIn.FillEmail(TestBenchInstance.TestBench.FakeLogin.FakeEmail);
            Assert.IsTrue(factory.signIn.IsThereWrongEmailMessage());
        }

        [TestMethod]
        public void FillPasswordasBlank()
        {
            factory.signIn.ChooseAllChars();
            factory.signIn.FillEmail(TestBenchInstance.TestBench.Login.Email);
            factory.signIn.FillPassword(TestBenchInstance.TestBench.FakeLogin.BlankPassword);
            factory.signIn.ClickSignInButton();
            Assert.IsTrue(factory.signIn.IsThereBlankPasswordMessage());
        }

        [TestMethod]
        public void FillPasswordFakeCredentials()
        {
            factory.signIn.FillPassword(TestBenchInstance.TestBench.FakeLogin.FakePassword);
            factory.signIn.ClickSignInButton();
            Assert.IsTrue(factory.signIn.IsThereWrongPasswordMessage());
        }

        [TestMethod]
        public void LoginSuccessfully()
        {
            factory.homePage.GoSignIn();
            factory.signIn.FillEmail(TestBenchInstance.TestBench.Login.Email);
            factory.signIn.FillPassword(TestBenchInstance.TestBench.Login.Password);
            factory.signIn.ClickSignInButton();
            Assert.IsTrue(factory.homePage.IsLoggedInSuccessfully());
        }


    }

}

