using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System;

namespace Yorkland_Admin_Library.DriverFactory
{
    public class IEDriverManager:DriverManager
    {
        private InternetExplorerDriverService IEDriverService;

        public override IWebDriver CreateDriver()
        {
            InternetExplorerOptions options = new InternetExplorerOptions
            {
                IntroduceInstabilityByIgnoringProtectedModeSettings = true
            };
            driver = new InternetExplorerDriver(IEDriverService, options);

            return driver;
        }

        public override void GetStartService()
        {
            IEDriverService = InternetExplorerDriverService.CreateDefaultService();
            try
            {
                IEDriverService.Start();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
