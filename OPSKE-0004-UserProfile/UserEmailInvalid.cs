using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class UserEmailInvalid
{
    private static IWebDriver driver = UserLogger.driver;

    //xxxxx Login
    [Fact]
    public void InputInvalidEmail()
    {
        UserLogger.PerformLogin();
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Input invalid email
        IWebElement myProfile = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("app-tile > div > div > div > a")));
        myProfile.Click();
        IWebElement extraActions = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.p-splitbutton-defaultbutton span.p-button-label")));
        extraActions.Click();
        IWebElement changeCriticalFields = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Αλλαγή Κρίσιμων Πεδίων')]")));
        changeCriticalFields.Click();
        IWebElement email = driver.FindElement(By.Id("email"));
        email.Clear();
        email.SendKeys("111111111");

        //Locate error message, email format is invalid
        IWebElement emailHelp = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("email-help")));
        driver.FindElement(By.CssSelector("button[class='p-element p-ripple p-button p-component ng-star-inserted']")).Click();
        driver.Quit();
    }
}