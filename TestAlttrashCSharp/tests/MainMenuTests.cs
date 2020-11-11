using  alttrashcat_tests_csharp.pages;
using System;
using System.Threading;
using Xunit;
namespace alttrashcat_tests_csharp.tests
{
    public class MainMenuTests:IDisposable
    {
        AltUnityDriver altUnityDriver;
        MainMenuPage mainMenuPage;

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }
        public MainMenuTests()
        {
            altUnityDriver = new AltUnityDriver();
            mainMenuPage = new MainMenuPage(altUnityDriver);
            mainMenuPage.LoadScene();

        }

            
        [Fact]
        public void TestMainMenuPageLoadedCorrectly(){
            Assert.True(mainMenuPage.IsDisplayed());
        }
    }
}