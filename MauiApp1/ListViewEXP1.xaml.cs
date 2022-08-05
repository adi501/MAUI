using System.Collections.ObjectModel;

namespace MauiApp1;

public partial class ListViewEXP1 : ContentPage
{
    public ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();

    public ListViewEXP1()
	{
		InitializeComponent();
        Car objCars = new Car { Name = "Tata Nexon", Details = "Tata nexon Details", Image = "car1.jfif" };
        Cars.Add(objCars);
        objCars = new Car { Name = "Kia Sonet", Details = "Kia Sonet Details", Image = "car2.jfif" };
        Cars.Add(objCars);
        objCars = new Car { Name = "Tata Altroz", Details = "Tata Altroz Details", Image = "car3.jfif" };
        Cars.Add(objCars);
        objCars = new Car { Name = "Hyundai Alcazar", Details = "Hyundai Alcazar Details", Image = "car4.jfif" };
        Cars.Add(objCars);

        ListViewName.ItemsSource = Cars;

    }
}