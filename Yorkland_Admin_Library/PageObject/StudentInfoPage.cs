using OpenQA.Selenium;
using Yorkland_Admin_Library.WebControls;

namespace Yorkland_Admin_Library.PageObject
{
    internal class StudentInfoPage : BasePageObject
    {
        public StudentInfoPage(IWebDriver driver) : base(driver)
        {
        }

        public StudentInfoPage(IWebDriver driver, string baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        private readonly string button_editStudent = "//a[@class='btn btn-xs btn-warning']";
        private readonly string button_deleteStudent = "//button[@class='btn btn-xs btn-danger']";
        private readonly string button_addNewComment = "//a[text()='Add New Comment']";
        private readonly string tab_entryFee = "//a[@aria-controls='home']";
        private readonly string tab_balance = "//a[contains(@href, '#tab2')]";
        private readonly string button_addBalance = "addBalance";
        private readonly string button_editCommentList = "//*[@id='commentBox']//child::a";
        private readonly string button_deleteCommentList = "//*[@id='commentBox']//child::input";
        private readonly string button_editBalanceList = "//*[@id='v-pills-tab1']//a[@class='btn btn-sm btn-warning']";
        private readonly string button_deleteBalanceList = "//*[@id='v-pills-tab1']//child::input";
	
	public StudentInfoPage Click_editStudentButton()
        {
            ButtonWebControl editStudentWebControl = new ButtonWebControl(driver, button_editStudent, findByXpath, 5);
            editStudentWebControl.ClickButton();
            return this;
        }

        public StudentInfoPage Click_deleteStudentButton()
        {
            ButtonWebControl deleteStudentWebControl = new ButtonWebControl(driver, button_deleteStudent, findByXpath);
            deleteStudentWebControl.ClickButton();
            return this;
        }

        public StudentInfoPage Click_addNewCommentButton()
        {
            ButtonWebControl addNewCommentWebControl = new ButtonWebControl(driver, button_addNewComment, findByXpath);
            addNewCommentWebControl.ClickButton();
            return this;
        }

        public StudentInfoPage Click_entryFeeTab()
        {
            ButtonWebControl entryFeeTabWebControl = new ButtonWebControl(driver, tab_entryFee, findByXpath);
            entryFeeTabWebControl.ClickButton();
            return this;
        }

        public StudentInfoPage Click_balanceTab()
        {
            ButtonWebControl balaceTabWebControl = new ButtonWebControl(driver, tab_balance, findByXpath, 3);
            balaceTabWebControl.ClickButton();
            return this;
        }

        public StudentInfoPage Click_addBalanceButton()
        {
            ButtonWebControl addBalanceButtonWebControl = new ButtonWebControl(driver, button_addBalance, findById, 2);
            addBalanceButtonWebControl.ClickButton();
            return this;
        }

        public StudentInfoPage Click_editCommentButton(int eidtCommentNumber)
        {
            ListButtonWebControl editCommentButtonsWebControl = new ListButtonWebControl
                    (driver, button_editCommentList, findByXpath);
            editCommentButtonsWebControl.Click_NumberOfButton(eidtCommentNumber);
            return this;
        }

        public StudentInfoPage Click_editCommentButton()
        {
            TableWebControl editCommentButtonsWebControl = new TableWebControl
                    (driver, button_editCommentList, findByXpath);
            editCommentButtonsWebControl.Click_RandomItemName();
            return this;
        }

        public StudentInfoPage Click_deleteCommentButton(int deletCommentNumber)
        {
            ListButtonWebControl deletCommentButtonsWebControl = new ListButtonWebControl
                    (driver, button_deleteCommentList, findByXpath);
            deletCommentButtonsWebControl.Click_NumberOfButton(deletCommentNumber);
            return this;
        }

        public StudentInfoPage Click_deleteCommentButton()
        {
            TableWebControl deletCommentButtonsWebControl = new TableWebControl
                    (driver, button_deleteCommentList, findByXpath);
            deletCommentButtonsWebControl.Click_RandomItemName();
            return this;
        }

        public StudentInfoPage Click_theNumberOfEditBalanceButton(int number)
        {
            ListButtonWebControl editBalanceButtonsWebControl = new ListButtonWebControl
                    (driver, button_editBalanceList, findByXpath);
            editBalanceButtonsWebControl.Click_NumberOfButton(number);
            return this;
        }

        public StudentInfoPage Click_randomEditBalanceButton()
        {
            TableWebControl editBalanceButtonsWebControl = new TableWebControl
                    (driver, button_editBalanceList, findByXpath);
            editBalanceButtonsWebControl.Click_RandomItemName();
            return this;
        }

        public StudentInfoPage Click_deleteBalanceButton(int number)
        {
            ListButtonWebControl deletBalanceButtonsWebControl = new ListButtonWebControl
                    (driver, button_deleteBalanceList, findByXpath);
            deletBalanceButtonsWebControl.Click_NumberOfButton(number);
            return this;
        }

        public StudentInfoPage Click_randomDeleteBalanceButton()
        {
            TableWebControl deletBalanceButtonsWebControl = new TableWebControl
                    (driver, button_deleteBalanceList, findByXpath);
            deletBalanceButtonsWebControl.Click_RandomItemName();
            return this;
        }
    }
}
