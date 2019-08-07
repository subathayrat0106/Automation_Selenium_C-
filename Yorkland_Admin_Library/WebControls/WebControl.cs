using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Support.UI;

namespace Yorkland_Admin_Library.WebControls
{
    internal class WebControl
    {
        IWebDriver driver;
        protected IWebElement control;
        protected string webElementToFind;
        protected int waitSecond;

        public WebControl (IWebDriver driver, string webElementToFind,string findElementBy)
        {
            this.driver = driver;
            this.webElementToFind = webElementToFind;
            waitSecond = 1;
            FindElement(webElementToFind, findElementBy);
        }

        public WebControl(IWebDriver driver, string webElementToFind, string findElementBy , int waitSecond)
        {
            this.driver = driver;
            this.webElementToFind = webElementToFind;
            this.waitSecond = waitSecond;
            FindElement(webElementToFind, findElementBy);
        }

        private void FindElement(string webElementToFind, string findElementBy)
        {
            switch (findElementBy)
            {
                case "Id":
                    FindById(webElementToFind);
                    break;
                case "Xpath":
                    FindByXpath(webElementToFind);
                    break;
                case "css":
                    FindByCssSelector(webElementToFind);
                    break;
                case "LinkText":
                    FindByLinkText(webElementToFind);
                    break;
                case "Name":
                    FindByName(webElementToFind);
                    break;
                case "ClassName":
                    FindByClassName(webElementToFind);
                    break;
            }
            this.webElementToFind = webElementToFind;
        }

        public IWebElement GetWebElement()
        {
            return control;
        }

        private void WaitForElementToBeDisplayed(By element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitSecond));
                wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(element));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private IWebElement FindByName(string webElementToFind)
        {
            try
            {
                WaitForElementToBeDisplayed(By.Name(webElementToFind));
                control = driver.FindElement(By.Name(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IWebElement FindByLinkText(string webElementToFind)
        {
            try
            {
                WaitForElementToBeDisplayed(By.LinkText(webElementToFind));
                control = driver.FindElement(By.LinkText(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IWebElement FindByCssSelector(string webElementToFind)
        {
            try
            {
                WaitForElementToBeDisplayed(By.CssSelector(webElementToFind));
                control = driver.FindElement(By.CssSelector(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IWebElement FindByXpath(string webElementToFind)
        {
            try
            {
                WaitForElementToBeDisplayed(By.XPath(webElementToFind));
                control = driver.FindElement(By.XPath(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IWebElement FindById(string webElementToFind)
        {
            try
            {
                WaitForElementToBeDisplayed(By.Id(webElementToFind));
                control = driver.FindElement(By.Id(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IWebElement FindByClassName(string webElementToFind)
        {
            try
            {
                WaitForElementToBeDisplayed(By.ClassName(webElementToFind));
                control = driver.FindElement(By.ClassName(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }
    }
}
