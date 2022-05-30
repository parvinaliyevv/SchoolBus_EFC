namespace SchoolBus.ViewModels;

public class DriverViewModel
{
    private readonly SchoolBusDbContext _dbContext;

    public ObservableCollection<Driver> Drivers { get; set; }


    public DriverViewModel()
    {
        _dbContext = DI_Container.Container.Resolve<SchoolBusDbContext>();

        Drivers = new(_dbContext.Drivers.Include("Cars"));
    }
}
