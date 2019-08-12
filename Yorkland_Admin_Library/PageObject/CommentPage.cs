using OpenQA.Selenium;
using Yorkland_Admin_Library.WebControls;

namespace Yorkland_Admin_Library.PageObject
{
    internal class CommentPage : BasePageObject
    {
        public CommentPage(IWebDriver driver) : base(driver)
        {
        }

        public CommentPage(IWebDriver driver, string baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        private readonly string textBox_commentTitle = "comment[title]";
        private readonly string textBox_commentContent = "comment[text]";
        private readonly string button_submit = "submitButton";

        public CommentPage Enter_commentTitle(string title)
        {
            TextBoxWebControl commentTitleWebControl = new TextBoxWebControl(driver, textBox_commentTitle, findByName);
            if (title != "")
            {
                commentTitleWebControl.ClearTextField();
                commentTitleWebControl.EnterText(title);
            }
            return this;
        }

        public CommentPage Enter_commentContent(string content)
        {
            TextBoxWebControl commentContentWebControl = new TextBoxWebControl(driver, textBox_commentContent, findByName);
            if (content != "")
            {
                commentContentWebControl.ClearTextField();
                commentContentWebControl.EnterText(content);
            }
            return this;
        }

        public CommentPage Click_submitButton()
        {
            ButtonWebControl submitWebControl = new ButtonWebControl(driver, button_submit, findById);
            submitWebControl.ClickButton();
            return this;
        }
    }
}
