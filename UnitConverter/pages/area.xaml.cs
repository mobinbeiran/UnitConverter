namespace UnitConverter.pages;

public partial class area : ContentPage
{

    public area()
    {
        InitializeComponent();
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }

    //if picker index changed to anything beside the default value(-1), entry will be enabled and empty.
    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        entry.IsEnabled = true;
        entry.Text = "";
    }

    //if entry text changes, the labels will change in their own specific way
    public void entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        switch (picker.SelectedIndex)
        {
            case 0:
                float.TryParse(entry.Text, out float a1);
                label1.Text = (a1).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a2);
                label2.Text = (a2 * 10000).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a3);
                label3.Text = (a3 * 0.000001).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a4);
                label4.Text = (a4 * 10.76391).ToString("#,##0.###");

                float.TryParse(entry.Text, out float a5);
                label5.Text = (a5 * 1550.0031).ToString("#,##0.###");
                break;

                case 1:
                    float.TryParse(entry.Text, out float b1);
                    label1.Text = (b1 * 0.0001).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float b2);
                    label2.Text = (b2).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float b3);
                    label3.Text = (b3 * 0.0000000001).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float b4);
                    label4.Text = (b4 * 0.001076).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float b5);
                    label5.Text = (b5 * 0.155).ToString("#,##0.###");
                    break;

                case 2:
                    float.TryParse(entry.Text, out float c1);
                    label1.Text = (c1 * 1000000).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float c2);
                    label2.Text = (c2 * 10000000000).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float c3);
                    label3.Text = (c3).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float c4);
                    label4.Text = (c4 * 10763910.417).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float c5);
                    label5.Text = (c5 * 1550003100).ToString("#,##0.###");
                    break;

                case 3:
                    float.TryParse(entry.Text, out float d1);
                    label1.Text = (d1 * 0.092903).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float d2);
                    label2.Text = (d2 * 929.0304).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float d3);
                    label3.Text = (d3 * 0.0000001).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float d4);
                    label4.Text = (d4).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float d5);
                    label5.Text = (d5 * 144).ToString("#,##0.###"); ;
                    break;

                case 4:
                    float.TryParse(entry.Text, out float e1);
                    label1.Text = (e1 * 0.000645).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float e2);
                    label2.Text = (e2 * 6.4516).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float e3);
                    label3.Text = (e3 * 0.000000001).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float e4);
                    label4.Text = (e4 * 0.006944).ToString("#,##0.###");

                    float.TryParse(entry.Text, out float e5);
                    label5.Text = (e5).ToString("#,##0.###");
                    break;
        }
    }
}