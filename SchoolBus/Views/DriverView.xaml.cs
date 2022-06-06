namespace SchoolBus.Views;

public partial class DriverView : Page
{
    public DriverView()
    {
        InitializeComponent();

        DataContext = new DriverViewModel();
    }

    private void PasswordBox_ValueChanged(object sender, RoutedEventArgs e)
    {
        (this.DataContext as DriverViewModel).InsertItem.Password = DriverPasswordBox.Password;
    }
}
