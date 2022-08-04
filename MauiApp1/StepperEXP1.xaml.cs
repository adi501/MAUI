namespace MauiApp1;

public partial class StepperEXP1 : ContentPage
{
	public StepperEXP1()
	{
		InitializeComponent();
	}

	private void StepperName_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		if(StepperName!=null)
		{
			lblData.Text = StepperName.Value.ToString();
		}
	}
}