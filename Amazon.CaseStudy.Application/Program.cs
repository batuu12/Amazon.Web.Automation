using Amazon.CaseStudy.Core.Factory;
using Amazon.CaseStudy.Core.Model;
using Amazon.CaseStudy.Selenium.Model;

public class Program
{
    private static void Main(string[] args)
    {
        PageFactory factory = new PageFactory(AmazonDriver.WebDriver);

        // Login successfully
        factory.homePage.GoSignIn();
        factory.signIn.FillEmail(TestBenchInstance.TestBench.Login.Email);
        factory.signIn.FillPassword(TestBenchInstance.TestBench.Login.Password);
        factory.signIn.ClickSignInButton();

        // Add product to cart
        factory.homePage.ClickHomePageButton();
        factory.productList.SearchDesiredProduct(TestBenchInstance.TestBench.SearchedItem);
        factory.productList.AddtoCart();

        // Add second product to cart
        factory.homePage.ClickHomePageButton();
        factory.productList.SearchDesiredProduct(TestBenchInstance.TestBench.SearchedItem);
        factory.productList.AddtoCart2();

        // Remove products from cart
        factory.productList.GoCart();
        factory.productList.RemoveFirstProductFromCart();
        factory.productList.RemoveSecondProductFromCart();
        factory.productList.ValidateEmptyCart();

        // Add product to wishlist


        // Logout successfully


    }
}