using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

public class Program
{
    public static void Main(string[] args)
    {
        // Working
        //IWebDriver driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://www.google.com");


        // ******* FIREFORX **************
        // Set up the FirefoxDriverService
        //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
        //service.HideCommandPromptWindow = true; // Optional: Hide the command prompt window

        //// Set up the FirefoxOptions
        //FirefoxOptions options = new FirefoxOptions();
        //// Add more options as needed
        //options.AddArgument("--start-maximized"); // Start browser maximized

        //// Set the command timeout to 60 seconds
        //TimeSpan commandTimeout = TimeSpan.FromSeconds(60);

        //// Initialize the FirefoxDriver with the service, options, and commandTimeout
        //FirefoxDriver driver = new FirefoxDriver(service, options, commandTimeout);

        // ******** CHROME  **********************
        // Set up the FirefoxDriverService
        //ChromeDriverService service = ChromeDriverService.CreateDefaultService("\"C:\\Users\\AvdueshGautam\\Desktop\\C#\\SeleniumManager\"", "chromedriver.exe");
        ChromeDriverService service = ChromeDriverService.CreateDefaultService("C:\\Users\\AvdueshGautam\\Desktop\\C#\\SeleniumManager");
        //service.IsRunning = false;
        //service.DriverServiceExecutableName = "chromedriver.exe";

        // Set up the FirefoxOptions
        ChromeOptions options = new ChromeOptions();
        // Add more options as needed
        options.AddArgument("--start-maximized"); // Start browser maximized

        // Set the command timeout to 60 seconds
        TimeSpan commandTimeout = TimeSpan.FromSeconds(60);

        // Initialize the FirefoxDriver with the service, options, and commandTimeout
        ChromeDriver driver = new ChromeDriver(service, options, commandTimeout);

        //driver.Navigate().GoToUrl("www.google.com");
    }
}