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
        [SetUp]
        public void SetUp()
        {
            AltUnityPortForwarding.ForwardAndroid();
            altUnityDriver = new AltUnityDriver(port: 13000);
            mainMenuPage = new MainMenuPage(altUnityDriver);
            mainMenuPage.LoadScene();


        }

        [TearDown]
        public void Dispose()
        {
            altUnityDriver.Stop();
            AltUnityPortForwarding.RemoveForwardAndroid();
            Thread.Sleep(1000);
        }
      

        [Test]
        public void TestMainMenuPageLoadedCorrectly(){
            Assert.True(mainMenuPage.IsDisplayed());
        }
    }
}