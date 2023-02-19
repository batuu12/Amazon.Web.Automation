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

        // Add product to wishlist and cart
        factory.productList.SearchDesiredProduct(TestBenchInstance.TestBench.SearchedItem);
        factory.productList.SelectItem();
        factory.productList.AddtoWishlist();
        factory.productList.AddtoCart();

        // Add second product to wishlist and cart
        Thread.Sleep(TimeSpan.FromSeconds(10));
        factory.homePage.ClickHomePageButton();
        factory.productList.SearchDesiredProduct(TestBenchInstance.TestBench.SearchedItem);
        factory.productList.SelectSecondItem();
        factory.productList.AddtoWishlist();
        Thread.Sleep(TimeSpan.FromSeconds(10));
        factory.productList.AddtoCart();

        // Remove products from cart
        factory.productList.GoCart();
        factory.productList.RemoveFirstProductFromCart();
        factory.productList.RemoveSecondProductFromCart();
        factory.productList.ValidateEmptyCart();

        // Remove products from wishlist
        factory.homePage.ClickHomePageButton();
        factory.wishlist.MoveToMyAccTab();
        factory.wishlist.GoWishlist();
        factory.wishlist.RemoveProductFromWishlist();
        factory.wishlist.RemoveSecondProductFromWishlist();

        // Logout successfully
        factory.homePage.ClickHomePageButton();
        factory.wishlist.MoveToMyAccTab();
        factory.homePage.Logout();

    }
}