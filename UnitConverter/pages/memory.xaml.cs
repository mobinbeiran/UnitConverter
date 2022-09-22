namespace UnitConverter.pages;

public partial class memory : ContentPage
{
	public memory()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_10(object sender, EventArgs e)
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
                label2.Text = (a2 * 0.125).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = (a3 * 0.000125).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a4);
                label4.Text = (a4 * 0.000000125).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a5);
                label5.Text = (a5 * 0.000000000125).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a6);
                label6.Text = (a6 * 0.000000000000125).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a7);
                label7.Text = (a7 * 0.000000000000000125).ToString("#,##0.###");
                break;

            case 1:
                float.TryParse(entry.Text, out float b1);
                label1.Text = (b1 * 8).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b2);
                label2.Text = (b2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b3);
                label3.Text = (b3 * 0.000976562).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b4);
                label4.Text = (b4 * 0.000000954).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b5);
                label5.Text = (b5 * 0.000000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b6);
                label6.Text = (b6 * 0.0000000000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b7);
                label7.Text = (b7 * 0.000000000000001).ToString("#,##0.###");
                break;

            case 2:
                float.TryParse(entry.Text, out float c1);
                label1.Text = (c1 * 8000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c2);
                label2.Text = (c2 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c3);
                label3.Text = (c3).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c4);
                label4.Text = (c4 * 0.000976562).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c5);
                label5.Text = (c5 * 0.000000954).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c6);
                label6.Text = (c6 * 0.000000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c7);
                label7.Text = (c7 * 0.0000000000001).ToString("#,##0.###");
                break;

            case 3:
                float.TryParse(entry.Text, out float d1);
                label1.Text = (d1 * 8000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d2);
                label2.Text = (d2 * 1048576).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d3);
                label3.Text = (d3 * 1024).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d4);
                label4.Text = (d4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d5);
                label5.Text = (d5 * 0.000977).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d6);
                label6.Text = (d6 * 0.000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d7);
                label7.Text = (d7 * 0.000000001).ToString("#,##0.###");
                break;

            case 4:
                float.TryParse(entry.Text, out float e1);
                label1.Text = (e1 * 8000000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e2);
                label2.Text = (e2 * 1073741824).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e3);
                label3.Text = (e3 * 1048576).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e4);
                label4.Text = (e4 * 1024).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e5);
                label5.Text = (e5).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e6);
                label6.Text = (e6 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e7);
                label7.Text = (e7 * 0.000001).ToString("#,##0.###");
                break;

            case 5:
                float.TryParse(entry.Text, out float f1);
                label1.Text = (f1 * 8000000000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f2);
                label2.Text = (f2 * 1099511627776).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f3);
                label3.Text = (f3 * 1073741824).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f4);
                label4.Text = (f4 * 1048576).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f5);
                label5.Text = (f5 * 1024).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f6);
                label6.Text = (f6).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f7);
                label7.Text = (f7 * 0.001).ToString("#,##0.###");
                break;

            case 6:
                float.TryParse(entry.Text, out float g1);
                label1.Text = (g1 * 8000000000000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g2);
                label2.Text = (g2 * 1126999418470400).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g3);
                label3.Text = (g3 * 1099511627776).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g4);
                label4.Text = (g4 * 1073741824).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g5);
                label5.Text = (g5 * 1048576).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g6);
                label6.Text = (g6 * 1024).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g7);
                label7.Text = (g7).ToString("#,##0.###");
                break;
        }
    }
}