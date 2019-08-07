using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Yorkland_Admin_Library.DriverFactory
{
    public class ChromeDriverManager : DriverManager
    {
        private ChromeDriverService chromeDriverService;

        public override IWebDriver CreateDriver()
        {
            driver = new ChromeDriver();
            return driver;
        }

        public override void GetStartService()
        {
            chromeDriverService = ChromeDriverService.CreateDefaultService();
            try
            {
                chromeDriverService.Start();
            }
            catch (WebDriverException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
