using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAAutoFramework.Base
{
    public static class DriverContext
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get
            {
                return _driver;
            }

            set
            {
                _driver = value;
            }

        }

        public static Browser Browser { get; set; }
    }
}
