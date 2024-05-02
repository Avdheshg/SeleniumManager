using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
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
        //ChromeDriverService service = ChromeDriverService.CreateDefaultService("\"C:\\Users\\AvdueshGautam\\Desktop\\C#\\SeleniumManager\"", "chromedriver.exe");
        //ChromeDriverService service = ChromeDriverService.CreateDefaultService("C:\\Users\\AvdueshGautam\\Desktop\\C#\\SeleniumManager");

        ////service.DriverServicePath=
        ////service.IsRunning = false;
        ////service.DriverServiceExecutableName = "chromedriver.exe";

        //ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        //var serviceUrl = service.ServiceUrl;
        //ChromeOptions options = new ChromeOptions();
        ////// Add more options as needed
        //options.AddArgument("--start-maximized"); // Start browser maximized

        ////// Set the command timeout to 60 seconds
        //TimeSpan commandTimeout = TimeSpan.FromSeconds(60);

        ////// Initialize the FirefoxDriver with the service, options, and commandTimeout
        //ChromeDriver driver = new ChromeDriver(service, options, commandTimeout);

        // ******** Edge  **********************
        // Create the Edge driver service
        EdgeDriverService service = EdgeDriverService.CreateDefaultService();
        var serviceUrl = service.ServiceUrl;

        // Set up Edge options (add more options as needed)
        EdgeOptions options = new EdgeOptions();
        options.AddArgument("--start-maximized"); // Start browser maximized

        // Set the command timeout to 60 seconds
        TimeSpan commandTimeout = TimeSpan.FromSeconds(60);

        // Initialize the EdgeDriver with the service, options, and commandTimeout
        EdgeDriver driver = new EdgeDriver(service, options, commandTimeout);

        // Now you can use the 'driver' object to interact with the Edge browser
        driver.Navigate().GoToUrl("https://www.google.com");

    }
}