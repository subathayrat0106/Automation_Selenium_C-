using OpenQA.Selenium;

namespace Yorkland_Admin_Library.DriverFactory
{
    public abstract class DriverManager:DriverFactory
    {
        protected IWebDriver driver;

        public abstract IWebDriver CreateDriver();

        public abstract void GetStartService();

        public DriverManager()
        {
        }

        public DriverManager(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebDriver GetDriver()
        {
            if (null == driver)
            {
                GetStartService();
                driver = CreateDriver();
            }
            return driver;
        }

        public void QuitDriver()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }
        }
    }
}
