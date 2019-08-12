using System;
using OpenQA.Selenium;
using Yorkland_Admin_Library.WebControls;

namespace Yorkland_Admin_Library.PageObject
{
    internal class HomePage : BasePageObject
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public HomePage(IWebDriver driver, string baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        private readonly string button_addStudent = "//a[@class='btn btn-primary btn-lg']";
        private readonly string textBox_search = "search";
        private readonly string button_search = "//button[@class='btn btn-lg btn-info']";
        private readonly string link_logout = "Logout";
        private readonly string button_tuitionTab = "nav-home-tab";
        private readonly string button_afterSchoolTab = "nav-profile-tab";
        private readonly string button_otherTab = "nav-contact-tab";
        private readonly string button_listAddBalanceButton = "//*[contains (@href, 'fee/update')]";
        private readonly string element_listElementInTheTable = "//*[@id='nav-home']//*[contains(@href,'home')]";


        public HomePage Click_addStudentButton()
        {
            ButtonWebControl addStudentWebControl = new ButtonWebControl(driver, button_addStudent, findByXpath, 1);
            addStudentWebControl.ClickButton();
            return this;
        }

        public HomePage Enter_searchBox(string searchName)
        {
            TextBoxWebControl searchBoxWebControl = new TextBoxWebControl(driver, textBox_search, findByName);
            searchBoxWebControl.EnterText(searchName);
            return this;
        }

        public HomePage Click_searchButton()
        {
            ButtonWebControl searchButton = new ButtonWebControl(driver, button_search, findByXpath);
            searchButton.ClickButton();
            return this;
        }

        public HomePage Click_logOutLink()
        {
            LinkWebControl logoutLinkControl = new LinkWebControl(driver, link_logout, findByLinkText);
            logoutLinkControl.ClickLinkText();
            return this;
        }

        public HomePage Click_tuitionTab()
        {
            ButtonWebControl tuitionTabWebControl = new ButtonWebControl(driver, button_tuitionTab, findById);
            tuitionTabWebControl.ClickButton();
            return this;
        }

        public HomePage Click_afterSchoolTab()
        {
            ButtonWebControl afterSchoolTabWebControl = new ButtonWebControl(driver, button_afterSchoolTab, findById);
            afterSchoolTabWebControl.ClickButton();
            return this;
        }

        public HomePage Click_otherTab()
        {
            ButtonWebControl otherTabWebControl = new ButtonWebControl(driver, button_otherTab, findById);
            otherTabWebControl.ClickButton();
            return this;
        }

        public HomePage Click_studentName(string name)
        {
            string studentNameLocotor = String.Format("//*[@id='nav-home']//a[text()='%s']", name);
            ButtonWebControl studentNameWebControl = new ButtonWebControl(driver, studentNameLocotor, findByXpath, 2);
            studentNameWebControl.ClickButton();
            return this;
        }

        public HomePage Click_addBalanceViaStudentName(string name)
        {
            string addBalanceButton = String.Format("((//a[text()='%s'])[1]//following::a)[1]", name);
            ButtonWebControl addButtonWebControl = new ButtonWebControl(driver, addBalanceButton, findByXpath, 2);
            addButtonWebControl.ClickButton();
            return this;
        }

        public HomePage Click_addBalanceButtonOnRandomStudent()
        {
            TableWebControl randomAddBalanceWebControl = new TableWebControl(driver, button_listAddBalanceButton, findByXpath);
            randomAddBalanceWebControl.Click_RandomItemName();
            return this;
        }

        public HomePage Click_aRandomStudentFromTheTable()
        {
            TableWebControl listElementWebControl = new TableWebControl(driver, element_listElementInTheTable, findByXpath);
            string oddNumber = listElementWebControl.SelectOddNumber().ToString();
            string randomStudent = String.Format("(//*[@id='nav-home']//*[contains(@href,'home')])[%s]", oddNumber);
            ButtonWebControl randomStudentNameWebControl = new ButtonWebControl(driver, randomStudent, findByXpath, 2);
            randomStudentNameWebControl.ClickButton();
            return this;
        }
    }
}
