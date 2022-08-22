using  alttrashcat_tests_csharp.pages;
using System;
using System.Threading;
using NUnit.Framework;
using Altom.AltUnityDriver;

// [assembly: CollectionBehavior(DisableTestParallelization = true)]
namespace alttrashcat_tests_csharp.tests
{
    public class StartPageTests : IDisposable
    {
        private AltUnityDriver altUnityDriver;
        private MainMenuPage mainMenuPage;
        private StartPage startPage;
       [SetUp]
       public void Setup(){
            AltUnityPortForwarding.ForwardAndroid();
            altUnityDriver=new AltUnityDriver();
            startPage=new StartPage(altUnityDriver);
            startPage.Load();
            mainMenuPage=new MainMenuPage(altUnityDriver);
        }
        [Test]
        public void TestStartPageLoadedCorrectly(){
            Assert.True(startPage.IsDisplayed());
        }
        [Test]
        public void TestStartButtonLoadMainMenu(){
            startPage.PressStart();
            Assert.True(mainMenuPage.IsDisplayed());
        }

        [TearDown]
        public void Dispose()
        {
            altUnityDriver.Stop();
            AltUnityPortForwarding.RemoveForwardAndroid();
            Thread.Sleep(1000);
        }
    }
}