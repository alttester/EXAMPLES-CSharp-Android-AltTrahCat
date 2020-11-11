namespace alttrashcat_tests_csharp.pages
{
    public class GetAnotherChancePage:BasePage
    {
        public GetAnotherChancePage(AltUnityDriver driver) : base(driver)
        {
        }
    
        public AltUnityObject GameOverButton { get => Driver.WaitForObject(By.NAME, "Game/DeathPopup/GameOver",timeout:2); }
        public AltUnityObject PremiumButton{get => Driver.WaitForObject(By.NAME, "Game/DeathPopup/ButtonLayout/Premium Button",timeout:2);}
        public AltUnityObject AvailableCurrency{get => Driver.WaitForObject(By.NAME, "Game/DeathPopup/PremiumDisplay/PremiumOwnCount",timeout:2);}
        
        public bool IsDisplayed(){
            if(GameOverButton!=null && PremiumButton!=null && AvailableCurrency!=null)
                return true;
            return false;
        }
        public void PressGameOver(){
            GameOverButton.Tap();
        }
        public void PressPremiumButton(){
            PremiumButton.Tap();
        }
    }
}