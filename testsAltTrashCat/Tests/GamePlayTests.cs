using  alttrashcat_tests_csharp.pages;
using System;
using System.Threading;
using Altom.AltUnityDriver;
using NUnit.Framework;

namespace alttrashcat_tests_csharp.tests
{
    public class GamePlayTests
    {
        AltUnityDriver altUnityDriver;
        MainMenuPage mainMenuPage;
        GamePlay gamePlayPage;
        PauseOverlayPage pauseOverlayPage;
        GetAnotherChancePage getAnotherChancePage;
        public GamePlayTests()
        {

            altUnityDriver=new AltUnityDriver();
            mainMenuPage=new MainMenuPage(altUnityDriver);
            mainMenuPage.LoadScene();
            mainMenuPage.PressRun();
            gamePlayPage=new GamePlay(altUnityDriver);
            pauseOverlayPage=new PauseOverlayPage(altUnityDriver);
            getAnotherChancePage=new GetAnotherChancePage(altUnityDriver);

        }
        [Test]
        public void TestGamePlayDisplayedCorrectly(){
            Assert.True(gamePlayPage.IsDisplayed());
        }
        [Test]
        public void TestGameCanBePausedAndResumed(){
            gamePlayPage.PressPause();
            Assert.True(pauseOverlayPage.IsDisplayed());
            pauseOverlayPage.PressResume();
            Assert.True(gamePlayPage.IsDisplayed());
        }
        [Test]
        public void TestGameCanBePausedAndStopped(){
            gamePlayPage.PressPause();
            pauseOverlayPage.PressMainMenu();
            Assert.True(mainMenuPage.IsDisplayed());
        }
        [Test]
        public void TestAvoidingObstacles(){
            gamePlayPage.AvoidObstacles(3);
            Assert.True(gamePlayPage.GetCurrentLife()>0);
        }
        [Test]
        public void TestPlayerDiesWhenObstacleNotAvoided(){
            float timeout=20;
            while(timeout>0){
                try{
                    getAnotherChancePage.IsDisplayed();
                    break;
                }
                catch (Exception){
                    timeout-=1;
                }
            }
            Assert.True(getAnotherChancePage.IsDisplayed());
        }

        public void Dispose()
        {
            altUnityDriver.Stop();
            Thread.Sleep(1000);
        }
    }
}