namespace SchoolBus.Views;

public partial class MainView : Window
{
    public MainView()
    {
        InitializeComponent();

        DataContext = new MainViewModel();
    }


    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
        Icon = ImageService.GetImageFromByteArray(Images.Title);
        LogoImage.Source = ImageService.GetImageFromByteArray(Images.Logo);
    }
}
