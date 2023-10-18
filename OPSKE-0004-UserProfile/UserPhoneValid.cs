using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class UserPhoneValid
{
    private static IWebDriver driver = UserLogger.driver;

    //xxxxx Login
    [Fact]
    public void InputValidPhone()
    {
        UserLogger.PerformLogin();
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Input valid phone number
        IWebElement myProfile = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("app-tile > div > div > div > a"))); ;
        myProfile.Click();
        IWebElement phoneNumber = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("phoneNumberStr")));
        phoneNumber.Clear();
        phoneNumber.SendKeys("6907856324");
        driver.FindElement(By.CssSelector("button[class='p-element p-ripple p-button p-component ng-star-inserted']")).Click();
        driver.Quit();
    }
}