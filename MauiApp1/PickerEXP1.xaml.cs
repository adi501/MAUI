namespace MauiApp1;

public partial class PickerEXP1 : ContentPage
{
	public PickerEXP1()
	{
		InitializeComponent();
		List<String> Names = new List<string>();
		Names.Add("Adi");
		Names.Add("Pavan");
        Names.Add("Madhan");
        Names.Add("Yagnesh");
        Names.Add("Nani");
        PickerName.ItemsSource = Names;
    }
}