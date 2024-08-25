using MudBlazorDarkModeToggle.Client.Services;

namespace MudBlazorDarkModeToggle.Services
{
    public class ServerDarkModeService : IDarkModeService
    {
        private readonly DarkModeState _darkModeState;

        public ServerDarkModeService(DarkModeState darkModeState)
        {
            _darkModeState = darkModeState;
        }

        public async Task<bool> GetIsDarkMode()
        {
            await Task.CompletedTask;

            return _darkModeState.GetIsDarkMode();
        }

        public async Task SetIsDarkMode(bool isDarkMode)
        {
            await Task.CompletedTask;

            _darkModeState.SetIsDarkMode(isDarkMode);
        }
    }
}
