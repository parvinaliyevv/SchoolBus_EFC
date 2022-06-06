namespace SchoolBus.Views;

public partial class ParentView : Page
{
    public ParentView()
    {
        InitializeComponent();

        DataContext = new ParentViewModel();
    }

    private void PasswordBox_ValueChanged(object sender, RoutedEventArgs e)
    {
        (this.DataContext as ParentViewModel).InsertItem.Password = ParentPassword.Password;
    }
}
