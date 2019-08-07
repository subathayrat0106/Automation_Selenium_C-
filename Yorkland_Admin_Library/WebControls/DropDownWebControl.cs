using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

namespace Yorkland_Admin_Library.WebControls
{
    internal class DropDownWebControl : WebControl
    {
        public DropDownWebControl(IWebDriver driver, string webElementToFind, string findElementBy) 
            : base(driver, webElementToFind, findElementBy)
        {
        }

        public DropDownWebControl(IWebDriver driver, string webElementToFind, string findElementBy, int waitSecond) 
            : base(driver, webElementToFind, findElementBy, waitSecond)
        {
        }

         public void DropDownSelectByText(string text)
        {
            SelectElement dropDown = new SelectElement(control);
            dropDown.SelectByText(text);
        }

        public void DropDownSelectByIndex(int index)
        {
            SelectElement dropDown = new SelectElement(control);
            dropDown.SelectByIndex(index);
        }

        public void DropDownSelectByValue(string value)
        {
            SelectElement dropDown = new SelectElement(control);
            dropDown.SelectByValue(value);
        }

        public void DropDownSelectByRandom()
        {
            SelectElement dropDown = new SelectElement(control);
            IList<IWebElement> dropDownElements = dropDown.Options;
            Random num = new Random();
            int index = num.Next(dropDownElements.Count);
            dropDown.SelectByIndex(index);
        }
    }
}
