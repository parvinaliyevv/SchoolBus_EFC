namespace SchoolBus.ViewModels.Concrete;

public class CarViewModel: ListBaseViewModel<Car>
{
    public CarViewModel()
    {
        Items = new(_dbContext.Cars.Include("Driver"));
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
