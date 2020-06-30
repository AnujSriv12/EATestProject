using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {

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
        }

        public HomePage ClickLoginButton()
        {
            btnLogin.Submit();
            return GetInstance<HomePage>();
        }

        internal void CheckIfLoginExist()
        {
            txtUserName.AssertElementPresent();
        }
    }
}
