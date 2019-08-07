﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Yorkland_Admin_Library.WebControls
{
    internal class TextBoxWebControl : WebControl
    {
        public TextBoxWebControl(IWebDriver driver, string webElementToFind, string findElementBy) 
            : base(driver, webElementToFind, findElementBy)
        {
        }

        public TextBoxWebControl(IWebDriver driver, string webElementToFind, string findElementBy, int waitSecond) 
            : base(driver, webElementToFind, findElementBy, waitSecond)
        {
        }

        public void EnterText(string text)
        {
            control.SendKeys(text);
        }

        public void ClearTextField()
        {
            control.Clear();
        }
    }
}
