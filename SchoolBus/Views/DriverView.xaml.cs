namespace SchoolBus.Views;

public partial class DriverView : Page
{
    public DriverView()
    {
        InitializeComponent();

        DataContext = new DriverViewModel();
    }
}
