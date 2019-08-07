using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Yorkland_Admin_Library.WebControls
{
    internal class CheckBoxWebControl : WebControl
    {
        public CheckBoxWebControl(IWebDriver driver, string webElementToFind, string findElementBy) 
            : base(driver, webElementToFind, findElementBy)
        {
        }

        public CheckBoxWebControl(IWebDriver driver, string webElementToFind, string findElementBy, int waitSecond) 
            : base(driver, webElementToFind, findElementBy, waitSecond)
        {
        }

        public void ClickCheckBox()
        {
            control.Click();
        }
    }
}
