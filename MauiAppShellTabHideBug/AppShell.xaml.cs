namespace MauiAppShellTabHideBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        // bug: It's OK on Windows platfore, but has bug on Android platform.
        Tab2.IsVisible = true;
        Tab3.IsVisible = true;
        Tab1.IsVisible = false;
    }
    private void MenuItem2_Clicked(object sender, EventArgs e)
    {
        // bug: It's OK on Android platfore, but has bug on Windows platform.
        Tab1.IsVisible = false;
        Tab2.IsVisible = true;
        Tab3.IsVisible = true;
    }
}
