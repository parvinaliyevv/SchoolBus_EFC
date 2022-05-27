namespace SchoolBus.ViewModels;

public class MainViewModel: DependencyObject
{
    public Page SelectedPage
    {
        get { return (Page)GetValue(MyPropertyProperty); }
        set { SetValue(MyPropertyProperty, value); }
    }
    public static readonly DependencyProperty MyPropertyProperty =
        DependencyProperty.Register("SelectedPage", typeof(Page), typeof(MainViewModel));


    public RelayCommand OpenHolidaysPageCommand { get; set; }
    public RelayCommand OpenCarPageCommand { get; set; }


    public MainViewModel()
    {
        OpenHolidaysPageCommand = new RelayCommand(sender => SelectedPage = new HolidaysView());
        OpenCarPageCommand = new RelayCommand(sender => SelectedPage = new CarView());
    }
}
