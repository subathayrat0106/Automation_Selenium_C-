using OpenQA.Selenium;

namespace Yorkland_Admin_Library.WebControls
{
    internal class ListButtonWebControl : ListWebControl
    {
        public ListButtonWebControl(IWebDriver driver, string webElementToFind, string findElementBy) :
            base(driver, webElementToFind, findElementBy)
        {
        }

        public void Click_NumberOfButton(int number)
        {
            IWebElement element = control[number - 1];
            element.Click();
        }
    }
}
