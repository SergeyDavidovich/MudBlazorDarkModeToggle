using MudBlazorDarkModeToggle.Client.Services;
using MudBlazorDarkModeToggle.Services;

namespace MudBlazorDarkModeToggle.Endpoints
{
    public static class DarkModeEndpoints
    {
        public static void MapDarkModeEndpoints(this WebApplication app)
        {
            app.MapGet("api/darkMode", GetHandler);
            app.MapPost("api/darkMode", PostHandler);
        }

        private static IResult GetHandler(HttpContext context, DarkModeState darkModeState)
        {
            var isDarkMode = darkModeState.GetIsDarkMode();
            return Results.Ok(isDarkMode);
        }

        private static IResult PostHandler(HttpContext context, DarkModeState darkModeState, IsDarkModeJson isDarkModeJson)
        {
            darkModeState.SetIsDarkMode(isDarkModeJson.IsDarkMode);
            return Results.Ok();
        }
    }

    public class IsDarkModeJson
    {
        public bool IsDarkMode { get; set; }
    }
}
