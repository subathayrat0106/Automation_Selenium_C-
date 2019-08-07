using OpenQA.Selenium;

namespace Yorkland_Admin_Library.PageObject
{
    public class BasePageObject
    {
        protected IWebDriver driver;
        protected string baseUrl;
        protected string completeUrl;
        protected string findById = "Id";
        protected string findByXpath = "Xpath";
        protected string findByCssSelector = "css";
        protected string findByLinkText = "LinkText";
        protected string findByName = "Name";

        public BasePageObject(IWebDriver driver)
        {
            this.driver = driver;
        }

        public BasePageObject(IWebDriver driver, string baseUrl, string path)
        {
            this.driver = driver;
            this.baseUrl = baseUrl;
            SetURL(path);
            NavigateToURL();
        }

        public void SetURL(string path)
        {
            this.completeUrl = this.baseUrl + path;
        }

        public void NavigateToURL()
        {
            driver.Navigate().GoToUrl(completeUrl);
        }
    }
}
