namespace SchoolBus.ViewModels.Concrete;

public class GroupViewModel: ListBaseViewModel<Group>
{
    public GroupViewModel()
    {
        Items = new(_dbContext.Groups);
        InsertItem = new();
    }


    public override bool CheckItem()
    {
        if (string.IsNullOrWhiteSpace(InsertItem.Title)) return false;


        return true;
    }
}
