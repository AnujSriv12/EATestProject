using EAAutoFramework.Base;
using TechTalk.SpecFlow;
using static EAAutoFramework.Base.Browser;

namespace EAEmployeeTest
{
    [Binding]
    public class HookInitialize :TestInitializeHook
    {
        public HookInitialize() : base(BrowserType.Chrome)
        {
            InitializeSettings();
            NavigateSite();
        }

        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }
    }
}
