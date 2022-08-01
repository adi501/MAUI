namespace MauiApp1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void BtnNavigation_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new NavigationPageEXP1());
	}

	private void BtnFlyoutPageEXP_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new FlyoutPageEXP1());
    }

	private void BtnTabbedPageEXP_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new TabbedPageEXP1());
    }

	private void BtnStackLayoutEXP1_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new StackLayoutEXP1());
    }

	private void BtnHorizontalStackLayoutEXP1_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new HorizontalStackLayoutEXP1());
    }

	private void BtnVerticalStackLayoutEXP1_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new VerticalStackLayoutEXP1());
    }
}

