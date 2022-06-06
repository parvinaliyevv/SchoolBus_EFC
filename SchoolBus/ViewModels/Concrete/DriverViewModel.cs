namespace SchoolBus.ViewModels.Concrete;

public class DriverViewModel : ListBaseViewModel<Driver>
{
    public ObservableCollection<Car> Cars { get; set; }


    public DriverViewModel()
    {
        Items = new(_dbContext.Drivers.Include("Cars"));
        InsertItem = new();

        Cars = new(_dbContext.Cars);
    }


    public override bool CheckItem()
    {
        return true;
    }
}
