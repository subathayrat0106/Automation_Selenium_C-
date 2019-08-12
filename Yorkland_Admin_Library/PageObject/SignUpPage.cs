using OpenQA.Selenium;
using Yorkland_Admin_Library.WebControls;

namespace Yorkland_Admin_Library.PageObject
{
    internal class SignUpPage : BasePageObject
    {
        public SignUpPage(IWebDriver driver) : base(driver)
        {
        }

        public SignUpPage(IWebDriver driver, string baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        private readonly string enter_userName = "username";
        private readonly string enter_passWord = "password";
        private readonly string enter_firstName = "firstName";
        private readonly string enter_lastName = "lastName";
        private readonly string enter_email = "email";
        private readonly string enter_adminCode = "adminCode";
        private readonly string button_signUp = "//button[@class='btn btn-lg btn-primary btn-block']";


        public SignUpPage Enter_userName(string userName)
        {
            TextBoxWebControl userNameWebControl = new TextBoxWebControl(driver, enter_userName, findByName);
            userNameWebControl.EnterText(userName);
            return this;
        }

        public SignUpPage Enter_password(string password)
        {
            TextBoxWebControl passwordWebControl = new TextBoxWebControl(driver, enter_passWord, findByName);
            passwordWebControl.EnterText(password);
            return this;
        }

        public SignUpPage Enter_firstName(string firstName)
        {
            TextBoxWebControl firstNameWebControl = new TextBoxWebControl(driver, enter_firstName, findByName);
            firstNameWebControl.EnterText(firstName);
            return this;
        }

        public SignUpPage Enter_lastName(string lastName)
        {
            TextBoxWebControl lastNameWebControl = new TextBoxWebControl(driver, enter_lastName, findByName);
            lastNameWebControl.EnterText(lastName);
            return this;
        }

        public SignUpPage Enter_email(string email)
        {
            TextBoxWebControl emailWebControl = new TextBoxWebControl(driver, enter_email, findByName);
            emailWebControl.EnterText(email);
            return this;
        }

        public SignUpPage Enter_adminCode(string adminCode)
        {
            TextBoxWebControl adminCodeWebControl = new TextBoxWebControl(driver, enter_adminCode, findByName);
            adminCodeWebControl.EnterText(adminCode);
            return this;
        }

        public SignUpPage Click_signUpButton()
        {
            ButtonWebControl signUpButtonWebControl = new ButtonWebControl(driver, button_signUp, findByXpath);
            signUpButtonWebControl.ClickButton();
            return this;
        }
    }
}
