using  alttrashcat_tests_csharp.pages;
using System;
using System.Threading;
using NUnit.Framework;
using Altom.AltUnityDriver;
namespace alttrashcat_tests_csharp.tests
{
    public class MainMenuTests
    {
        AltUnityDriver altUnityDriver;
        MainMenuPage mainMenuPage;
        [OneTimeSetUp]
        public void SetUp()
        {
            altUnityDriver = new AltUnityDriver(port: 13000);
            mainMenuPage = new MainMenuPage(altUnityDriver);
            mainMenuPage.LoadScene();


        }

        [OneTimeTearDown]
        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }
        // public MainMenuTests()
        // {
        //     altUnityDriver = new AltUnityDriver();
        //     mainMenuPage = new MainMenuPage(altUnityDriver);
        //     mainMenuPage.LoadScene();

        // }

            
        [Test]
        public void TestMainMenuPageLoadedCorrectly(){
            Assert.True(mainMenuPage.IsDisplayed());
        }
    }
}