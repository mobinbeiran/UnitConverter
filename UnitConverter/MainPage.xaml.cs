using UnitConverter.pages;

namespace UnitConverter;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	//page navigations
	private async void ImageButton_Clicked(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new lenght());
    }

	private async void ImageButton_Clicked_1(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new power());
    }

	private async void ImageButton_Clicked_2(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new temp());
    }

	private async void ImageButton_Clicked_3(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new area());
    }

	private async void ImageButton_Clicked_4(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new resolution());
    }

	private async void ImageButton_Clicked_5(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new time());
    }

	private async void ImageButton_Clicked_6(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new energy());
    }

	private async void ImageButton_Clicked_7(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new speed());
    }

	private async void ImageButton_Clicked_8(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new volume());
    }

	private async void ImageButton_Clicked_9(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new pressure());
    }

	private async void ImageButton_Clicked_10(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new memory());
    }

	private async void ImageButton_Clicked_11(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new weight());
    }
}

