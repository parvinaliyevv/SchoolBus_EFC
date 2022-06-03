namespace SchoolBus.ViewModels.Concrete;

public class HolidaysViewModel
{
    private readonly SchoolBusDbContext _dbContext;

    public ObservableCollection<Holiday> Holidays { get; set; }


    public HolidaysViewModel()
    {
        _dbContext = DI_Container.Container.Resolve<SchoolBusDbContext>();

        Holidays = new(_dbContext.Holidays.ToList());
    }

}
