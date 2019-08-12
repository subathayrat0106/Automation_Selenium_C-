using OpenQA.Selenium;
using Yorkland_Admin_Library.WebControls;

namespace Yorkland_Admin_Library.PageObject
{
    internal class BalancePage : BasePageObject
    {     
        private readonly string textBox_updateTuition = "update[updatedTuition]";
        private readonly string textBox_updateCredit = "update[updatedCredit]";
        private readonly string textBox_updateAfterSchoolFee = "update[updatedAfterSchoolFee]";
        private readonly string textBox_updateInsuranceFee = "update[updatedInsuranceFee]";
        private readonly string textBox_updateLunchFee = "update[updatedLunchFee]";
        private readonly string button_updateButton = "updatedButton";

        public BalancePage(IWebDriver driver) : base(driver)
        {
        }

        public BalancePage(IWebDriver driver, string baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        public BalancePage Enter_updateTuition(string tuition)
        {
            TextBoxWebControl updateTutition = new TextBoxWebControl(driver, textBox_updateTuition, findByName, 2);
            if (tuition != "")
            {
                updateTutition.ClearTextField();
                updateTutition.EnterText(tuition);
            }
            return this;
        }

        public BalancePage Enter_updateCredit(string credit)
        {
            TextBoxWebControl updatecreditWebControl = new TextBoxWebControl(driver, textBox_updateCredit, findByName);
            if (credit != "")
            {
                updatecreditWebControl.ClearTextField();
                updatecreditWebControl.EnterText(credit);
            }
            return this;
        }

        public BalancePage Enter_updateAfterSchoolFee(string afterSchoolFee)
        {
            TextBoxWebControl afterSchoolFeeWebControl = new TextBoxWebControl(driver, textBox_updateAfterSchoolFee, findByName);
            if (afterSchoolFee != "")
            {
                afterSchoolFeeWebControl.ClearTextField();
                afterSchoolFeeWebControl.EnterText(afterSchoolFee);
            }
            return this;
        }

        public BalancePage Enter_updateInsuranceFee(string insuranceFee)
        {
            TextBoxWebControl updateInsuranceFeeWebControl = new TextBoxWebControl(driver, textBox_updateInsuranceFee, findByName);
            if (insuranceFee != "")
            {
                updateInsuranceFeeWebControl.ClearTextField();
                updateInsuranceFeeWebControl.EnterText(insuranceFee);
            }
            return this;
        }

        public BalancePage Enter_updateLunchFee(string lunchFee)
        {
            TextBoxWebControl updateLunchFeeWebControl = new TextBoxWebControl(driver, textBox_updateLunchFee, findByName);
            if (lunchFee != "")
            {
                updateLunchFeeWebControl.ClearTextField();
                updateLunchFeeWebControl.EnterText(lunchFee);
            }
            return this;
        }

        public BalancePage Click_updateButton()
        {
            ButtonWebControl updateButtonWebControl = new ButtonWebControl(driver, button_updateButton, findById);
            updateButtonWebControl.ClickButton();
            return this;
        }
    }
}
