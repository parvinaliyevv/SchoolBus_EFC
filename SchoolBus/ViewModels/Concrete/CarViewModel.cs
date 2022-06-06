namespace SchoolBus.ViewModels.Concrete;

public class CarViewModel: ListBaseViewModel<Car>
{
    public CarViewModel()
    {
        Items = new(_dbContext.Cars.Include("Driver"));
    }


    public override void SearchItems()
    {
        if (string.IsNullOrWhiteSpace(SearchValue)) Items = new(_dbContext.Cars);
        else
        {
            var newItems = new ObservableCollection<Car>();

            foreach (var item in Items)
                if (item.Title.Contains(SearchValue)) newItems.Add(item);

            Items = newItems;
        }
    }

    public override bool CheckItem()
    {
        if (string.IsNullOrWhiteSpace(InsertItem.Title) || string.IsNullOrWhiteSpace(InsertItem.Number) ||
            string.IsNullOrWhiteSpace(InsertItem.SeatCount.ToString()) || InsertItem.SeatCount <= 0) return false;

        return true;
    }
}
