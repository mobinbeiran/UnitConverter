namespace UnitConverter.pages;

public partial class temp : ContentPage
{
	public temp()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    //if picker index changed to anything beside the default value(-1), entry will be enabled and empty.
    private void picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        entry.IsEnabled = true;
        entry.Text = "";
    }

    //if entry text changes, the labels will change in their own specific way
    private void entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        switch (picker.SelectedIndex)
        {
            case 0:
                float.TryParse(entry.Text, out float a1);
                label1.Text = (a1).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a2);
                label2.Text = (a2 + 273.15).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = ((a3 * 1.8) + 32).ToString("#,##0.###");

                break;

            case 1:
                float.TryParse(entry.Text, out float b1);
                label1.Text = (b1 - 273.15).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b2);
                label2.Text = (b2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b3);
                label3.Text = (1.8 * (b3 - 273.15) + 32).ToString("#,##0.###");

                break;

            case 2:
                float.TryParse(entry.Text, out float c1);
                label1.Text = ((c1 - 32) * 0.5556).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c2);
                label2.Text = ((((c2 - 32) * 5) / 9) + 273.15).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c3);
                label3.Text = (c3).ToString("#,##0.###");

                break;
        }
    }
}