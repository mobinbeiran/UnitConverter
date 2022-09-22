namespace UnitConverter.pages;

public partial class time : ContentPage
{
	public time()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_5(object sender, EventArgs e)
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
                label2.Text = (a2 / 60).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = (a3 / 3600).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a4);
                label4.Text = (a4 / 86400).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a5);
                label5.Text = (a5 / 2629743.833).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a6);
                label6.Text = (a6 / 31556926).ToString("#,##0.###");
                break;

            case 1:
                float.TryParse(entry.Text, out float b1);
                label1.Text = (b1 * 60).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b2);
                label2.Text = (b2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b3);
                label3.Text = (b3 / 60).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b4);
                label4.Text = (b4 / 1440).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b5);
                label5.Text = (b5 * 44662.397).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b6);
                label6.Text = (b6 * 525948.766).ToString("#,##0.###");
                break;

            case 2:
                float.TryParse(entry.Text, out float c1);
                label1.Text = (c1 * 3600).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c2);
                label2.Text = (c2 * 60).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c3);
                label3.Text = (c3).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c4);
                label4.Text = (c4 / 24).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c5);
                label5.Text = (c5 / 730.484).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c6);
                label6.Text = (c6 / 8765.812).ToString("#,##0.###");
                break;

            case 3:
                float.TryParse(entry.Text, out float d1);
                label1.Text = (d1 * 86400).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d2);
                label2.Text = (d2 * 1440).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d3);
                label3.Text = (d3 * 24).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d4);
                label4.Text = (d4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d5);
                label5.Text = (d5 / 30.436).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d6);
                label6.Text = (d6 / 365.242).ToString("#,##0.###");
                break;

            case 4:
                float.TryParse(entry.Text, out float e1);
                label1.Text = (e1 * 2629743.83).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e2);
                label2.Text = (e2 * 43829.064).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e3);
                label3.Text = (e3 * 730.484).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e4);
                label4.Text = (e4 * 30.437).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e5);
                label5.Text = (e5).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e6);
                label6.Text = (e6 / 12).ToString("#,##0.###");
                break;

            case 5:
                float.TryParse(entry.Text, out float f1);
                label1.Text = (f1 * 31556926).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f2);
                label2.Text = (f2 * 525948.766).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f3);
                label3.Text = (f3 * 8760.813).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f4);
                label4.Text = (f4 * 365.242).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f5);
                label5.Text = (f5 * 12).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f6);
                label6.Text = (f6).ToString("#,##0.###");
                break;
        }
    }
}