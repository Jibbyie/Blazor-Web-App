using Microsoft.AspNetCore.Components;
using MudBlazor;
using X00164441_CA3.Theme;

namespace X00164441_CA3.Shared
{
    public class MainLayoutBase : LayoutComponentBase
    {
        protected MudThemeProvider? MudThemeProvider { get; set; }
        protected DefaultTheme? DefaultTheme { get; set; } = new();
        protected bool IsDrawerOpened { get; set; }
        protected bool IsDarkMode { get; set;}

        protected void DrawerToggle()
         => IsDrawerOpened = !IsDrawerOpened;

        protected void DarkModeToggle()
         => IsDarkMode = !IsDarkMode;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                IsDarkMode = await MudThemeProvider!.GetSystemPreference();
                StateHasChanged();
            }
        }
    }
}
