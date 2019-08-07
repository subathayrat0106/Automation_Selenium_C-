using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Yorkland_Admin_Library.WebControls
{
    internal class MessageWebControl : WebControl
    {
        public MessageWebControl(IWebDriver driver, string webElementToFind, string findElementBy) 
            : base(driver, webElementToFind, findElementBy)
        {
        }

        public MessageWebControl(IWebDriver driver, string webElementToFind, string findElementBy, int waitSecond) 
            : base(driver, webElementToFind, findElementBy, waitSecond)
        {
        }

        public String getMessage()
        {
            return control.Text;
        }
    }
}
