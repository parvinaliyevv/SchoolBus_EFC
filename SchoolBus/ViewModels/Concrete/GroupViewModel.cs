namespace SchoolBus.ViewModels.Concrete;

public class GroupViewModel: ListBaseViewModel<Group>
{
    public GroupViewModel()
    {
        Items = new(_dbContext.Groups);
        InsertItem = new();
    }


    public override void InsertDatabase()
    {
        // Some logic code
    }
}
