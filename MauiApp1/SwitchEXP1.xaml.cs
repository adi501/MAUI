namespace MauiApp1;

public partial class SwitchEXP1 : ContentPage
{
	public SwitchEXP1()
	{
		InitializeComponent();
	}


	private void Switch_Toggled(object sender, ToggledEventArgs e)
	{
		if (Switch.IsToggled)
		{
			lblData.Text = "On";
		}
		else
		{
			lblData.Text = "OFF";
        }
    }
}