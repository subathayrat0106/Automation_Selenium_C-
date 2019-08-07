using System;
using OpenQA.Selenium;

namespace Yorkland_Admin_Library.WebControls
{
    internal class TableWebControl : ListWebControl
    {
        public TableWebControl(IWebDriver driver, string webElementToFind, string findElementBy) : base(driver, webElementToFind, findElementBy)
        {
        }

        public void Click_ItemName(String name)
        {
            foreach( IWebElement element in control)
            {
                if(element.Text.Contains(name))
                {
                    element.Click();
                    break;
                }
            }
        }

        public void Click_RandomItemName()
        {
            Random random = new Random();
            int number = random.Next(control.Count);
            control[number].Click();
        }

        public int SelectOddNumber()
        {
            int [] oddNumber = new int[(control.Count) / 2];
            int k = 0;
            for (int i = 1; i <= control.Count; i++)
            {
                if (i % 2 != 0)
                {
                    oddNumber[k] = i;
                    k++;
                }
            }
            Random rand = new Random();
            int oddSingleNumber = oddNumber[rand.Next(oddNumber.Length)];
            return oddSingleNumber;
        }
    }

}
