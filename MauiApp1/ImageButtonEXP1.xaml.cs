namespace MauiApp1;

public partial class ImageButtonEXP1 : ContentPage
{
	public ImageButtonEXP1()
	{
		InitializeComponent();
	}

	private void ImgButton_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Alert", "Clicked on Image Button","Ok");
	}

}