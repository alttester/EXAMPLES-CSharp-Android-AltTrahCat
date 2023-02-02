using AltTester.AltDriver;

namespace alttrashcat_tests_csharp.pages
{
    public class PauseOverlayPage : BasePage
    {
        public PauseOverlayPage(AltDriver driver) : base(driver)
        {
        }

        public AltObject ResumeButton { get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Resume", timeout: 2); }
        public AltObject MainMenuButton { get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Exit", timeout: 2); }
        public AltObject Title { get => Driver.WaitForObject(By.NAME, "Game/PauseMenu/Text", timeout: 2); }

        public bool IsDisplayed()
        {
            if (ResumeButton != null && MainMenuButton != null && Title != null)
                return true;
            return false;
        }
        public void PressResume()
        {
            ResumeButton.Tap();
        }
        public void PressMainMenu()
        {
            MainMenuButton.Tap();
        }
    }
}