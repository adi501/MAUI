namespace MauiApp1;

public partial class EntryEXP1 : ContentPage
{
	public EntryEXP1()
	{
		InitializeComponent();
	}

	private void ExtryCell_TextChanged(object sender, TextChangedEventArgs e)
	{
		DisplayAlert("TextChanged", ExtryCell.Text, "OK");
	}

	private void ExtryCell_Completed(object sender, EventArgs e)
	{

        DisplayAlert("Completed", ExtryCell.Text, "OK");
    }
}