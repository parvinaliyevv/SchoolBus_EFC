namespace SchoolBus.Views;

public partial class CarView : Page
{
    public CarView()
    {
        InitializeComponent();

        DataContext = new CarViewModel();
    }
}
