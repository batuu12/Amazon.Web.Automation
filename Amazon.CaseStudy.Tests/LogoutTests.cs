using System;
using Amazon.CaseStudy.Core.Factory;
using Amazon.CaseStudy.Selenium.Model;

namespace Amazon.CaseStudy.Tests
{
    [TestClass]
    public class LogoutTests
    {
        PageFactory factory = new PageFactory(AmazonDriver.WebDriver);

        [TestMethod]
        public void LogoutSuccessfully()
        {

        }

    }
}

