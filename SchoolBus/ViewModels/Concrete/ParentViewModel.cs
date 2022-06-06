namespace SchoolBus.ViewModels.Concrete;

public class ParentViewModel : ListBaseViewModel<Parent>
{
    public ParentViewModel()
    {
        Items = new(_dbContext.Parents);
    }


    public override void SearchItems()
    {
        if (string.IsNullOrWhiteSpace(SearchValue)) Items = new(_dbContext.Parents);
        else
        {
            var newItems = new ObservableCollection<Parent>();

            foreach (var item in Items)
                if (item.UserName.Contains(SearchValue)) newItems.Add(item);

            Items = newItems;
        }
    }

    public override bool CheckItem()
    {
        if (string.IsNullOrWhiteSpace(InsertItem.FirstName) || string.IsNullOrWhiteSpace(InsertItem.LastName) ||
            string.IsNullOrWhiteSpace(InsertItem.Phone) || string.IsNullOrWhiteSpace(InsertItem.UserName) ||
            string.IsNullOrWhiteSpace(InsertItem.Password)) return false;

        return true;
    }
}
