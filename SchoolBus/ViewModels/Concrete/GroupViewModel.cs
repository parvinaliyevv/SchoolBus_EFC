namespace SchoolBus.ViewModels.Concrete;

public class GroupViewModel: ListBaseViewModel<Group>
{
    public GroupViewModel()
    {
        Items = new(_dbContext.Groups);
        InsertItem = new();
    }

    public override void SearchItems()
    {
        if (string.IsNullOrWhiteSpace(SearchValue)) Items = new(_dbContext.Groups);
        else
        {
            var newItems = new ObservableCollection<Group>();

            foreach (var item in Items)
                if (item.Title.Contains(SearchValue)) newItems.Add(item);

            Items = newItems;
        }
    }

    public override bool CheckItem()
    {
        if (string.IsNullOrWhiteSpace(InsertItem.Title)) return false;


        return true;
    }
}
