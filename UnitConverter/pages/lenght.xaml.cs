namespace UnitConverter.pages;

public partial class lenght : ContentPage
{
	public lenght()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
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
                label2.Text = (a2 * 100).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = (a3 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a4);
                label4.Text = (a4 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a5);
                label5.Text = (a5 * 1.093613).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a6);
                label6.Text = (a6 * 0.000621).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a7);
                label7.Text = (a7 * 3.28084).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a8);
                label8.Text = (a8 * 39.370079).ToString("#,##0.###");
                break;

            case 1:
                float.TryParse(entry.Text, out float b1);
                label1.Text = (b1 * 0.01).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b2);
                label2.Text = (b2).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b3);
                label3.Text = (b3 * 10).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b4);
                label4.Text = (b4 * 0.00001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b5);
                label5.Text = (b5 * 0.010936).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b6);
                label6.Text = (b6 * 0.000006).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b7);
                label7.Text = (b7 * 0.032808).ToString("#,##0.###");

                float.TryParse(entry.Text, out float b8);
                label8.Text = (b8 * 0.393701).ToString("#,##0.###");
                break;

            case 2:
                float.TryParse(entry.Text, out float c1);
                label1.Text = (c1 * 0.001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c2);
                label2.Text = (c2 * 0.1).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c3);
                label3.Text = (c3).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c4);
                label4.Text = (c4 * 0.000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c5);
                label5.Text = (c5 * 0.0010936).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c6);
                label6.Text = (c6 * 0.000000621).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c7);
                label7.Text = (c7 * 0.00328084).ToString("#,##0.###");

                float.TryParse(entry.Text, out float c8);
                label8.Text = (c8 * 0.0393701).ToString("#,##0.###");
                break;

            case 3:
                float.TryParse(entry.Text, out float d1);
                label1.Text = (d1 * 1000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d2);
                label2.Text = (d2 * 100000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d3);
                label3.Text = (d3 * 1000000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d4);
                label4.Text = (d4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d5);
                label5.Text = (d5 * 1093.61).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d6);
                label6.Text = (d6 * 0.621371).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d7);
                label7.Text = (d7 * 3280.84).ToString("#,##0.###");

                float.TryParse(entry.Text, out float d8);
                label8.Text = (d8 * 39370.1).ToString("#,##0.###");
                break;

            case 4:
                float.TryParse(entry.Text, out float e1);
                label1.Text = (e1 * 0.9144).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e2);
                label2.Text = (e2 * 91.44).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e3);
                label3.Text = (e3 * 914.4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e4);
                label4.Text = (e4 * 0.000914).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e5);
                label5.Text = (e5).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e6);
                label6.Text = (e6 * 0.00056818).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e7);
                label7.Text = (e7 * 3).ToString("#,##0.###");

                float.TryParse(entry.Text, out float e8);
                label8.Text = (e8 * 36).ToString("#,##0.###");
                break;

            case 5:
                float.TryParse(entry.Text, out float f1);
                label1.Text = (f1 * 1609.35).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f2);
                label2.Text = (f2 * 160934).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f3);
                label3.Text = (f3 * 1609000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f4);
                label4.Text = (f4 * 1609).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f5);
                label5.Text = (f5 * 1760.007).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f6);
                label6.Text = (f6).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f7);
                label7.Text = (f7 * 5280.02).ToString("#,##0.###");

                float.TryParse(entry.Text, out float f8);
                label8.Text = (f8 * 63360.236).ToString("#,##0.###");
                break;

            case 6:
                float.TryParse(entry.Text, out float g1);
                label1.Text = (g1 * 0.3048).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g2);
                label2.Text = (g2 * 30.48).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g3);
                label3.Text = (g3 * 304.8).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g4);
                label4.Text = (g4 * 0.0003048).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g5);
                label5.Text = (g5 * 0.333333).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g6);
                label6.Text = (g6 * 0.000189).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g7);
                label7.Text = (g7).ToString("#,##0.###");

                float.TryParse(entry.Text, out float g8);
                label8.Text = (g8 * 12).ToString("#,##0.###");
                break;

            case 7:
                float.TryParse(entry.Text, out float h1);
                label1.Text = (h1 * 0.0254).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h2);
                label2.Text = (h2 * 2.54).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h3);
                label3.Text = (h3 * 25.4).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h4);
                label4.Text = (h4 * 0.0000254).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h5);
                label5.Text = (h5 * 0.277777).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h6);
                label6.Text = (h6 * 0.0000157).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h7);
                label7.Text = (h7 * 83.3333).ToString("#,##0.###");

                float.TryParse(entry.Text, out float h8);
                label8.Text = (h8).ToString("#,##0.###");
                break;
        }
    }
}