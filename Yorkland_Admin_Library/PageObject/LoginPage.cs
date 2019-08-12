using OpenQA.Selenium;
using Yorkland_Admin_Library.WebControls;

namespace Yorkland_Admin_Library.PageObject
{
    internal class LoginPage : BasePageObject
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public LoginPage(IWebDriver driver, string baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        private readonly string textBox_userName = "inputUsername";
        private readonly string textBox_password = "inputPassword";
        private readonly string button_signIn = "signinButton";
        private readonly string link_signUp = "SignUp";
        private readonly string link_home = "Home";
        private readonly string link_forgetMyPassword = "Forgot my password";


        public LoginPage Enter_username(string userName)
        {
            TextBoxWebControl userNameTextBoxControl = new TextBoxWebControl(driver, textBox_userName, findById);
            userNameTextBoxControl.EnterText(userName);
            return this;
        }

        public LoginPage Enter_password(string password)
        {
            TextBoxWebControl passwordTextBoxControl = new TextBoxWebControl(driver, textBox_password, findById);
            passwordTextBoxControl.EnterText(password);
            return this;
        }

        public LoginPage Click_signInButton()
        {
            ButtonWebControl signInButtonWebControl = new ButtonWebControl(driver, button_signIn, findById);
            signInButtonWebControl.ClickButton();
            return this;
        }

        public LoginPage Click_signUpLink()
        {
            LinkWebControl signUpLinkWebControl = new LinkWebControl(driver, link_signUp, findByLinkText);
            signUpLinkWebControl.ClickLinkText();
            return this;
        }

        public LoginPage Click_homeLink()
        {
            LinkWebControl homeLinkWebControl = new LinkWebControl(driver, link_home, findByLinkText);
            homeLinkWebControl.ClickLinkText();
            return this;
        }

        public LoginPage Click_forgetMyPasswordLink()
        {
            LinkWebControl forgetMyPasswordLinkWebControl = new LinkWebControl(driver, link_forgetMyPassword, findByLinkText);
            forgetMyPasswordLinkWebControl.ClickLinkText();
            return this;
        }
    }
}
