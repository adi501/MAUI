namespace MauiApp1;

public partial class SliderEXP1 : ContentPage
{
	public SliderEXP1()
	{
		InitializeComponent();
	}

	private void SliderName_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		lblSlider.Text = SliderName.Value.ToString();

    }
}