namespace SchoolBus.ViewModels.Concrete;

public class CreateRideViewModel : DependencyObject, IAddViewModel<Ride>, ISearchViewModel
{
    private readonly SchoolBusDbContext _dbContext;


    public ObservableCollection<Student> Students
    {
        get { return (ObservableCollection<Student>)GetValue(ItemsProperty); }
        set { SetValue(ItemsProperty, value); }
    }
    public static readonly DependencyProperty ItemsProperty =
        DependencyProperty.Register("Students", typeof(ObservableCollection<Student>), typeof(CreateRideViewModel));


    public ObservableCollection<Driver> Drivers
    {
        get { return (ObservableCollection<Driver>)GetValue(DriversProperty); }
        set { SetValue(DriversProperty, value); }
    }
    public static readonly DependencyProperty DriversProperty =
        DependencyProperty.Register("Drivers", typeof(ObservableCollection<Driver>), typeof(CreateRideViewModel));


    public RelayCommand InsertCommand { get; set; }
    public Ride InsertItem { get; set; }

    public RelayCommand SearchCommand { get; set; }
    public string SearchValue { get; set; }


    public Ride Ride { get; set; }


    public CreateRideViewModel()
    {
        _dbContext = DI_Container.Container.Resolve<SchoolBusDbContext>();

        // Students = new(_dbContext.Students);

        Ride = new();
    }


    public bool CheckItem()
    {
        return true;
    }

    public void SearchItems()
    {
        
    }
}
