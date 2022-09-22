namespace UnitConverter.pages;

public partial class speed : ContentPage
{
	public speed()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_7(object sender, EventArgs e)
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
                label2.Text = (a2 * 1.09728).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = (a3 * 0.681818).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a4);
                label4.Text = (a4 * 0.3048).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a5);
                label5.Text = (a5 * 18.288).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a6);
                label6.Text = (a6 * 1097.28).ToString("#,##0.###");
                break;

            case 1:
                float.TryParse(entry.Text, out float b1);
                label1.Text = (b1 * 0.91134).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b2);
                label2.Text = (b2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b3);
                label3.Text = (b3 * 0.62137).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b4);
                label4.Text = (b4 * 0.27778).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b5);
                label5.Text = (b5 * 16.66667).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b6);
                label6.Text = (b6 * 1000).ToString("#,##0.###");
                break;

            case 2:
                float.TryParse(entry.Text, out float c1);
                label1.Text = (c1 * 1.46667).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c2);
                label2.Text = (c2 * 1.60934).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c3);
                label3.Text = (c3).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c4);
                label4.Text = (c4 * 0.44704).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c5);
                label5.Text = (c5 * 26.8224).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c6);
                label6.Text = (c6 * 1609.344).ToString("#,##0.###");
                break;

            case 3:
                float.TryParse(entry.Text, out float d1);
                label1.Text = (d1 * 3.28084).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d2);
                label2.Text = (d2 * 3.6).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d3);
                label3.Text = (d3 * 2.236936).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d4);
                label4.Text = (d4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d5);
                label5.Text = (d5 * 60).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d6);
                label6.Text = (d6 * 3600).ToString("#,##0.###");
                break;

            case 4:
                float.TryParse(entry.Text, out float e1);
                label1.Text = (e1 * 0.054681).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e2);
                label2.Text = (e2 * 0.06).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e3);
                label3.Text = (e3 * 0.037282).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e4);
                label4.Text = (e4 * 0.016667).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e5);
                label5.Text = (e5).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e6);
                label6.Text = (e6 * 60).ToString("#,##0.###");
                break;

            case 5:
                float.TryParse(entry.Text, out float f1);
                label1.Text = (f1 * 0.000911).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f2);
                label2.Text = (f2 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f3);
                label3.Text = (f3 * 0.000621).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f4);
                label4.Text = (f4 * 0.000278).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f5);
                label5.Text = (f5 * 0.016667).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f6);
                label6.Text = (f6).ToString("#,##0.###");
                break;
        }
    }
}