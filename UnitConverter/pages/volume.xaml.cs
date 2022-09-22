namespace UnitConverter.pages;

public partial class volume : ContentPage
{
	public volume()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_8(object sender, EventArgs e)
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
                label2.Text = (a2 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = (a3 * 1000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a4);
                label4.Text = (a4 * 35.3147).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a5);
                label5.Text = (a5 * 61023.7).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a6);
                label6.Text = (a6 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a7);
                label7.Text = (a7 * 264.172).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a8);
                label8.Text = (a8 * 2113.380).ToString("#,##0.###");
                break;

            case 1:
                float.TryParse(entry.Text, out float b1);
                label1.Text = (b1 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b2);
                label2.Text = (b2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b3);
                label3.Text = (b3 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b4);
                label4.Text = (b4 * 0.035315).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b5);
                label5.Text = (b5 * 61.0237).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b6);
                label6.Text = (b6).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b7);
                label7.Text = (b7 * 0.264172).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b8);
                label8.Text = (b8 * 2.11338).ToString("#,##0.###");
                break;

            case 2:
                float.TryParse(entry.Text, out float c1);
                label1.Text = (c1 * 0.000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c2);
                label2.Text = (c2 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c3);
                label3.Text = (c3).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c4);
                label4.Text = (c4 * 0.00003532).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c5);
                label5.Text = (c5 * 0.0610237).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c6);
                label6.Text = (c6 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c7);
                label7.Text = (c7 * 0.00026417).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c8);
                label8.Text = (c8 * 0.00211338).ToString("#,##0.###");
                break;

            case 3:
                float.TryParse(entry.Text, out float d1);
                label1.Text = (d1 * 0.028317).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d2);
                label2.Text = (d2 * 28.3168).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d3);
                label3.Text = (d3 * 28316.8).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d4);
                label4.Text = (d4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d5);
                label5.Text = (d5 * 1728).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d6);
                label6.Text = (d6 * 28.3168).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d7);
                label7.Text = (d7 * 7.48052).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d8);
                label8.Text = (d8 * 59.8442).ToString("#,##0.###");
                break;

            case 4:
                float.TryParse(entry.Text, out float e1);
                label1.Text = (e1 * 0.00001639).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e2);
                label2.Text = (e2 * 0.0163871).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e3);
                label3.Text = (e3 * 1.63871).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e4);
                label4.Text = (e4 * 0.0005787).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e5);
                label5.Text = (e5).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e6);
                label6.Text = (e6 * 0.0163871).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e7);
                label7.Text = (e7 * 0.004329).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e8);
                label8.Text = (e8 * 0.034632).ToString("#,##0.###");
                break;

            case 5:
                float.TryParse(entry.Text, out float f1);
                label1.Text = (f1 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f2);
                label2.Text = (f2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f3);
                label3.Text = (f3 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f4);
                label4.Text = (f4 * 0.035315).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f5);
                label5.Text = (f5 * 61.0237).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f6);
                label6.Text = (f6).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f7);
                label7.Text = (f7 * 0.264172).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f8);
                label8.Text = (f8 * 2.11338).ToString("#,##0.###");
                break;

            case 6:
                float.TryParse(entry.Text, out float g1);
                label1.Text = (g1 * 0.00378).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g2);
                label2.Text = (g2 * 3.78541).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g3);
                label3.Text = (g3 * 3785.41).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g4);
                label4.Text = (g4 * 0.133681).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g5);
                label5.Text = (g5 * 231).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g6);
                label6.Text = (g6 * 3.78541).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g7);
                label7.Text = (g7).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g8);
                label8.Text = (g8 * 8).ToString("#,##0.###");
                break;

            case 7:
                float.TryParse(entry.Text, out float h1);
                label1.Text = (h1 * 0.000473).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h2);
                label2.Text = (h2 * 0.473176).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h3);
                label3.Text = (h3 * 473.176).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h4);
                label4.Text = (h4 * 0.01671).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h5);
                label5.Text = (h5 * 28.875).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h6);
                label6.Text = (h6 * 0.473176).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h7);
                label7.Text = (h7 / 8).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h8);
                label8.Text = (h8).ToString("#,##0.###");
                break;
        }
    }
}