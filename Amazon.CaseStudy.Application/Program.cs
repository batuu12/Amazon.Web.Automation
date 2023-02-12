using Amazon.CaseStudy.Core.Factory;
using Amazon.CaseStudy.Core.Model;
using Amazon.CaseStudy.Selenium.Model;

public class Program
{
    private static void Main(string[] args)
    {
        PageFactory factory = new PageFactory(AmazonDriver.WebDriver);

        // Login process
        factory.homePage.GoSignIn();
        factory.signIn.SignInProcess(TestBenchInstance.TestBench.Login.Email, TestBenchInstance.TestBench.Login.Email);


    }
}