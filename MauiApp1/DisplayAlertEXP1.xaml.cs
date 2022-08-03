namespace MauiApp1;

public partial class DisplayAlertEXP1 : ContentPage
{
	public DisplayAlertEXP1()
	{
		InitializeComponent();
	}

	private void BtnClick_Clicked(object sender, EventArgs e)
	{
        DisplayAlert("Alert", "You are Clicked on Button", "Ok");
    }
}