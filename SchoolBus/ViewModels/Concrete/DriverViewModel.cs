namespace SchoolBus.ViewModels.Concrete;

public class DriverViewModel : ListBaseViewModel<Driver>
{
    public DriverViewModel()
    {
        Items = new(_dbContext.Drivers.Include("Cars"));
        InsertItem = new();
    }


    public override void InsertDatabase()
    {
        // Some logic code
    }

    public override bool CheckItem()
    {
        return true;
    }
}
