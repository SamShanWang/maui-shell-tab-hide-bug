namespace MauiAppShellTabHideBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        // bug: It's OK in Android platfore, but has bug in Windows platform.
        //Tab1.IsVisible = false;

        Tab2.IsVisible = true;
        Tab3.IsVisible = true;

        // bug: It's OK in Windows platfore, but has bug in Android platform.
        Tab1.IsVisible = false;
    }
}
