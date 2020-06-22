using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "Employee List")]
        IWebElement lnkEmployeeList { get; set; }

        [FindsBy(How = How.Id, Using = "loginLink")]
        IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.Id, Using = "UserName")]
        IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Id, Using = "Password")]
        IWebElement txtPassword { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.btn")]
        IWebElement btnLogin { get; set; }

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
        }

        public void ClickLoginLink()
        {
            lnkLogin.Click();
        }

        public EmployeePage ClickEmployeeList()
        {
           lnkEmployeeList.Click();
            return GetInstance<EmployeePage>();
        }


    }
}
