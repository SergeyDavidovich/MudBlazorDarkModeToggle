##  MudBlazorDarkModeToggle 1
## Description: 
The project is designed to configure dark mode switching in the MudBlazor web application.

Created using the MudBlazor CLI:
>  `dotnet new mudblazor --interactivity Auto --name MudBlazorDarkModeToggle --all-interactive --auth Individual`

## Links:
> - [Installation](https://mudblazor.com/getting-started/installation#online-playground)
> - [Layouts](https://www.mudblazor.com/getting-started/layouts#appbar-&-drawer) 
> - [Help with MudThemeProvider #4410](https://github.com/MudBlazor/MudBlazor/discussions/4410)
> - [Theming](https://mudblazor.com/customization/overview#dark-palette)


## How to read/write dark/light theme mode using cookies?

1. Install NuGet that works with cookies using this link - https://github.com/BitzArt/Blazor.Cookies?tab=readme-ov-file#installation
2. Inject `ICookieService` into `Home.razor` and retrive the **dark mode** from the cookies this way:
> Here `_isDarkMode` is variable that is binded to `MudThemeProvider`'s `IsDarkMode` value

> `CookieService` is inject into your component
```
var cookie = await CookieService.GetAsync("IsDarkMode");
if (cookie is null)
{
    _isDarkMode = false;
}
else
{
    _isDarkMode = bool.Parse(cookie.Value);
}
```

> It is very high possibility that you use pre-rendering so don't forget to persist the dark mode so you don't experience flickering. Here is the
link on how to persist the state after pre-rendering - https://learn.microsoft.com/en-us/aspnet/core/blazor/components/prerender?view=aspnetcore-8.0#persist-prerendered-state

3. You write value to the cookies this way:

> `CookieService` is inject into your component
> Third parameter is the time span of how long this cookies will be stored
```
await CookieService.SetAsync("IsDarkMode", _isDarkMode.ToString(), new DateTimeOffset(DateTime.MaxValue));
```

You need to repeat this steps in `MainLayout.razor` component since this component is root component for all other components in our application.
In this component we have `MudThemeProvider` to which we set `IsDarkMode` value and so it apply dark mode to children components