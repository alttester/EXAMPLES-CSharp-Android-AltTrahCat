namespace alttrashcat_tests_csharp.pages
{
    public class PauseOverlayPage:BasePage
    {
        public PauseOverlayPage(AltUnityDriver driver) : base(driver)
        {
        }
        
        public AltUnityObject ResumeButton { get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Resume", timeout:2); }
        public AltUnityObject MainMenuButton{get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Exit", timeout:2);}
        public AltUnityObject Title{get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Text", timeout:2);}
        
        public bool IsDisplayed(){
            if(ResumeButton!=null && MainMenuButton!=null && Title!=null)
                return true;
            return false;
        }
        public void PressResume(){
            ResumeButton.Tap();
        }
        public void PressMainMenu(){
            MainMenuButton.Tap();
        }
    }
}