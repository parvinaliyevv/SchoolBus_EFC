namespace SchoolBus.Views;

public partial class CreateRideView : Page
{
    public CreateRideView()
    {
        InitializeComponent();

        DataContext = new CreateRideViewModel();
    }
}
