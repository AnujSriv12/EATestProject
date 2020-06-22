using OpenQA.Selenium.Support.PageObjects;

namespace EAAutoFramework.Base
{
    public abstract class BasePage : Base
    {

        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);
        }

        
    }
}
