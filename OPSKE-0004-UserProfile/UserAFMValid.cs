using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using xxxxx_0004_UserProfile;
using SeleniumExtras.WaitHelpers;

public class UserAFMValid 
{
    private static IWebDriver driver = UserLogger.driver;

    //xxxxx Login
    [Fact]
    public void InputValidAFM()
    {
        UserLogger.PerformLogin();
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Input valid AFM
        IWebElement myProfile = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("app-tile > div > div > div > a")));
        myProfile.Click();
        IWebElement extraActions = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("button.p-splitbutton-defaultbutton span.p-button-label")));
        extraActions.Click();
        IWebElement changeCriticalFields = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//span[contains(text(),'Αλλαγή Κρίσιμων Πεδίων')]")));
        changeCriticalFields.Click();
        IWebElement afm = driver.FindElement(By.Id("afm"));
        afm.Clear();
        afm.SendKeys("813425030");
        driver.FindElement(By.CssSelector("button[class='p-element p-ripple p-button p-component ng-star-inserted']")).Click();
        driver.Quit();
    }
}