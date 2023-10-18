using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

public class UserRegion
{
    private static IWebDriver driver = UserLogger.driver;

    //xxxxx Login
    [Fact]
    public void InputRegion()
    {
        UserLogger.PerformLogin();
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        //Input region code
        IWebElement myProfile = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("app-tile > div > div > div > a")));
        myProfile.Click();
        IWebElement regionCode = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ng-tns-c52-40")));
        regionCode.Click();
        IWebElement regionCodeDropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li[aria-label='Αττικής']")));
        regionCodeDropdown.Click();
        
        //Input regional unit code
        IWebElement regionalUnitCode = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ng-tns-c52-41")));
        regionalUnitCode.Click();
        IWebElement regionalUnitCodeDropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li[aria-label='Δυτικού τομέα Αθηνών'] span:nth-child(1)")));
        regionalUnitCodeDropdown.Click();
        
        //Input municipality code
        IWebElement municipalityCode = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ng-tns-c52-42")));
        municipalityCode.Click();
        IWebElement municipalityCodeDropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li[aria-label='Αγίας Βαρβάρας']")));
        municipalityCodeDropdown.Click();

        //Input municipal unit code
        IWebElement municipalUnitCode = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ng-tns-c52-43")));
        municipalUnitCode.Click();
        IWebElement municipalUnitCodeDropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li[aria-label='Δ. Ε. ΑΓΙΑΣ ΒΑΡΒΑΡΑΣ']")));
        municipalUnitCodeDropdown.Click();

        //Input municipal district code
        IWebElement municipalDistrictCode = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ng-tns-c52-44")));
        municipalDistrictCode.Click();
        IWebElement municipalDistrictCodeDropdown = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("li[aria-label='Δ. Κ. ΑΓΙΑΣ ΒΑΡΒΑΡΑΣ']")));
        municipalDistrictCodeDropdown.Click();

        //Save
        driver.FindElement(By.CssSelector("button[class='p-element p-ripple p-button p-component ng-star-inserted']")).Click();
        driver.Quit();

    }
    

}