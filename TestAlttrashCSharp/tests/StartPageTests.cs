using  alttrashcat_tests_csharp.pages;
using System;
using System.Threading;
using Xunit;
[assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace alttrashcat_tests_csharp.tests
{
    public class StartPageTests : IDisposable
    {
        private AltUnityDriver altUnityDriver;
        private MainMenuPage mainMenuPage;
        private StartPage startPage;
       public StartPageTests(){
            altUnityDriver=new AltUnityDriver();
            startPage=new StartPage(altUnityDriver);
            startPage.Load();
            mainMenuPage=new MainMenuPage(altUnityDriver);

        }
        [Fact]
        public void TestStartPageLoadedCorrectly(){
            Assert.True(startPage.IsDisplayed());
        }
        [Fact]
        public void TestStartButtonLoadMainMenu(){
            startPage.PressStart();
            Assert.True(mainMenuPage.IsDisplayed());
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }
    }
}