using OpenQA.Selenium;
using Yorkland_Admin_Library.WebControls;

namespace Yorkland_Admin_Library.PageObject
{
    internal class StudentPage : BasePageObject
    {
        public StudentPage(IWebDriver driver) : base(driver)
        {
        }

        public StudentPage(IWebDriver driver, string baseUrl, string path) : base(driver, baseUrl, path)
        {
        }

        private readonly string textBox_firstName = "firstName";
        private readonly string textBox_lastName = "lastName";
        private readonly string textBox_dob = "dob";
        private readonly string textBox_tuitionFee = "tuition";
        private readonly string textBox_numberOfCredit = "credit";
        private readonly string dropDown_studentEntryTime = "studentEntryTime";
        private readonly string textBox_afterSchoolProgram = "afterSchoolProgram";
        private readonly string textBox_afterSchoolFee = "afterSchoolFee";
        private readonly string textBox_InsuranceFee = "insuranceFee";
        private readonly string textBox_lunchFee = "lunchFee";
        private readonly string button_addStudent = "//button[@class='btn btn-lg btn-primary btn-block']";
        
        public StudentPage Enter_firstName(string firstName)
        {
            TextBoxWebControl firstNameWebControl = new TextBoxWebControl(driver, textBox_firstName, findByName);
            if (firstName != "")
            {
                firstNameWebControl.ClearTextField();
                firstNameWebControl.EnterText(firstName);
            }
            return this;
        }

        public StudentPage Enter_lastName(string lastName)
        {
            TextBoxWebControl lastNameWebControl = new TextBoxWebControl(driver, textBox_lastName, findByName);
            if (lastName != "")
            {
                lastNameWebControl.ClearTextField();
                lastNameWebControl.EnterText(lastName);
            }
            return this;
        }

        public StudentPage Enter_dob(string dob)
        {
            TextBoxWebControl dobWebControl = new TextBoxWebControl(driver, textBox_dob, findByName);
            if (dob != "")
            {
                dobWebControl.ClearTextField();
                dobWebControl.EnterText(dob);
            }
            return this;
        }

        public StudentPage Enter_tuitionFee(string tuition)
        {
            TextBoxWebControl tuitionFeeWebControl = new TextBoxWebControl(driver, textBox_tuitionFee, findByName);
            if (tuition != "")
            {
                tuitionFeeWebControl.ClearTextField();
                tuitionFeeWebControl.EnterText(tuition);
            }
            return this;
        }

        public StudentPage Enter_numberOfCredit(string credit)
        {
            TextBoxWebControl numberOfCreditWebControl = new TextBoxWebControl(driver, textBox_numberOfCredit, findByName);
            if (credit != "")
            {
                numberOfCreditWebControl.ClearTextField();
                numberOfCreditWebControl.EnterText(credit);
            }
            return this;
        }

        public StudentPage Dropdown_selectStudentEntryTime(int entryTimeDropDownIndex)
        {
            DropDownWebControl studentEntryTimeWebControl = new DropDownWebControl(driver, dropDown_studentEntryTime, findByName);
            studentEntryTimeWebControl.DropDownSelectByIndex(entryTimeDropDownIndex);
            return this;
        }

        public StudentPage Dropdown_selectStudentEntryTime(string entryTimeDropDown)
        {
            if (entryTimeDropDown != "")
            {
                DropDownWebControl studentEntryTimeWebControl = new DropDownWebControl(driver, dropDown_studentEntryTime, findByName);
                studentEntryTimeWebControl.DropDownSelectByText(entryTimeDropDown);
            }
            return this;
        }

        public StudentPage Enter_afterSchoolProgram(string afterSchoolProgram)
        {
            TextBoxWebControl afterSchoolProgameWebControl = new TextBoxWebControl(driver, textBox_afterSchoolProgram, findByName);
            if (afterSchoolProgram != "")
            {
                afterSchoolProgameWebControl.ClearTextField();
                afterSchoolProgameWebControl.EnterText(afterSchoolProgram);
            }
            return this;
        }

        public StudentPage Enter_afterSchoolProgramFee(string afterSchoolProgramFee)
        {
            TextBoxWebControl afterSchoolProgameFeeWebControl = new TextBoxWebControl(driver, textBox_afterSchoolFee, findByName);
            if (afterSchoolProgramFee != "")
            {
                afterSchoolProgameFeeWebControl.ClearTextField();
                afterSchoolProgameFeeWebControl.EnterText(afterSchoolProgramFee);
            }
            return this;
        }

        public StudentPage Enter_insuranceFee(string insuranceFee)
        {
            TextBoxWebControl insuranceFeeWebControl = new TextBoxWebControl(driver, textBox_InsuranceFee, findByName);
            if (insuranceFee != "")
            {
                insuranceFeeWebControl.ClearTextField();
                insuranceFeeWebControl.EnterText(insuranceFee);
            }
            return this;
        }

        public StudentPage Enter_lunchFee(string lunchFee)
        {
            TextBoxWebControl lunchFeeWebControl = new TextBoxWebControl(driver, textBox_lunchFee, findByName);
            if (lunchFee != "")
            {
                lunchFeeWebControl.ClearTextField();
                lunchFeeWebControl.EnterText(lunchFee);
            }
            return this;
        }

        public StudentPage Click_addStudent()
        {
            ButtonWebControl addStudentWebControl = new ButtonWebControl(driver, button_addStudent, findByXpath);
            addStudentWebControl.ClickButton();
            return this;
        }

        public int Select_randomStudentEntryTimeIndex()
        {
            DropDownWebControl studentEntryTimeIndexWebControl = new DropDownWebControl(driver, dropDown_studentEntryTime, findByName);
            int indexNumber = studentEntryTimeIndexWebControl.DropDownSelectByRandom();
            return indexNumber;
        }
    }
}
