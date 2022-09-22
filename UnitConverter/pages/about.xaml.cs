namespace UnitConverter.pages;

public partial class about : ContentPage
{
	public about()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}