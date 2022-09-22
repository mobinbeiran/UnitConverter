namespace UnitConverter.pages;

public partial class pressure : ContentPage
{
	public pressure()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_9(object sender, EventArgs e)
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
                label2.Text = (a2 * 1.01325).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = (a3 * 101325).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a4);
                label4.Text = (a4 * 760).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a5);
                label5.Text = (a5 * 14.6959).ToString("#,##0.###");
                break;

            case 1:
                float.TryParse(entry.Text, out float b1);
                label1.Text = (b1 * 0.986923).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b2);
                label2.Text = (b2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b3);
                label3.Text = (b3 * 100000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b4);
                label4.Text = (b4 * 750.062).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b5);
                label5.Text = (b5 * 14.5038).ToString("#,##0.###");
                break;

            case 2:
                float.TryParse(entry.Text, out float c1);
                label1.Text = (c1 * 0.0000098692).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c2);
                label2.Text = (c2 * 0.00001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c3);
                label3.Text = (c3).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c4);
                label4.Text = (c4 * 0.00750062).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c5);
                label5.Text = (c5 * 0.000145038).ToString("#,##0.###");
                break;

            case 3:
                float.TryParse(entry.Text, out float d1);
                label1.Text = (d1 * 0.00131579).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d2);
                label2.Text = (d2 * 0.00133322).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d3);
                label3.Text = (d3 * 133.322).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d4);
                label4.Text = (d4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d5);
                label5.Text = (d5 * 0.0193368).ToString("#,##0.###"); ;
                break;

            case 4:
                float.TryParse(entry.Text, out float e1);
                label1.Text = (e1 * 0.068046).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e2);
                label2.Text = (e2 * 0.068948).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e3);
                label3.Text = (e3 * 6894.76).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e4);
                label4.Text = (e4 * 51.7149).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e5);
                label5.Text = (e5).ToString("#,##0.###");
                break;
        }
    }
}