namespace MauiApp1;

public partial class SearchBarEXP1 : ContentPage
{
    public SearchBarEXP1()
    {
        InitializeComponent();
    }

    private void SearchBarName_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Search Alert", SearchBarName.Text, "OK");
    }
}