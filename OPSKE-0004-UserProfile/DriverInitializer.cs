using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace xxxxx_0004_UserProfile
{
    public class DriverInitializer 
    {
        public static IWebDriver driver { get; private set; }
        public IDictionary<String, Object> vars { get; private set; }

        public static IJavaScriptExecutor js { get; private set; }

        public static void InitializeDriver()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
        }

        public static void DisposeDriver()
        {
            driver.Quit();
        }
    }
}



