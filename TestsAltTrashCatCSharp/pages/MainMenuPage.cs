using AltTester.AltDriver;

namespace alttrashcat_tests_csharp.pages
{
    public class MainMenuPage : BasePage
    {
        public MainMenuPage(AltDriver driver) : base(driver)
        {
        }
        public void LoadScene()
        {
            Driver.LoadScene("Main");
        }

        public AltObject StoreButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/StoreButton", timeout: 10); }
        public AltObject LeaderBoardButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/OpenLeaderboard", timeout: 10); }
        public AltObject SettingsButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/SettingButton", timeout: 10); }
        public AltObject MissionButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/MissionButton", timeout: 10); }
        public AltObject RunButton { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/StartButton", timeout: 10); }
        public AltObject CharacterName { get => Driver.WaitForObject(By.NAME, "CharName", timeout: 10); }
        public AltObject ThemeName { get => Driver.WaitForObject(By.NAME, "UICamera/Loadout/ThemeZone", timeout: 10); }
        public bool IsDisplayed()
        {
            if (StoreButton != null && LeaderBoardButton != null && SettingsButton != null && MissionButton != null && RunButton != null && CharacterName != null && ThemeName != null)
                return true;
            return false;
        }
        public void PressRun()
        {
            RunButton.Tap();
        }

    }
}