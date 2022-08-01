namespace MauiApp1;

public partial class NavigationPageEXP1 : ContentPage
{
	public NavigationPageEXP1()
	{
		InitializeComponent();
	}

	private void BtnNavigation_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MainPage());

    }
}