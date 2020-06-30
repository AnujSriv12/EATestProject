using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EAAutoFramework.Extensions
{
    public static class WebElementExtensions
    {

        public static string GetSelectedDropDown(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions.First().ToString();
        }

        public static IList<IWebElement> GetSelectedListOptions(this IWebElement element)
        {
            SelectElement ddl = new SelectElement(element);
            return ddl.AllSelectedOptions;
        }

        public static string GetLinkText(this IWebElement element)
        {
            return element.Text;
        }

        public static void SelectDropdownList(this IWebElement element, string value)
        {
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }

        public static void Hover(this IWebElement element)
        {
            Actions action = new Actions(DriverContext.Driver);
            action.MoveToElement(element).Perform();

        }

        public static void AssertElementPresent(this IWebElement element)
        {
            if (!IsElementPresent(element))
            {
                throw new Exception("Element Not Present");
            }
        }

        public static bool IsElementPresent(IWebElement element)
        {
            try
            {
                bool ele = element.Displayed;
                return true;
            }
            catch (System.Exception)
            {
                return false;
            }
        }
    }
}
