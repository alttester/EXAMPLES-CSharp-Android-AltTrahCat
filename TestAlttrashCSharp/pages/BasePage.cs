namespace alttrashcat_tests_csharp.pages
{
    public class BasePage
    {
        AltUnityDriver driver;

        public AltUnityDriver Driver { get => driver; set => driver = value; }
        public BasePage(AltUnityDriver driver){
            Driver=driver;
        }
    }
}