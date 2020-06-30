using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }

        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckIfLoginExist();
        }

        [Then(@"I click login link")]
        public void ThenIClickLoginLink()
        {
            CurrentPage = CurrentPage.As<HomePage>().ClickLogin();
        }

        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login(data.UserName,data.Password);
        }

        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            CurrentPage = CurrentPage.As<LoginPage>().ClickLoginButton();
        }

        [Then(@"I should see the username with hello")]
        public void ThenIShouldSeeTheUsernameWithHello()
        {
            if (CurrentPage.As<HomePage>().GetLoggedInUser().Contains("admin"))
            {
                System.Console.WriteLine("Success Login!!");
            }
            else
                System.Console.WriteLine("Login Failed!!!");
        }

    }
}
