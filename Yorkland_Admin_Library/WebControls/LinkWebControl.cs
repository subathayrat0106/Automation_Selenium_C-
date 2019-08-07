using OpenQA.Selenium;

namespace Yorkland_Admin_Library.WebControls
{
    internal class LinkWebControl : WebControl
    {
        public LinkWebControl(IWebDriver driver, string webElementToFind, string findElementBy) 
            : base(driver, webElementToFind, findElementBy)
        {
        }

        public LinkWebControl(IWebDriver driver, string webElementToFind, string findElementBy, int waitSecond) 
            : base(driver, webElementToFind, findElementBy, waitSecond)
        {
        }

        public void ClickLinkText()
        {
            control.Click();
        }
    }
}
