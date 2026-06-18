using MudBlazor;

namespace Flashcard.Components.Layout
{
    public class MyTheme : MudTheme
    {
        public MyTheme() 
        { 
            PaletteLight = new PaletteLight()
            {
                Primary = "#CB7000", // Första knappen
                Secondary = "#FFCAA0", // Andra knappen
                Background = "#fdf6e3", // Body
                Surface = "#FFFFFF", // Paper, kort osv.
                TextPrimary = "#140600",
                TextSecondary = "#3E1E00",

                AppbarBackground = "#FF8F00",

                DrawerBackground = "#FFCAA0",
                DrawerText = "#191B1C",
                DrawerIcon = "#191B1C"
            };
        }
    }
}
