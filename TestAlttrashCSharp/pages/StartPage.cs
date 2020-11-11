namespace alttrashcat_tests_csharp.pages
{
    public class StartPage:BasePage
    {
        public StartPage(AltUnityDriver driver) : base(driver)
        {
        }
    
        public void Load(){
            Driver.LoadScene("Start");
        }
        public AltUnityObject StartButton { get => Driver.WaitForObject(By.NAME, "StartButton", timeout:2); }
        public AltUnityObject StartText{get => Driver.WaitForObject(By.NAME, "StartText",timeout:2);}
        public AltUnityObject LogoImage{get => Driver.WaitForObject(By.NAME, "LogoImage", timeout:2);}
        public AltUnityObject UnityUrlButton{get => Driver.WaitForObject(By.NAME, "UnityURLButton", timeout:2);}
        public bool IsDisplayed(){
            if(StartButton!=null && StartText!=null && LogoImage!=null && UnityUrlButton!=null)
                return true;
            return false;
        }
        public void PressStart(){
            StartButton.Tap();
        }
        public string GetStartButtonText(){
            return StartButton.GetText();
        }
    }
}