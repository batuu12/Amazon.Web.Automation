using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Amazon.CaseStudy.Selenium.Model
{
	public class AmazonDriver
	{
        private static readonly AmazonDriver instance = new AmazonDriver();

        private readonly IWebDriver webDriver;
        private readonly WebDriverWait waitDriver;
        private static string amazonWindowHandle;

        static AmazonDriver()
        {
        }

        private AmazonDriver()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--disable-notifications");
            options.AddArguments("disable-infobars");

            webDriver = new ChromeDriver();

            waitDriver = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30));

            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            webDriver.Url = UrlRepository.amazonUrl;

            amazonWindowHandle = webDriver.CurrentWindowHandle;
        }

        public static IWebDriver WebDriver
        {
            get
            {
                instance.webDriver.SwitchTo().Window(amazonWindowHandle);
                return instance.webDriver;
            }
        }

        public static WebDriverWait Wait
        {
            get
            {
                return instance.waitDriver;
            }
        }

    }
}

