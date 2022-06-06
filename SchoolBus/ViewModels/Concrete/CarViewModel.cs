namespace SchoolBus.ViewModels.Concrete;

public class CarViewModel: ListBaseViewModel<Car>
{
    public CarViewModel()
    {
        Items = new(_dbContext.Cars.Include("Driver"));
        InsertItem = new();
    }


    public override bool CheckItem()
    {
        if (string.IsNullOrWhiteSpace(InsertItem.Title) || string.IsNullOrWhiteSpace(InsertItem.Number) ||
            string.IsNullOrWhiteSpace(InsertItem.SeatCount.ToString()) || InsertItem.SeatCount <= 0) return false;

        return true;
    }
}
