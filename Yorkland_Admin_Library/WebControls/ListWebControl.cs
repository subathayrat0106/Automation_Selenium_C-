using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace Yorkland_Admin_Library.WebControls
{
    class ListWebControl
    {
        IWebDriver driver;
        protected IList<IWebElement> control;
        protected string webElementToFind;

        public ListWebControl(IWebDriver driver, string webElementToFind, string findElementBy)
        {
            this.driver = driver;
            this.webElementToFind = webElementToFind;
            FindElements(webElementToFind, findElementBy);
        }


        private void FindElements(string webElementToFind, string findElementBy)
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

        public IList<IWebElement> GetWebElement()
        {
            return control;
        }
    
        private IList<IWebElement> FindByName(string webElementToFind)
        {
            try
            {
                control = driver.FindElements(By.Name(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;

        }

        private IList<IWebElement> FindByLinkText(string webElementToFind)
        {
            try
            {
                control = driver.FindElements(By.LinkText(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IList<IWebElement> FindByCssSelector(string webElementToFind)
        {
            try
            {
                control = driver.FindElements(By.CssSelector(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IList<IWebElement> FindByXpath(string webElementToFind)
        {
            try
            {
                control = driver.FindElements(By.XPath(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IList<IWebElement> FindById(string webElementToFind)
        {
            try
            {
                control = driver.FindElements(By.Id(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }

        private IList<IWebElement> FindByClassName(string webElementToFind)
        {
            try
            {
                control = driver.FindElements(By.ClassName(webElementToFind));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return control;
        }
    }
}
