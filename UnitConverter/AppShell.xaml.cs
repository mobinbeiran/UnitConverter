using UnitConverter.pages;

namespace UnitConverter;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

	//exit button in flyout
	private void Button_Clicked(object sender, EventArgs e)
	{
		System.Environment.Exit(0);
	}

	private async void Button_Clicked_1(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new about());
    }
}
