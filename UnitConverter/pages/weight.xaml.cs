namespace UnitConverter.pages;

public partial class weight : ContentPage
{
	public weight()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_11(object sender, EventArgs e)
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
                label2.Text = (a2 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = (a3 * 0.000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a4);
                label4.Text = (a4 * 0.000000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a5);
                label5.Text = (a5 * 0.000000000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a6);
                label6.Text = (a6 * 0.000000000157).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a7);
                label7.Text = (a7 * 0.000000002205).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a8);
                label8.Text = (a8 * 0.000000035274).ToString("#,##0.###");
                break;

            case 1:
                float.TryParse(entry.Text, out float b1);
                label1.Text = (b1 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b2);
                label2.Text = (b2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b3);
                label3.Text = (b3 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b4);
                label4.Text = (b4 * 0.000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b5);
                label5.Text = (b5 * 0.000000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b6);
                label6.Text = (b6 * 0.00000015747).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b7);
                label7.Text = (b7 * 0.0000022046).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b8);
                label8.Text = (b8 * 0.000035274).ToString("#,##0.###");
                break;

            case 2:
                float.TryParse(entry.Text, out float c1);
                label1.Text = (c1 * 1000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c2);
                label2.Text = (c2 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c3);
                label3.Text = (c3).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c4);
                label4.Text = (c4 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c5);
                label5.Text = (c5 * 0.000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c6);
                label6.Text = (c6 * 0.00015747).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c7);
                label7.Text = (c7 * 0.00220462).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c8);
                label8.Text = (c8 * 0.035274).ToString("#,##0.###");
                break;

            case 3:
                float.TryParse(entry.Text, out float d1);
                label1.Text = (d1 * 1000000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d2);
                label2.Text = (d2 * 1000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d3);
                label3.Text = (d3 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d4);
                label4.Text = (d4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d5);
                label5.Text = (d5 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d6);
                label6.Text = (d6 * 0.157473).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d7);
                label7.Text = (d7 * 2.20462).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d8);
                label8.Text = (d8 * 35.274).ToString("#,##0.###");
                break;

            case 4:
                float.TryParse(entry.Text, out float e1);
                label1.Text = (e1 * 1000000000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e2);
                label2.Text = (e2 * 1000000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e3);
                label3.Text = (e3 * 1000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e4);
                label4.Text = (e4 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e5);
                label5.Text = (e5).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e6);
                label6.Text = (e6 * 157.473).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e7);
                label7.Text = (e7 * 2204.62).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e8);
                label8.Text = (e8 * 35274).ToString("#,##0.###");
                break;

            case 5:
                float.TryParse(entry.Text, out float f1);
                label1.Text = (f1 * 6350000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f2);
                label2.Text = (f2 * 6350000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f3);
                label3.Text = (f3 * 6350.29).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f4);
                label4.Text = (f4 * 6.35).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f5);
                label5.Text = (f5 * 0.00635).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f6);
                label6.Text = (f6).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f7);
                label7.Text = (f7 * 14).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f8);
                label8.Text = (f8 * 224).ToString("#,##0.###");
                break;

            case 6:
                float.TryParse(entry.Text, out float g1);
                label1.Text = (g1 * 453600000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g2);
                label2.Text = (g2 * 453592).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g3);
                label3.Text = (g3 * 453.592).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g4);
                label4.Text = (g4 * 0.453592).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g5);
                label5.Text = (g5 * 0.000454).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g6);
                label6.Text = (g6 * 0.071429).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g7);
                label7.Text = (g7).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g8);
                label8.Text = (g8 * 16).ToString("#,##0.###");
                break;

            case 7:
                float.TryParse(entry.Text, out float h1);
                label1.Text = (h1 * 28350000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h2);
                label2.Text = (h2 * 28349.5).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h3);
                label3.Text = (h3 * 28.35).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h4);
                label4.Text = (h4 * 0.02835).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h5);
                label5.Text = (h5 * 0.000028).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h6);
                label6.Text = (h6 * 0.004464).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h7);
                label7.Text = (h7 * 0.0625).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h8);
                label8.Text = (h8).ToString("#,##0.###");
                break;
        }
    }
}