using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class UserPostalcodeInvalid
{
    private static IWebDriver driver = UserLogger.driver;

    //xxxxx Login
    [Fact]
    public void InputInvalidPostalcode()
    {
        UserLogger.PerformLogin();
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Input invalid postal code
        IWebElement myProfile = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("app-tile > div > div > div > a"))); ;
        myProfile.Click();
        IWebElement postalCode = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("postalCode")));
        postalCode.Clear();
        postalCode.SendKeys("abcdg");
        
        //Locate element, postal code format invalid
        IWebElement postalCodeHelp = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("postalCode-help")));
        driver.FindElement(By.CssSelector("button[class='p-element p-ripple p-button p-component ng-star-inserted']")).Click();
        driver.Quit();
    }
}