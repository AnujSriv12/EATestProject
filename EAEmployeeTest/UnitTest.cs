using EAAutoFramework.Base;
using EAAutoFramework.Helpers;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EAAutoFramework.Config;
using static EAAutoFramework.Base.Browser;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest : HookInitialize
    {

        /*[TestMethod]
        public void TestSelenium()
        {
            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";
            ExcelHelpers.PopulateInCollection(fileName);
            LogHelpers.Write("Navigated to the page !!!");
            DriverContext.Driver.Manage().Window.Maximize();

            //Login Page
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().CheckIfLoginExist();
            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1,"UserName"), ExcelHelpers.ReadData(1, "Password"));

            //Employee Page
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
            CurrentPage.As<EmployeeListPage>().ClickCreateNew();
        }*/

        [TestCleanup]
        public void tearDown()
        {
            DriverContext.Driver.Quit();
        }
    }
}
