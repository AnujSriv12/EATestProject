using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace EAEmployeeTest.Pages
{
    internal class EmployeeListPage : BasePage
    {
        [FindsBy(How = How.LinkText, Using = "searchTerm")]
        public IWebElement txtSearch { get; set; }

        [FindsBy(How = How.LinkText, Using = "Create New")]
        public IWebElement lnkCreateNew { get; set; }

        public CreateEmployeePage ClickCreateNew()
        {
            lnkCreateNew.Click();
            return new CreateEmployeePage();
        }
    }
}
