using EAAutoFramework.Config;
using EAAutoFramework.Helpers;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using static EAAutoFramework.Base.Browser;

namespace EAAutoFramework.Base
{
    public abstract class TestInitializeHook : Base
    {
        public readonly BrowserType Browser;

        public TestInitializeHook(BrowserType browser)
        {
            Browser = browser;
        }

        public void InitializeSettings()
        {
            //Set all  the settings for framework
            ConfigReader.SetFrameworkSettings();

            //Set Log
            LogHelpers.CreateLogFile();

            //Invoke Browser
            OpenBrowser(Browser);

            LogHelpers.Write("Initialized Framework");
        }
        private void OpenBrowser(BrowserType browserType = BrowserType.Chrome) // optional argument
        {
            switch (browserType)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
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

        public virtual void NavigateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Opened Chrome Browser !!!");
        }

    }
}
