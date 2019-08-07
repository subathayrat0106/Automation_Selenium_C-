using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;

namespace Yorkland_Admin_Library.DriverFactory
{
    public class FireFoxDriverManager : DriverManager
    {
        private FirefoxDriverService FireFoxDriverService;

        public override IWebDriver CreateDriver()
        {
            FirefoxOptions options = new FirefoxOptions
            {
                AcceptInsecureCertificates = true
            };
            driver = new FirefoxDriver(options);
            return driver;
        }

        public override void GetStartService()
        {
            FireFoxDriverService = FirefoxDriverService.CreateDefaultService();
            try
            {
                FireFoxDriverService.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
