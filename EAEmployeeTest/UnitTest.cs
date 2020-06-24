using EAAutoFramework.Base;
using EAAutoFramework.Helpers;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using EAAutoFramework.Config;
using static EAAutoFramework.Base.Browser;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest : Base
    {

        public void OpenBrowser(BrowserType browserType = BrowserType.Chrome) // optional argument
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser= new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.FireFox:
                    break;
                default:
                    break;
            }
        }

        [TestMethod]
        public void TestSelenium()
        {

            ConfigReader.SetFrameworkSettings();

            string fileName = Environment.CurrentDirectory.ToString() + "\\Data\\Login.xlsx";

            ExcelHelpers.PopulateInCollection(fileName);

            LogHelpers.CreateLogFile();

            OpenBrowser(BrowserType.Chrome);
            LogHelpers.Write("Opening Chrome Browser !!!");
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Navigated to the page !!!");
            DriverContext.Driver.Manage().Window.Maximize();

            /*LoginPage page = new LoginPage();
            page.ClickLoginLink();
            page.Login("admin", "password");

            CurrentPage = page.ClickEmployeeList();
            ((EmployeePage)CurrentPage).ClickCreateNew(); */

            //Login Page
            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().ClickLoginLink();
            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1,"UserName"), ExcelHelpers.ReadData(1, "Password"));

            //Employee Page
            CurrentPage = CurrentPage.As<LoginPage>().ClickEmployeeList();
            CurrentPage.As<EmployeePage>().ClickCreateNew();
        }

        [TestCleanup]
        public void tearDown()
        {
            DriverContext.Driver.Quit();
        }
    }
}
