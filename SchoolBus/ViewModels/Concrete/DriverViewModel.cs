namespace SchoolBus.ViewModels.Concrete;

public class DriverViewModel : ListBaseViewModel<Driver>
{
    public ObservableCollection<Car> Cars { get; set; }


    public DriverViewModel()
    {
        Items = new(_dbContext.Drivers.Include("Cars"));
        Cars = new(_dbContext.Cars);
    }

    public override void SearchItems()
    {
        if (string.IsNullOrWhiteSpace(SearchValue)) Items = new(_dbContext.Drivers);
        else
        {
            var newItems = new ObservableCollection<Driver>();

            foreach (var item in Items)
                if (item.UserName.Contains(SearchValue)) newItems.Add(item);

            Items = newItems;
        }
    }

    public override bool CheckItem()
    {
        if (string.IsNullOrWhiteSpace(InsertItem.FirstName) || string.IsNullOrWhiteSpace(InsertItem.LastName) ||
            string.IsNullOrWhiteSpace(InsertItem.Phone) || string.IsNullOrWhiteSpace(InsertItem.UserName) ||
            string.IsNullOrWhiteSpace(InsertItem.License) || string.IsNullOrWhiteSpace(InsertItem.Password)) return false;

        return true;
    }
}
