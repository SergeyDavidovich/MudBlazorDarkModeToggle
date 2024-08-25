namespace MudBlazorDarkModeToggle.Services
{
    public class DarkModeState
    {
        private bool _isDarkMode;

        public void SetIsDarkMode(bool isDarkMode)
        {
            _isDarkMode = isDarkMode;
        }

        public bool GetIsDarkMode()
        {
            return _isDarkMode;
        }
    }
}
