namespace MauiAppShellTabHideBug;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {
        // It's OK.
        //Tab1.IsVisible = false;

        Tab2.IsVisible = true;
        Tab3.IsVisible = true;

        // bug
        Tab1.IsVisible = false;
    }
}
