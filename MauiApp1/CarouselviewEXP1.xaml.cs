using System.Collections.ObjectModel;
namespace MauiApp1;

public partial class CarouselviewEXP1 : ContentPage
{
    public ObservableCollection<Car> Cars { get; set; } = new ObservableCollection<Car>();

    public CarouselviewEXP1()
    {
        InitializeComponent();
        BindingContext = this;
    }
    protected override void OnAppearing()
    {
        Car objCars = new Car { Name = "Tata Nexon", Details = "Tata nexon Details", Image = "car1.jfif" };
        Cars.Add(objCars);
        objCars = new Car { Name = "Kia Sonet", Details = "Kia Sonet Details", Image = "car2.jfif" };
        Cars.Add(objCars);
        objCars = new Car { Name = "Tata Altroz", Details = "Tata Altroz Details", Image = "car3.jfif" };
        Cars.Add(objCars);
        objCars = new Car { Name = "Hyundai Alcazar", Details = "Hyundai Alcazar Details", Image = "car4.jfif" };
        Cars.Add(objCars);
    }
}
public class Car
{
    public string Name { get; set; }
    public string Details { get; set; }
    public string Image { get; set; }
}