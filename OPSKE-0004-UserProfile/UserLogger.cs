using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using xxxxx_0004_UserProfile;


public class UserLogger
{
    public static IWebDriver driver { get; private set; }
    

    //Initialise driver
    [Fact]
    public void InitializeDriver()
    {
        DriverInitializer.InitializeDriver();
        DriverInitializer.DisposeDriver();
    }
    static UserLogger()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        
    }



    [Fact]
    public static void PerformLogin()
    {
        var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        driver.Navigate().GoToUrl("xxxxx");
        IWebElement username = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("username")));
        username.SendKeys("xxxxx");
        driver.FindElement(By.CssSelector("input[placeholder='Μυστικός Κωδικός']")).SendKeys("xxxxx");
        driver.FindElement(By.CssSelector(".p-button-label")).Click();
        
     
    }
}